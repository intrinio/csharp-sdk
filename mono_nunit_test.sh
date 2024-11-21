#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync

echo "[INFO] remove bin/Debug/SwaggerClientTest.dll"
rm src/Intrinio.SDK.Test/bin/Debug/Intrinio.SDK.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync
mono nuget.exe install src/Intrinio.SDK.Test/packages.config -o packages

echo "[INFO] Install NUnit runners via NuGet"
mono nuget.exe install NUnit.Runners -Version 4.2.2 -OutputDirectory packages

echo "[INFO] Build the solution and run the unit test"
xbuild Intrinio.SDK.sln && \
    mono ./packages/NUnit.Runners.4.2.2/tools/nunit-console.exe src/Intrinio.SDK.Test/bin/Debug/Intrinio.SDK.Test.dll
