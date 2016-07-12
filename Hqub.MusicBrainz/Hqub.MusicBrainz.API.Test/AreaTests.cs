using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hqub.MusicBrainz.API.Entities;
using Hqub.MusicBrainz.API.Entities.Relationships;

namespace Hqub.MusicBrainz.API.Test
{
    // Resource: area-get.xml
    // https://musicbrainz.org/ws/2/area/f03d09b3-39dc-4083-afd6-159e3f0d462f?inc=url-rels+area-rels

    [TestClass]
    public class AreaTests
    {
        Area area;

        public AreaTests()
        {
            this.area = TestHelper.Get<Area>("area-get.xml");
        }

        [TestMethod]
        public void TestAreaAttributes()
        {
            Assert.IsNotNull(area);
            Assert.AreEqual("f03d09b3-39dc-4083-afd6-159e3f0d462f", area.Id);
            Assert.AreEqual("6fd8f29a-3d0a-32fc-980d-ea697b69da78", area.TypeId);
            Assert.AreEqual("City", area.Type);
        }

        [TestMethod]
        public void TestAreaRelations()
        {
            Assert.IsNotNull(area.AreaRelations);
            Assert.AreEqual(34, area.AreaRelations.Items.Count);
            Assert.AreEqual("area", area.AreaRelations.TargetType);

            Relation rel = area.AreaRelations.Items[0];

            Assert.AreEqual("part of", rel.Type);
            Assert.AreEqual("de7cc874-8b1b-3a05-8272-f3834c968fb7", rel.TypeId);
            Assert.AreEqual("0597b915-cb5c-454e-9d6f-7cfffd69b0f6", rel.Target.Value);

            Assert.IsNotNull(rel.Area, "Area relation is null.");
            Assert.AreEqual("0597b915-cb5c-454e-9d6f-7cfffd69b0f6", rel.Area.Id);
            Assert.AreEqual("Tower Hamlets", rel.Area.Name);
            Assert.AreEqual("Tower Hamlets", rel.Area.SortName);
            Assert.IsNotNull(rel.Area.Iso3166_2CodeList, "Iso code list null.");
            Assert.AreEqual(1, rel.Area.Iso3166_2CodeList.Items.Count);
            Assert.AreEqual("GB-TWH", rel.Area.Iso3166_2CodeList.Items[0].Value);


            rel = area.AreaRelations.Items[1];

            Assert.AreEqual("part of", rel.Type);
            Assert.AreEqual("de7cc874-8b1b-3a05-8272-f3834c968fb7", rel.TypeId);
            Assert.AreEqual("11518382-04c9-473d-98d6-2c0f4b2b9bd9", rel.Target.Value);

            Assert.IsNotNull(rel.Area, "Area relation is null.");
            Assert.AreEqual("11518382-04c9-473d-98d6-2c0f4b2b9bd9", rel.Area.Id);
            Assert.AreEqual("Enfield", rel.Area.Name);
            Assert.AreEqual("Enfield", rel.Area.SortName);
            Assert.IsNotNull(rel.Area.Iso3166_2CodeList, "Iso code list null.");
            Assert.AreEqual(1, rel.Area.Iso3166_2CodeList.Items.Count);
            Assert.AreEqual("GB-ENF", rel.Area.Iso3166_2CodeList.Items[0].Value);


            rel = area.AreaRelations.Items[21];

            Assert.AreEqual("part of", rel.Type);
            Assert.AreEqual("de7cc874-8b1b-3a05-8272-f3834c968fb7", rel.TypeId);
            Assert.AreEqual("9d5dd675-3cf4-4296-9e39-67865ebee758", rel.Target.Value);

            Assert.IsNotNull(rel.Area, "Area relation is null.");
            Assert.AreEqual("9d5dd675-3cf4-4296-9e39-67865ebee758", rel.Area.Id);
            Assert.AreEqual("backward", rel.Direction);
            Assert.AreEqual("England", rel.Area.Name);
            Assert.AreEqual("England", rel.Area.SortName);
            Assert.IsNotNull(rel.Area.Iso3166_2CodeList, "Iso code list null.");
            Assert.AreEqual(1, rel.Area.Iso3166_2CodeList.Items.Count);
            Assert.AreEqual("GB-ENG", rel.Area.Iso3166_2CodeList.Items[0].Value);
        }

        [TestMethod]
        public void TestUrlRelations()
        {
            Assert.IsNotNull(area.UrlRelations);
            Assert.AreEqual(4, area.UrlRelations.Items.Count);
            Assert.AreEqual("url", area.UrlRelations.TargetType);


            Relation rel = area.UrlRelations.Items[0];

            Assert.AreEqual("9228621d-9720-35c3-ad3f-327d789464ec", rel.TypeId);
            Assert.AreEqual("wikipedia", rel.Type);
            Assert.IsNotNull(rel.Target, "Relation target is null.");
            Assert.AreEqual("f115f3aa-7948-482f-861f-1173825c8c2b", rel.Target.Id);
            Assert.AreEqual("http://en.wikipedia.org/wiki/London", rel.Target.Value);


            rel = area.UrlRelations.Items[1];

            Assert.AreEqual("c52f14c0-e9ac-4a8a-8f7a-c47328de168f", rel.TypeId);
            Assert.AreEqual("geonames", rel.Type);
            Assert.IsNotNull(rel.Target, "Relation target is null.");
            Assert.AreEqual("e4122e9f-3e37-4211-ac76-f1ee4a95426b", rel.Target.Id);
            Assert.AreEqual("http://sws.geonames.org/2643743/", rel.Target.Value);


            rel = area.UrlRelations.Items[3];

            Assert.AreEqual("85c5256f-aef1-484f-979a-42007218a1c2", rel.TypeId);
            Assert.AreEqual("wikidata", rel.Type);
            Assert.IsNotNull(rel.Target, "Relation target is null.");
            Assert.AreEqual("0936e6ac-cf60-419b-b1a5-b1ff454f9cb4", rel.Target.Id);
            Assert.AreEqual("https://www.wikidata.org/wiki/Q84", rel.Target.Value);
        }
    }
}
