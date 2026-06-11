@echo off
setlocal
cd /d "%~dp0.."

set CoreTargetFramework=net472
set CoreLibPath=%CD%\.application\net-framework\core-bin
set RelativePkgFolderPath=%CD%\.application\net-framework\packages

dotnet test tests\UnitTests.slnx -c dev-nf
endlocal