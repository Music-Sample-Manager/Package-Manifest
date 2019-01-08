using System.Collections.Generic;

namespace Manifest_Parser
{
    public class PackageManifest
    {
        public List<PackageReference> Packages { get; private set; }

        public PackageManifest(List<PackageReference> packages)
        {
            Packages = packages;
        }
    }
}