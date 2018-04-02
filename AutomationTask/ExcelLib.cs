using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AutomationTask
{
  public class ExcelLib
    {
      private static DataTable ExcelToDataTable(string fileName)
      {
            #region For Excel file
            //open file and returns as Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //Createopenxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx
                                                                                           //Set the First Row as Column Name
            excelReader.IsFirstRowAsColumnNames = true;
            //Return as DataSet
            DataSet result = excelReader.AsDataSet();
            //Get all the Tables
            DataTableCollection table = result.Tables;
            //Store it in DataTable
            DataTable resultTable = table["Sheet1"];

            //return
            return resultTable;
            #endregion

            #region For CSV file
            //  DataTable dt = new DataTable();
            //using (StreamReader sr = new StreamReader(fileName))
            //{
            //    string[] headers = sr.ReadLine().Split(',');
            //    foreach (string header in headers)
            //    {
            //        dt.Columns.Add(header);
            //    }
            //    while (!sr.EndOfStream)
            //    {
            //        string[] rows = sr.ReadLine().Split(',');
            //        DataRow dr = dt.NewRow();
            //        for (int i = 0; i < headers.Length; i++)
            //        {
            //            dr[i] = rows[i];
            //        }
            //        dt.Rows.Add(dr);
            //    }
            //}
            //return dt;
            #endregion

            #region JSON File
            //string json = "{ 'EmailId' : 'abc21@g.com','Password':'abc@123' }";
            //  DataTable table = new DataTable();
            ////  JObject o1 = JObject.Parse(File.ReadAllText(fileName));
            ////  StreamReader file = File.OpenText(fileName);
            //DataTable table1 = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(json);
            //table = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            // read JSON directly from a file

            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //}
            //  DataTable table = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(fileName);

           // return table;
            #endregion
        }

        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }

      static  List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

    public class Output
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }
}
