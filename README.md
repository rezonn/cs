# Dotnet tutorial with packages, console arguments, sql to Excel97

* Install [dotnet](https://dotnet.microsoft.com/download)
* Open cmd, goto desktop, create app "ww", run it
```
cd %UserProfile%\Desktop
dotnet new console -o ww
cd ww
dotnet run
```
* Replace [Program.cs](Program.cs)
* Program requred package "System.Data.OleDb", 32bit mode (for Microsoft.Jet.OLEDB.4.0), and run with console arguments ("xsl" and "sql").
```
dotnet add package System.Data.OleDb
dotnet run -r win-x86 -- -xsl "C:\\Path\\to\\data.xls" -sql "SELECT * FROM names"
```

* Compile 
```
dotnet publish -r win-x86 -p:PublishSingleFile=true --self-contained false
```
* Compile with packages
```
dotnet publish -r win-x86 -p:PublishSingleFile=true --self-contained true
```
* Find
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
