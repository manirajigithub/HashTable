using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class HashMap<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
        public HashMap<K, V> Next { get; set; }
        public HashMap<K, V> Previous { get; set; }
    }
}