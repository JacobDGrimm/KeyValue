using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_ValueStrore
{
    struct KeyValue
    {
        public KeyVaule(string key, object value)
        {
            this.key = key;
            this.value = value;
        }

        public readonly string key;
        public readonly object value;
    }
}
