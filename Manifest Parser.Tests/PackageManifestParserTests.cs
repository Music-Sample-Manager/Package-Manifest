using NUnit.Framework;
using Manifest_Parser;
using System;

namespace Manifest_Parser.Tests
{
    public class PackageManifestParserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ParseManifest_WithNullManifestPath_ThrowsArgumentNullException()
        {
            var sut = new PackageManifestParser();
            Assert.Throws<ArgumentNullException>(() => sut.ParseManifest(null));
        }

        [Test]
        public void ParseManifest_WithEmptyManifestPath_ThrowsException()
        {
            var sut = new PackageManifestParser();
            Assert.Throws<ArgumentException>(() => sut.ParseManifest(string.Empty));
        }
    }
}