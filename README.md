# cs

* 
```
cd %UserProfile%\Desktop
dotnet new console -o myApp
cd myApp
dotnet run
```
* [hello world](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/create) - 

* Sublime 2 build
```
{
	"cmd": ["dotnet", "run"],
	"encoding": "cp866"
}
```
* single file
```
dotnet add package System.Data.OleDb
dotnet publish -r win-x86 -p:PublishSingleFile=true --self-contained true
dotnet publish -r win-x86 -p:PublishSingleFile=true --self-contained false
```
