using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities
{
    [XmlRoot("artist", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Url : Entity
    {
        public const string EntityName = "url";

        /// <summary>
        /// Gets or sets the MusicBrainz id.
        /// </summary>
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("resource")]
        public Resource Resource { get; set; }
    }

    [XmlRoot("resource", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Resource
    {
        [XmlText]
        public string Value { get; set; }
    }
}
