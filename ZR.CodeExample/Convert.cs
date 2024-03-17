using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;

namespace ZR.CodeExample 
{
    public static class Convert
    {
        public static string StringToJson(string JsonString)
        {
           // Convert string to JSON
            JsonDocument jsonDocument = JsonDocument.Parse(JsonString);

            return JsonSerializer.Serialize(jsonDocument.RootElement); 
        }
        public static string JsonToString(string JsonString)
        {
        
            // Convert JSON to string
            JsonDocument jsonDocument = JsonDocument.Parse(JsonString);
            
            return jsonDocument.RootElement.GetRawText(); 
        }

        public static string StringToBase64(string Base64String)
        {
          
            // Convert string to Base64
            byte[] bytes = Encoding.UTF8.GetBytes(Base64String);

            return System.Convert.ToBase64String(bytes);
        }

        public static  string Base64ToString(string Base64String)
        {
            // Convert Base64 to string
            byte[] bytes = System.Convert.FromBase64String(Base64String);

            return Encoding.UTF8.GetString(bytes);
        }

        public static string StringToXml(string XmlString)
        {
            // Convert string to XML
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(XmlString);
                         
            return xmlDocument.OuterXml; ;
        }

        public static string XmlToString(string XmlString)
        {
            
            // Convert XML to string
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(XmlString);

            return xmlDocument.OuterXml;
        }

        public static string StringToCsv(string CsvString)
        {

            // Convert string to CSV
            StringBuilder csvBuilder = new StringBuilder();

            foreach (string line in CsvString.Split('\n'))
            {
                string[] values = line.Split(',');
                csvBuilder.AppendLine(string.Join(",", values));
            }

            return csvBuilder.ToString(); 
        }

        public static string CsvToString(string CsvString)
        {
            // Convert CSV to string
            StringBuilder stringBuilder = new StringBuilder();

            foreach (string line in CsvString.Split('\n'))
            {
                string[] values = line.Split(',');
                stringBuilder.AppendLine(string.Join(",", values));
            }

            return stringBuilder.ToString();
        }

    }
}
