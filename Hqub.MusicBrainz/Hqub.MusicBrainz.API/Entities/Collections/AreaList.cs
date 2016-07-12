using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities.Collections
{
    [XmlRoot("area-list", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class AreaList : BaseList
    {
        /// <summary>
        /// Gets or sets the list of areas.
        /// </summary>
        [XmlElement("area")]
        public List<Area> Items { get; set; }
    }
}
