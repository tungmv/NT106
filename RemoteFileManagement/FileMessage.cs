using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteFileManagement
{
    [Serializable]
    internal class FileMessage
    {
        private string filename;
        private byte[] data;
    }
}
