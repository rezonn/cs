

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Xml.Xsl;

namespace ww
{
    static class XLS
    {
        public static string Query(string xls, string sql)
        {
            string V = "Provider=Microsoft.Jet.OLEDB.4.0;";
            string sConnectionString = V + "Data Source=" + xls + ";Extended Properties=Excel 8.0;";
            OleDbConnection objConn = new OleDbConnection(sConnectionString);
            objConn.Open();
            OleDbDataAdapter objAdapter1 = new OleDbDataAdapter();
            objAdapter1.SelectCommand = new OleDbCommand(sql, objConn);
            DataSet objDataset1 = new DataSet();
            objAdapter1.Fill(objDataset1, "XLData");
            DataTable tblAuthors = objDataset1.Tables[0];
            String rv = "";
            String rowstr = "";
            foreach (DataColumn column in tblAuthors.Columns)
            {
                rowstr += column.ToString() + ";";
            }
            rv += (rowstr.Substring(0, rowstr.Length - 1));
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                rowstr = "";
                foreach (DataColumn column in tblAuthors.Columns)
                {
                    rowstr += drCurrent[column].ToString() + ";";
                }
                rv += "\n" + (rowstr.Substring(0, rowstr.Length - 1));
            }
            objConn.Close();
            return rv;
        }
    }
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            for (int i = 0; i < args.Length; i += 2)
            {
                values.Add(args[i], args[i + 1]);
            }
            if (values.ContainsKey("-xsl") && values.ContainsKey("-sql"))
            {
                String xls = values["-xsl"];
                String sql = values["-sql"];
                Console.WriteLine(XLS.Query(xls,sql));
            }
        }
    }
}
