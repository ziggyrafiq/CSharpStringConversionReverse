
Console.WriteLine("Welcome to Ziggy Rafiq Article Post on \nConverting Strings in C#: JSON, Base64, XML, CSV and Reverse");
Console.WriteLine("\n");

Console.WriteLine("Converting String to Json");
Console.WriteLine(ZR.CodeExample.Convert.StringToJson("{\"name\":\"John\",\"age\":30}"));
Console.WriteLine("\n");

Console.WriteLine("Converting Json to String");
Console.WriteLine(ZR.CodeExample.Convert.StringToJson("{\"name\":\"Lisa\",\"age\":25}"));
Console.WriteLine("\n");

Console.WriteLine("Converting String to Base64");
Console.WriteLine(ZR.CodeExample.Convert.StringToBase64("I am Ziggy Rafiq and proud to write Articles for C# Corner. I work for Capgemini."));
Console.WriteLine("\n");
Console.WriteLine("Converting Base64 to String");
//Base64 Output value: I am Ziggy Rafiq and proud to write Articles for C# Corner. I work for Capgemini.
Console.WriteLine(ZR.CodeExample.Convert.Base64ToString("SSBhbSBaaWdneSBSYWZpcSBhbmQgcHJvdWQgdG8gd3JpdGUgQXJ0aWNsZXMgZm9yIEMjIENvcm5l\r\nci4gSSB3b3JrIGZvciBDYXBnZW1pbmku"));
Console.WriteLine("\n");

Console.WriteLine("Converting String to XML");
Console.WriteLine(ZR.CodeExample.Convert.StringToXml("<root><name>John</name><age>30</age></root>"));
Console.WriteLine("\n");

Console.WriteLine("Converting XML to String");
Console.WriteLine(ZR.CodeExample.Convert.XmlToString("<root><name>Peter</name><age>40</age></root>"));
Console.WriteLine("\n");

Console.WriteLine("Converting String to CSV");
Console.WriteLine(ZR.CodeExample.Convert.StringToCsv("John,Smith,30\nJane,Doe,25"));
Console.WriteLine("\n");

Console.WriteLine("Converting CSV to String");
Console.WriteLine(ZR.CodeExample.Convert.CsvToString("Lisa,Smith,25\nMike,Doe,47"));

Console.ReadLine();
