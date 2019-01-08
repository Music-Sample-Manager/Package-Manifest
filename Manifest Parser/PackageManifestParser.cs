using System;

namespace Manifest_Parser
{
    public class PackageManifestParser
    {
        public void ParseManifest(string manifestFilePath)
        {
            if (manifestFilePath == null)
            {
                throw new ArgumentNullException(nameof(manifestFilePath));
            }

            if (manifestFilePath == string.Empty)
            {
                throw new ArgumentException(nameof(manifestFilePath));
            }
        }
    }
}