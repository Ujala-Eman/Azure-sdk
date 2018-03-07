<#



.SYNOPSIS
    Powershell script that generates the C# code for your sdk usin the config file provided

.DESCRIPTION
    This script:
    - fetches the config file from user/branch provided
    - Generates code based off the config file provided
    - into the directory path provided

.PARAMETER ResourceProvider
    The Resource provider for whom to generate the code; also helps determine path where config file is located in repo

.PARAMETER Version
    The AutoRest version to use to generate the code, "latest" is recommended

.PARAMETER SpecsRepoFork
    The Rest Spec repo fork which contains the config file

.PARAMETER SpecsRepoBranch
    The Branch which contains the config file

.PARAMETER SpecsRepoName
    The name of the repo that contains the config file (Can only be either of azure-rest-api-specs or azure-rest-api-specs-pr)

.PARAMETER SdkFolder
    The path where to generate the code

.EXAMPLE
    A sample command that uses the function or script, optionally followed
    by sample output and a description. Repeat this keyword for each example.

.NOTES
    Additional information about the function or script.

.LINK
    The name of a related topic. Repeat this keyword for each related topic.

    This content appears in the Related Links section of the Help topic.

    The Link keyword content can also include a Uniform Resource Identifier
    (URI) to an online version of the same Help topic. The online version
    opens when you use the Online parameter of Get-Help. The URI must begin
    with "http" or "https".
#>

Param(
    [Parameter(Mandatory = $true)]
    [string] $ResourceProvider,
    [string] $SpecsRepoFork = "Azure",
    [string] $SpecsRepoName = "azure-rest-api-specs",
    [string] $SpecsRepoBranch = "master",
    [Parameter(Mandatory = $true)]
    [string] $SdkDirectory,
    [string] $Version = "latest"
)

Write-Host "Importing code generation module"
$currPath = split-path $SCRIPT:MyInvocation.MyCommand.Path -parent
$modulePath = "$currPath\SdkBuildTools\psModules\CodeGenerationModules\generateDotNetSdkCode.psm1"

Import-Module "$modulePath"

Install-AutoRest $Version

$configFile="https://github.com/$SpecsRepoFork/$SpecsRepoName/blob/$SpecsRepoBranch/specification/$ResourceProvider/readme.md"
Write-Host "Commencing code generation"
Start-CodeGeneration -ConfigFile $configFile -SdkDirectory $SdkDirectory -Version $Version

Write-Host "Logging metadata"
$logFile = "$currPath\..\src\SDKs\_metadata\$($ResourceProvider.Replace("/","_")).txt"
Start-MetadataGeneration -SpecsRepoFork $SpecsRepoFork -SpecsRepoBranch $SpecsRepoBranch -Version $Version | Out-File -filepath $logFile

Get-Module | Remove-Module