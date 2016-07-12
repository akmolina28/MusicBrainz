using Hqub.MusicBrainz.API.Entities.Collections;
using Hqub.MusicBrainz.API.Entities.Metadata;
using Hqub.MusicBrainz.API.Entities.Relationships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hqub.MusicBrainz.API.Entities
{
    [XmlRoot("area", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
    public class Area : Entity
    {
        public const string EntityName = "area";

        #region Properties

        /// <summary>
        /// Gets or sets the type of the area (City, County, State, Country, etc).
        /// </summary>
        [XmlAttribute("type", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the MusicBrainz id.
        /// </summary>
        [XmlAttribute("id", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the MusicBrainz type id.
        /// </summary>
        [XmlAttribute("type-id", Namespace = "http://musicbrainz.org/ns/mmd-2.0#")]
        public string TypeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sort name.
        /// </summary>
        [XmlElement("sort-name")]
        public string SortName { get; set; }

        [XmlElement("iso-3166-1-code-list")]
        public Iso3166_1CodeList Iso3166_1CodeList { get; set; }

        [XmlElement("iso-3166-2-code-list")]
        public Iso3166_2CodeList Iso3166_2CodeList { get; set; }

        #endregion

        /// <summary>
        /// Lookup an area in the MusicBrainz database.
        /// </summary>
        /// <param name="id">The artist MusicBrainz id.</param>
        /// <param name="inc">A list of entities to include (subqueries).</param>
        /// <returns></returns>
        public async static Task<Area> GetAsync(string id, params string[] inc)
        {
            return await GetAsync<Area>(EntityName, id, inc);
        }

        /// <summary>
        /// Search for an artist in the MusicBrainz database, matching the given query.
        /// </summary>
        /// <param name="query">The query string.</param>
        /// <param name="limit">The maximum number of artists to return (default = 25).</param>
        /// <param name="offset">The offset to the artists list (enables paging, default = 0).</param>
        /// <returns></returns>
        public async static Task<AreaList> SearchAsync(string query, int limit = 25, int offset = 0)
        {
            return (await SearchAsync<AreaMetadata>(EntityName,
                query, limit, offset)).Collection;
        }
    }

    public class Iso3166_1CodeList
    {
        [XmlElement("iso-3166-1-code")]
        public List<Iso3166_1Code> Items { get; set; }
    }

    public class Iso3166_1Code
    {
        [XmlText]
        public string Value { get; set; }
    }

    public class Iso3166_2CodeList
    {
        [XmlElement("iso-3166-2-code")]
        public List<Iso3166_2Code> Items { get; set; }
    }

    public class Iso3166_2Code
    {
        [XmlText]
        public string Value { get; set; }
    }
}
