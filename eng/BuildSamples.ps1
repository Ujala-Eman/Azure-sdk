﻿$baseDir = Join-Path $env:BUILD_SOURCESDIRECTORY "samples"
$items = Get-ChildItem -Path $baseDir -Include *.csproj -Recurse
foreach ($item in $items){
    dotnet build $item
}