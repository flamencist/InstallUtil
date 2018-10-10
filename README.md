# InstallUtil
[![Build Status](https://travis-ci.org/flamencist/InstallUtil.svg?branch=master)](https://travis-ci.org/flamencist/InstallUtil)
[![NuGet](https://img.shields.io/nuget/v/InstallUtil.svg)](https://www.nuget.org/packages/InstallUtil/)


InstallUtil (global tool) (https://docs.microsoft.com/en-us/dotnet/framework/tools/installutil-exe-installer-tool) version  for DotNetCore. 
Based on Core.System.Configuration.Install (https://github.com/flamencist/Core.System.Configuration.Install)

### Installation: install as global tool (https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools)
```
dotnet tool install -g InstallUtil
```

### Command for execution:
```
InstallUtil SomeInstaller.dll

```
### InstallUtil help:
``` 
InstallUtil executes the installers in each given assembly.
If the -u or -uninstall switch is specified, it uninstalls
the assemblies, otherwise it installs them. Unlike other
options, -u applies to all assemblies, regardless of where it
appears on the command line.

Installation is done in a transactioned way: If one of the
assemblies fails to install, the installations of all other
assemblies are rolled back. Uninstall is not transactioned.

Options take the form -switch=[value]. Any option that occurs
before the name of an assembly will apply to that assembly's
installation. Options are cumulative but overridable - options
specified for one assembly will apply to the next as well unless
the option is specified with a new value. The default for all
options is empty or false unless otherwise specified.

Options recognized:

Options for installing any assembly:
-AssemblyName
 The assembly parameter will be interpreted as an assembly name (Name,
 Locale, PublicKeyToken, Version). The default is to interpret the
 assembly parameter as the filename of the assembly on disk.

-LogFile=[filename]
 File to write progress to. If empty, do not write log. Default
 is <assemblyname>.InstallLog

-LogToConsole={true|false}
 If false, suppresses output to the console.

-ShowCallStack
 If an exception occurs at any point during installation, the call
 stack will be printed to the log.

-InstallStateDir=[directoryname]
 Directory in which the .InstallState file will be stored. Default
 is the directory of the assembly.


Individual installers used within an assembly may recognize other
options. To learn about these options, run InstallUtil with the paths
of the assemblies on the command line along with the -? or -help option.
```


