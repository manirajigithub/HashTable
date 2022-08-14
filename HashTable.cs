using Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    /// <summary>
    /// class-
    /// Keys--Holds the Keys,Keys is an array of HashMap Type
    /// tableSize-//define size of keys and calculate hash
    /// </summary>
    public class HashTable
    {
        private MyMapNode[] Keys;
        private readonly int tableSize;

        public HashTable(int maxTableSize)//Constructor
        {
            tableSize = maxTableSize;
            Keys = new MyMapNode[tableSize];
        }
        /// <summary>
        /// Hash Function
        /// </summary>
        /// <param name="Key"></param>
        private int HashFuncation(string key)
        {
            int position = key.GetHashCode() % tableSize; //identifying hash code of key
            return Math.Abs(position);
        }
        
        public void Insert(string key, int value)
        {
            int genIndex = HashFuncation(key);//generates hash index
            MyMapNode node = Keys[genIndex];

            if (node == null)
            {
                Keys[genIndex] = new MyMapNode() { Key = key, Value = value };
                return;
            }
            MyMapNode newNode = new MyMapNode() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }
        /// <summary>
        /// get values by their key
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>value</returns>
        /// <exception cref="Exception">Don't have the key in hash</exception>
        public int GetValue(string key)
        {
            int genIndex = HashFuncation(key);
            MyMapNode node = Keys[genIndex];
            while (node != null)//search the linked list to match the key
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
                node = node.Next;
            }

            throw new Exception("Don't have the key in hash!");
        }
    }
}