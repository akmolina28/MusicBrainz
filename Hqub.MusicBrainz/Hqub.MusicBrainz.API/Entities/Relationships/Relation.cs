using System.Collections.Generic;
using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities.Relationships
{
    [XmlRoot("relation", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Relation
    {
        /// <summary>
        /// MusicBrainz id of the type of the related entity (artist, area, etc).
        /// </summary>
        [XmlAttribute("type-id")]
        public string TypeId { get; set; }

        /// <summary>
        /// The type of relationship (part of, member of band, etc).
        /// </summary>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        /// The target of the relationship.
        /// </summary>
        [XmlElement("target")]
        public RelationTarget Target { get; set; }

        /// <summary>
        /// Direction of the relationship (forward or backward).
        /// </summary>
        [XmlElement("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// The begin date of the relationship.
        /// </summary>
        [XmlElement("begin")]
        public string Begin { get; set; }

        /// <summary>
        /// The end date of the relationship.
        /// </summary>
        [XmlElement("end")]
        public string End { get; set; }

        /// <summary>
        /// "true" if relationship has ended.
        /// </summary>
        [XmlElement("ended")]
        public string Ended { get; set; }

        /// <summary>
        /// The Artist entity (if this instance is an artist relation).
        /// </summary>
        [XmlElement("artist")]
        public Artist Artist { get; set; }
    }
}
