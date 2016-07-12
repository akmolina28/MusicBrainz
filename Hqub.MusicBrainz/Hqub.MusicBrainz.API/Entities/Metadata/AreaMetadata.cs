using System.Xml.Serialization;
using Hqub.MusicBrainz.API.Entities.Collections;

namespace Hqub.MusicBrainz.API.Entities.Metadata
{
    [XmlRoot("metadata", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class AreaMetadata : MetadataWrapper
    {
        /// <summary>
        /// Gets or sets the area-list collection.
        /// </summary>
        [XmlElement("area-list")]
        public AreaList Collection { get; set; }
    }
}
