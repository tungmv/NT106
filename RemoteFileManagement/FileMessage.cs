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
        public string filename
        {
            get; set;
        }
        public byte[] data
        {
            get; set;
        }

        //get set
        
    }
}
