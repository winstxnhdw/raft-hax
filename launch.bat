@echo off

rmdir /s /q bin
rmdir /s /q "raft-hax/obj"
cls

dotnet build raft-hax
start /wait /b ./submodules/SharpMonoInjectorCore/bin/SharpMonoInjector.exe inject -p Raft -a bin/raft-hax.dll -n Hax -c Loader -m Load

pause