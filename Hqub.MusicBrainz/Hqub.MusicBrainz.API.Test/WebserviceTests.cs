﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hqub.MusicBrainz.API.Test
{
    [TestClass, Ignore]
    public class WebserviceTests
    {
        [TestMethod]
        public async Task TestArtistGetAsync()
        {
            var artist = await Entities.Artist.GetAsync("c3cceeed-3332-4cf0-8c4c-bbde425147b6");

            Assert.IsNotNull(artist, "Artist not found.");

            Assert.AreEqual("scorpions", artist.Name.ToLower(),
                string.Format("Expected 'Scorpions' instead '{0}'.", artist.Name));
        }

        [TestMethod]
        public async Task TestArtistSearchAsync()
        {
            var artists = (await Entities.Artist.SearchAsync("scorpions")).Items;

            Assert.AreNotEqual(0, artists.Count, "Results is Empty.");
        }

        [TestMethod]
        public async Task TestReleaseGetAsync()
        {
            var release = await Entities.Release.GetAsync("ffad013a-4f64-44dd-bfb3-c6360fbd042d");

            Assert.IsNotNull(release, "Release not found.");

            Assert.AreEqual("comeblack", release.Title.ToLower(),
                string.Format("Album title = {0}, expect Comeblack", release.Title));
        }

        [TestMethod]
        public async Task TestReleaseSearchAsync()
        {
            var releases = (await Entities.Release.SearchAsync("Comeblack")).Items;

            Assert.AreNotEqual(0, releases.Count, "Result is empty");
        }

        [TestMethod]
        public async Task TestReleaseBrowseAsync()
        {
            var artists = (await Entities.Artist.SearchAsync("The Scorpions")).Items;

            Assert.AreNotEqual(artists.Count, 0);

            var artist = artists.First();

            var releases = (await Entities.Release.BrowseAsync("artist", artist.Id, 40)).Items;
            Assert.AreEqual(releases.Count, 40);
        }

        [TestMethod]
        public async Task TestRecordingGetAsync()
        {
            var recording = await Entities.Recording.GetAsync("fc4d4d9c-58b7-4dba-a608-753ea752ccce");

            Assert.IsNotNull(recording, "Record not found");

            Assert.AreEqual("the wind of change", recording.Title.ToLower(),
                string.Format("Expect 'The Wind Of Change' instead {0}", recording.Title));
        }

        [TestMethod]
        public async Task TestRecordingSearchAsync()
        {
            var recordings = (await Entities.Recording.SearchAsync("The Wind of Change")).Items;

            Assert.AreNotEqual(0, recordings.Count, "Result is empty");
        }

        [TestMethod]
        public async Task TestRecordingBrowseAsync()
        {
            var artists = (await Entities.Artist.SearchAsync("The Scorpions")).Items;

            Assert.AreNotEqual(artists.Count, 0);

            var artist = artists.First();

            var releases = (await Entities.Recording.BrowseAsync("artist", artist.Id, 40)).Items;
            Assert.AreEqual(releases.Count, 40);
        }

        [TestMethod]
        public async Task TestAreaGetAsync()
        {
            var area = await Entities.Area.GetAsync("83f22bb6-4631-443c-bace-9fae8540362a");

            Assert.IsNotNull(area, "Area not found.");

            Assert.AreEqual("san francisco", area.Name.ToLower(),
                string.Format("Expected 'San Francisco' instead '{0}'.", area.Name));
        }

        [TestMethod]
        public async Task TestAreaSearchAsync()
        {
            var area = (await Entities.Area.SearchAsync("San Francisco")).Items;

            Assert.AreNotEqual(0, area.Count, "Results is Empty.");
        }
    }
}
