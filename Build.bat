@echo off

:: Get MSBuild.exe directory.
set MS_BUILD="%WINDIR%\Microsoft.NET\Framework\v3.5\msbuild.exe"

if not exist %MS_BUILD% (
	echo Cannot find .NET Framework 3.5.
	pause
	exit
)

%MS_BUILD% ToolStripCustomizer.sln /t:Rebuild /p:Configuration=Release /p:OutputPath=..\Bin

if not %ERRORLEVEL%==0 (
	pause
	exit
)