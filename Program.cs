namespace HashTable
{
    class program
    {
        public static void Main(string[] args)
        {

            HashTable<string, int> hashTable = new HashTable<string, int>(7);
            //Hash Table 
            hashTable.Insert("To", 1);
            Console.WriteLine("To->" + hashTable.GetValue("To"));
            hashTable.Insert("be", 2);
            Console.WriteLine("Be->" + hashTable.GetValue("be"));
            hashTable.Insert("Or", 3);
            Console.WriteLine("Or->" + hashTable.GetValue("Or"));
            hashTable.Insert("not", 4);
            Console.WriteLine("not->" + hashTable.GetValue("not"));
            hashTable.Insert("to", 5);
            Console.WriteLine("to->" + hashTable.GetValue("to"));
            hashTable.Insert("be", 6);
            Console.WriteLine("be->" + hashTable.GetValue("be"));

            Console.WriteLine("Value of key 'not' is: " + hashTable.GetValue("not"));
            Console.ReadLine();
        }
    }
}