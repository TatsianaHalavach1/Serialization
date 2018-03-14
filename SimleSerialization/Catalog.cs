using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimleSerialization
{
	[Serializable, XmlRoot("catalog", Namespace = "http://library.by/catalog")]
	//при сериализации добавляются доп.атрибуты xmlns!!! И убирается кодировка
	public class Catalog
	{
		private DateTime date;

		[XmlElement ("book")]
		public List<Book> Books { get; set; }

		[XmlAttribute("date")]
		public DateTime Date
		{
			get
			{
				return date.Date;
			}
			set { date = value; }
		}

		public Catalog()
		{
			Books = new List<Book>();
		}

		public override string ToString()
		{
			return Books.ExtensionToString();
		}
	}
}
