# C# console SQL to Excel

* Install [dotnet](https://dotnet.microsoft.com/download)
* Open cmd. Goto desktop
```
cd %UserProfile%\Desktop
dotnet new console -o ww
```
* Create app "ww", run it
```
cd ww
dotnet run
```
* Replace [Program.cs](Program.cs)
* Add package "System.Data.OleDb" to project
```
dotnet add package System.Data.OleDb
```
* Microsoft.Jet.OLEDB requred  32bit mode, and console arguments ("xsl" and "sql"):
```
dotnet run -r win-x86 -- -xsl "C:\\Path\\to\\data.xls" -sql "SELECT * FROM names"
```
* Compile 
```
dotnet publish -r win-x86 -p:PublishSingleFile=true --self-contained false
```
* Finish, all files in folder
```
cd bin\Debug\netcoreapp3.1\win-x86\publish
```
* Run it
```
ww -xsl "C:\\Path\\to\\data.xls" -sql "SELECT * FROM names"
```

# Note
* Sublime 2 build
```
{
	"cmd": ["dotnet", "run"],
	"encoding": "cp866"
}
```
* [About classes](https://docs.microsoft.com/ru-ru/dotnet/csharp/tutorials/intro-to-csharp/introduction-to-classes)
