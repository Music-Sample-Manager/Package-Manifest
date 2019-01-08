using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Manifest_Parser
{
    public class PackageManifestParser
    {
        public PackageManifest ParseManifest(string manifestFilePath)
        {
            if (manifestFilePath == null)
            {
                throw new ArgumentNullException(nameof(manifestFilePath));
            }

            if (manifestFilePath == string.Empty)
            {
                throw new ArgumentException(nameof(manifestFilePath));
            }

            if (Path.GetExtension(manifestFilePath) != ".msm")
            {
                throw new ArgumentException($"Incorrect file extension: {manifestFilePath}");
            }

            XElement manifestXML = XElement.Load(manifestFilePath);

            var packageElements = manifestXML.Descendants().ToList();
            var packages = from package in packageElements
                           select new PackageReference(package.Attribute("Identifier").Value);

            return new PackageManifest(packages.ToList());
        }
    }
}