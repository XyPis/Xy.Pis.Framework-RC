set packages=.\packages

if not exist %packages% md %packages%
@echo Successfully create '%packages%' folder

NuGet pack ..\Xy.Pis.Utils\Xy.Pis.Utils.csproj -o .\packages -Build -Properties Configuration=Release
NuGet pack ..\Xy.Pis.Contract\Xy.Pis.Contract.csproj -o .\packages -Build -Properties Configuration=Release
NuGet pack ..\Xy.Pis.Core\Xy.Pis.Core.csproj -o .\packages -Build -Properties Configuration=Release
NuGet pack ..\Xy.Pis.Data\Xy.Pis.Data.csproj -o .\packages -Build -Properties Configuration=Release
NuGet pack ..\Xy.Pis.Proxy\Xy.Pis.Proxy.csproj -o .\packages -Build -Properties Configuration=Release

NuGet push .\packages\*.nupkg -s http://localhost:8080 123

Del /Q .\packages\*
