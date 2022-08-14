using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class MyMapNode
    {
        public string Key { get; set; }
        public int Value { get; set; }
        public MyMapNode Next { get; set; }
        public MyMapNode Previous { get; set; }
    }
}