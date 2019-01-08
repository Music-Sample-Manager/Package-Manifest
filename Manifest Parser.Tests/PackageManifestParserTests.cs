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
        public void ParseManifest_WithEmptyManifestPath_ThrowsArgumentException()
        {
            var sut = new PackageManifestParser();
            Assert.Throws<ArgumentException>(() => sut.ParseManifest(string.Empty));
        }

        [Test]
        public void ParseManifest_WithIncorrectFileExtension_ThrowsArgumentException()
        {
            var sut = new PackageManifestParser();
            Assert.Throws<ArgumentException>(() => sut.ParseManifest(@"C:\Some\Path\Without\File\Extension"));
        }

        [Test]
        public void ParseManifest_WithValidFilePath_ReturnsValidManifestObject()
        {
            var sut = new PackageManifestParser();
            var manifest = sut.ParseManifest(@"Test Documents/basic-example.msm");

            Assert.IsNotNull(manifest);
            Assert.IsNotNull(manifest.Packages);
            Assert.AreEqual(3, manifest.Packages.Count);

            Assert.AreEqual("Some.Package.Name.Here", manifest.Packages[0].Identifier);
            Assert.AreEqual("Another.Package.Name.Here", manifest.Packages[1].Identifier);
            Assert.AreEqual("A.Third.Package", manifest.Packages[2].Identifier);
        }
    }
}