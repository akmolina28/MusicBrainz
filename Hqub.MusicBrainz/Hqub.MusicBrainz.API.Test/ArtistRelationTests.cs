using Hqub.MusicBrainz.API.Entities;
using Hqub.MusicBrainz.API.Entities.Relationships;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Hqub.MusicBrainz.API.Test
{
    // Resource: artist-rels-get.xml
    // https://musicbrainz.org/ws/2/artist/e01646f2-2a04-450d-8bf2-0d993082e058?inc=artist-rels+url-rels

    [TestClass]
    public class ArtistRelationTests
    {
        Artist artist;

        public ArtistRelationTests()
        {
            this.artist = TestHelper.Get<Artist>("artist-inc-artist-url-rels-get.xml");
        }

        [TestMethod]
        public void TestArtist()
        {
            Assert.IsNotNull(artist);
        }

        [TestMethod]
        public void TestArtistRelation()
        {
            Assert.IsNotNull(artist.ArtistRelations);
        }

        [TestMethod]
        public void TestUrlRelation()
        {
            Assert.IsNotNull(artist.UrlRelations);
        }

        [TestMethod]
        public void TestArtistRelationListAttributes()
        {
            Assert.AreEqual("artist", artist.ArtistRelations.TargetType);
        }

        [TestMethod]
        public void TestArtistRelationListItems()
        {
            Assert.IsNotNull(artist.ArtistRelations.Items);
            Assert.AreEqual(5, artist.ArtistRelations.Items.Count);

            Relation rel = artist.ArtistRelations.Items[0];
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("5be4c609-9afa-4ea0-910b-12ffb71e3821", rel.TypeId);
            Assert.AreEqual("member of band", rel.Type);
            Assert.AreEqual("37c132f1-6fd2-4d37-8139-b8090cf0b5ba", rel.Target.Value);
            Assert.AreEqual("backward", rel.Direction);
            Assert.AreEqual("1983", rel.Begin);
            Assert.AreEqual("1986", rel.End);
            Assert.AreEqual("true", rel.Ended);
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("Jeff Holdsworth", rel.Artist.Name);
            Assert.AreEqual("Holdsworth, Jeff", rel.Artist.SortName);
            Assert.AreEqual("37c132f1-6fd2-4d37-8139-b8090cf0b5ba", rel.Artist.Id);

            rel = artist.ArtistRelations.Items[1];
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("5be4c609-9afa-4ea0-910b-12ffb71e3821", rel.TypeId);
            Assert.AreEqual("member of band", rel.Type);
            Assert.AreEqual("ba044149-5d13-43f5-b2ac-a3840f26f11c", rel.Target.Value);
            Assert.AreEqual("backward", rel.Direction);
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("Page McConnell", rel.Artist.Name);
            Assert.AreEqual("McConnell, Page", rel.Artist.SortName);
            Assert.AreEqual("ba044149-5d13-43f5-b2ac-a3840f26f11c", rel.Artist.Id);


            rel = artist.ArtistRelations.Items[2];
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("5be4c609-9afa-4ea0-910b-12ffb71e3821", rel.TypeId);
            Assert.AreEqual("member of band", rel.Type);
            Assert.AreEqual("c172276a-fcbf-4477-894a-f37d1582557e", rel.Target.Value);
            Assert.AreEqual("backward", rel.Direction);
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("Mike Gordon", rel.Artist.Name);
            Assert.AreEqual("Gordon, Mike", rel.Artist.SortName);
            Assert.AreEqual("c172276a-fcbf-4477-894a-f37d1582557e", rel.Artist.Id);


            rel = artist.ArtistRelations.Items[3];
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("5be4c609-9afa-4ea0-910b-12ffb71e3821", rel.TypeId);
            Assert.AreEqual("member of band", rel.Type);
            Assert.AreEqual("d942f71b-09d3-406c-8f7d-c52eba3135c1", rel.Target.Value);
            Assert.AreEqual("backward", rel.Direction);
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("Trey Anastasio", rel.Artist.Name);
            Assert.AreEqual("Anastasio, Trey", rel.Artist.SortName);
            Assert.AreEqual("d942f71b-09d3-406c-8f7d-c52eba3135c1", rel.Artist.Id);
            Assert.AreEqual("US jam band Phish lead singer", rel.Artist.Disambiguation);


            rel = artist.ArtistRelations.Items[4];
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("5be4c609-9afa-4ea0-910b-12ffb71e3821", rel.TypeId);
            Assert.AreEqual("member of band", rel.Type);
            Assert.AreEqual("fd1f0177-f5c8-4d13-84c4-b8adea527183", rel.Target.Value);
            Assert.AreEqual("backward", rel.Direction);
            Assert.IsNotNull(rel.Artist);
            Assert.AreEqual("Jon Fishman", rel.Artist.Name);
            Assert.AreEqual("Fishman, Jon", rel.Artist.SortName);
            Assert.AreEqual("fd1f0177-f5c8-4d13-84c4-b8adea527183", rel.Artist.Id);
        }
    }
}
