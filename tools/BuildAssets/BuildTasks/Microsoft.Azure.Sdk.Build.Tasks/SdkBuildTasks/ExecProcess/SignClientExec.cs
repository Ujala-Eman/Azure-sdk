﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Sdk.Build.ExecProcess
{
    using Microsoft.Azure.Sdk.Build.Tasks.Utilities;
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Diagnostics;
    using System.Threading;

    /// <summary>
    /// TODO: Make exec base as Task
    /// </summary>
    public class SignClientExec : ShellExec
    {
        //ESRPClient sign ​-a c:/somefolder/auth.json, -c c:/somefolder/config.json -p c:/somefolder/policy.json -i c:/somefolder/input.json -o c:/somefolder/output.json

        private const int SignUtilityDefaultTimeOut = 360000;

        private string signClientExecName = "ESRPClient.exe";
        private string ciConfigDir;
        ProcessStartInfo _shellProcStartInfo;

        /// <summary>
        /// Root direcotry for CI tools
        /// </summary>

        public string CiToolsRootDir { get; set; }

        /// <summary>
        /// Signing Client input file
        /// </summary>
        public string SigningInputManifestFilePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SigningResultOutputFilePath { get; set; }

        private string SigningLogFilePath
        {
            get
            {
                return Path.Combine(Path.GetDirectoryName(SigningInputManifestFilePath), "SigningLog.txt");
            }
        }

        /// <summary>
        /// Defautl time for the shell process
        /// </summary>
        protected override int DefaultTimeOut => SignUtilityDefaultTimeOut;

        /// <summary>
        /// Build commandline args string
        /// </summary>
        /// <returns></returns>
        protected override string BuildShellProcessArgs()
        {
            return string.Format("{0} -a {1} -c {2} -p {3} -i {4} -o {5} -l {6} -f {7}", "Sign", Path.Combine(ciConfigDir, "AdxSdkAuth.json"),
                Path.Combine(ciConfigDir, "Config.json"), Path.Combine(ciConfigDir, "Policy.json"), SigningInputManifestFilePath, SigningResultOutputFilePath, "Verbose", SigningLogFilePath);
        }

        public string GetShellProcessArgsForLogging()
        {
            return string.Format("{0} -a {1} -c {2} -p {3} -i {4} -o {5} -l {6} -f {7}", "Sign", "AdxSdkAuth.json",  "Config.json", "Policy.json",
                SigningInputManifestFilePath, SigningResultOutputFilePath, "Verbose", SigningLogFilePath);
        }


        public SignClientExec() : base() { }

        public SignClientExec(string commandPath) : base(commandPath) { }


        public override ProcessStartInfo ShellProcessInfo
        {
            get
            {
                if (_shellProcStartInfo == null)
                {
                    _shellProcStartInfo = new ProcessStartInfo(ShellProcessCommandPath);
                    //_shellProcStartInfo.CreateNoWindow = true;
                    _shellProcStartInfo.UseShellExecute = true;
                    //_shellProcStartInfo.RedirectStandardError = true;
                    //_shellProcStartInfo.RedirectStandardInput = true;
                    //_shellProcStartInfo.RedirectStandardOutput = true;
                }

                return _shellProcStartInfo;
            }
        }

        public override int ExecuteCommand()
        {
            VerifyRequiredProperties();
            //CloseOpenedHandles();
            //Thread.Sleep(120000);
            Thread.Sleep(5000);
            int exitCode = ExecuteCommand(BuildShellProcessArgs());
            return exitCode;
        }

        public override int ExecuteCommand(string args)
        {
            try
            {
                ShellProcess.StartInfo.Arguments = args;
                ShellProcess.Start();
                int procId = ShellProcess.Id;
                TrackProcess(procId);
                Thread.Sleep(30000);
                LastExitCode = ShellProcess.ExitCode;
            }
            catch (Win32Exception win32Ex)
            {
                LastExitCode = win32Ex.ErrorCode;
                LastException = win32Ex;
            }
            catch (Exception ex)
            {
                LastExitCode = ex.HResult;
                LastException = ex;
            }

            return LastExitCode;
        }

        private void VerifyRequiredProperties()
        {
            Check.DirectoryExists(CiToolsRootDir);
            var clientExes = Directory.EnumerateFiles(CiToolsRootDir, signClientExecName, SearchOption.AllDirectories);
            Check.NotNull(clientExes, "SignUtility not found");
            if(clientExes.Any<string>())
            {
                this.ShellProcessCommandPath = clientExes.First<string>();
                Check.FileExists(this.ShellProcessCommandPath);
            }

            ciConfigDir = Path.Combine(CiToolsRootDir, @"tools\ESRPClient\configs");
            Check.DirectoryExists(ciConfigDir);
            Check.FileExists(Path.Combine(ciConfigDir, "AdxSdkAuth.json"));
            Check.FileExists(Path.Combine(ciConfigDir, "Config.json"));
            Check.FileExists(Path.Combine(ciConfigDir, "Policy.json"));
        }

        private void CloseOpenedHandles()
        {
            Process currProc = Process.GetCurrentProcess();
            int currProcId = currProc.Id;

            var msbuildProcs = Process.GetProcessesByName("Msbuild");
            var orphanedProc = msbuildProcs.Where<Process>((p) => p.Id != currProcId);

            if(orphanedProc.Any<Process>())
            {
                Process procToClose = orphanedProc.First<Process>();
                int procToTrackForClosing = procToClose.Id;

                try
                {
                    if (procToClose != null)
                    {
                        procToClose.Close();
                        procToClose.Kill();
                    }
                }
                catch { }

                TrackProcess(procToTrackForClosing);
            }
        }

        private void TrackProcess(int procIdToTrack)
        {
            var process2 = Process.GetProcessById(procIdToTrack);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            TimeSpan elapsed = sw.Elapsed;
            while ((elapsed < TimeSpan.FromMinutes(2)) && (process2.HasExited == false))
            {
                elapsed = sw.Elapsed;
                try
                {
                    process2 = Process.GetProcessById(procIdToTrack);
                    Thread.Sleep(10000);
                }
                catch (ArgumentException)
                {
                    sw.Stop();
                    Thread.Sleep(5000);
                    break;
                }
            }
        }
    }
}
