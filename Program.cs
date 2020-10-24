

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

class Program
{
    private const string V = "Provider=Microsoft.Jet.OLEDB.4.0;";

    static void Main(string[] args)
    {
        Dictionary<string, string> values = new Dictionary<string, string>();
        for (int i = 0; i < args.Length; i += 2)
        {
            values.Add(args[i], args[i + 1]);
        }
        String xls = values["-xsl"];
        String sql = values["-sql"];
        
        string sConnectionString = V + "Data Source=" + xls + ";Extended Properties=Excel 8.0;";
        OleDbConnection objConn = new OleDbConnection(sConnectionString);
        objConn.Open();
        OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
        objAdapter1.SelectCommand = new OleDbCommand(sql, objConn);
        DataSet objDataset1 = new DataSet();
        objAdapter1.Fill(objDataset1, "XLData");
        DataTable tblAuthors = objDataset1.Tables[0];
        String rowstr = "";
        foreach (DataColumn column in tblAuthors.Columns)
        {
            rowstr += column.ToString() + ";";
        }
        Console.WriteLine(rowstr.Substring(0, rowstr.Length - 1));
        foreach (DataRow drCurrent in tblAuthors.Rows)
        {
            rowstr = "";
            foreach (DataColumn column in tblAuthors.Columns)
            {
                rowstr += drCurrent[column].ToString() + ";";
            }
            Console.WriteLine(rowstr.Substring(0, rowstr.Length - 1));
        }
        objConn.Close();
    }
}
