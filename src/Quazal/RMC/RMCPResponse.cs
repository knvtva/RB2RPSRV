using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quazal
{
    public abstract class RMCPResponse
    {
        public abstract byte[] ToBuffer();
    }
}
