# cs

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
dotnet run -r win-x86 -- -xsl "C:\\Users\\1080ti\\Desktop\\publish\\data.xls" -sql "SELECT * FROM myRange1"
```
* Note


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
