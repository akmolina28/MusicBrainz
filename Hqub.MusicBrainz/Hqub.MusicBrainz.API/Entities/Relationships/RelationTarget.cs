using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities.Relationships
{

    [XmlRoot("target", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class RelationTarget
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
