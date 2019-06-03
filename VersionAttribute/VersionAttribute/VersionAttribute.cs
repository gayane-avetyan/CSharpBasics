using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    class VersionAttribute : Attribute
    {
        public string Version { get; private set; }
        public VersionAttribute(string version)
        {
            Version = version;
        }
    }
}
