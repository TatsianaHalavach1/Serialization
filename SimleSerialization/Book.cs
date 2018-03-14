using System;
using System.Xml.Serialization;

namespace SimleSerialization
{
	[Serializable, XmlType(TypeName = "book")]
	public class Book
	{
		private DateTime publishDate, registrationDate;//Дата записывается в полном формате

		[XmlAttribute("id")]
		public string Id { get; set; }

		[XmlElement("isbn")]
		public string Isbn { get; set; }

		[XmlElement("author")]
		public string Author { get; set; }

		[XmlElement("title")]
		public string Title { get; set; }

		[XmlElement("genre")]
		public GenreType Genre { get; set; }

		[XmlElement("publisher")]
		public string Publisher { get; set; }

		[XmlElement("publish_date")]
		public DateTime PublishDate {
			get
			{
				return publishDate.Date;
			}
			set { publishDate = value; }
		}

		[XmlElement("description")]
		public string Description { get; set; }

		[XmlElement("registration_date")]
		public DateTime RegistrationDate
		{
			get
			{
				return registrationDate.Date;
			}
			set { registrationDate = value; }
		}

		public override string ToString()
		{
			return $"Book: {Title}, by {Author}\n" +
				$"{Genre}. {Description}" +
				$"{PublishDate}, {Publisher}\n";
		}

		public enum GenreType
		{
			[XmlEnum] Computer,
			[XmlEnum] Fantasy,
			[XmlEnum] Romance,
			[XmlEnum] Horror,
			[XmlEnum(Name = "Science Fiction")] ScienceFiction
		}
	}
}
