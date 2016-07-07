using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities.Relationships
{

    [XmlRoot("relation", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class ArtistRelation : Relation
    {
        /// <summary>
        /// The entity (if this instance is an artist relation).
        /// </summary>
        [XmlElement("artist")]
        public Artist Artist { get; set; }
    }
}
