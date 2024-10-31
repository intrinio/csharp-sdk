

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v4.0.30319

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\Intrinio.SDK\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.13.0.3\lib\net45\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\JsonSubTypes.2.0.1\lib\net45\JsonSubTypes.dll bin\JsonSubTypes.dll
copy packages\RestSharp.112.0.0\lib\net45\RestSharp.dll bin\RestSharp.dll
copy packages\Polly.8.4.1\lib\net472\Polly.dll bin\Polly.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\JsonSubTypes.dll;bin\RestSharp.dll;bin\Polly.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\Intrinio.SDK.dll /recurse:src\Intrinio.SDK\*.cs /doc:bin\Intrinio.SDK.xml
