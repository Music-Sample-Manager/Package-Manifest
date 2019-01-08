using System.Collections.Generic;

namespace Manifest_Parser
{
    public class PackageReference
    {
        public string Identifier { get; private set; }

        public PackageReference(string identifier)
        {
            Identifier = identifier;
        }
    }
}