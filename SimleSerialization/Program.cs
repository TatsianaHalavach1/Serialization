using System;
using System.IO;
using System.Xml.Serialization;

namespace SimleSerialization
{
	class Program
	{
		static void Main(string[] args)
		{
			//deserialization
			var serializer = new XmlSerializer(typeof(Catalog));
			var catalog = serializer.Deserialize(new FileStream("Books.xml", FileMode.Open)) as Catalog;
			Console.WriteLine(catalog);
			Console.ReadKey();
			//serialization
			var stream = new FileStream("BooksNew.xml", FileMode.Create);
			serializer.Serialize(stream, catalog);
			stream.Close();
		}
	}
}
