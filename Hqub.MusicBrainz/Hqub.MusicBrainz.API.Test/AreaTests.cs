using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hqub.MusicBrainz.API.Entities;

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
    }
}
