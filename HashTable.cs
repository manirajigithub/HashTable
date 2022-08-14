using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    
    public class HashTable<K, V>
    {
        private MyMapNode<K, V>[] Keys;
        private readonly int tableSize;

        public HashTable(int maxTableSize)//Constructor
        {
            tableSize = maxTableSize;
            Keys = new MyMapNode<K, V>[tableSize];
        }
        
        private int HashFuncation(K key)
        {
            int position = key.GetHashCode() % tableSize; //identifying hash code of key
            return Math.Abs(position);
        }
        /// <summary>
        /// Insert value with key to table
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param> 
        public void Insert(K key, V value)
        {
            int genIndex = HashFuncation(key);//generates hash index
            MyMapNode<K, V> node = Keys[genIndex];

            if (node == null)
            {
                Keys[genIndex] = new MyMapNode<K, V>() { Key = key, Value = value };
                return;
            }
            MyMapNode<K, V> newNode = new MyMapNode<K, V>() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }
               public V GetValue(K key)
        {
            int genIndex = HashFuncation(key);
            MyMapNode<K, V> node = Keys[genIndex];
            while (node != null)//search the linked list to match the key
            {
                if (node.Key.Equals(key))
                {
                    return node.Value;
                }
                node = node.Next;
            }

            throw new Exception("Don't have the key in hash!");
        }
    }
}
