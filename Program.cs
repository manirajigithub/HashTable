namespace HashTableUC2
{
    class program
    {
        public static void Main(string[] args)
        {

            Console.Write("Select Number:\n1)Uc1-To Be Or Not To Be\n" + "2)Uc2-Finding Frequency  in a large Paragraph");
            
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
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
                    break;
                case 2:
                    string Uc2 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

                    string[] LenghtOfParagraph = Uc2.Split(" ");//splits a string into an array of strings

                    int tableSize = LenghtOfParagraph.Length;//used to get the number of characters/string in the current String

                    HashTable<int, string> hashTable1 = new HashTable<int, string>(tableSize);

                    int getIndex = 0;

                    foreach (string words in LenghtOfParagraph)
                    {
                        hashTable1.Insert(getIndex, words);
                        getIndex++;
                    }
                    for (getIndex = 0; getIndex < tableSize; getIndex++)
                    {
                        string word = hashTable1.GetValue(getIndex);
                        Console.WriteLine(word + "---->" + getIndex);

                    }
                    break;
                default:
                    Console.WriteLine("Option is wrong");
                    break;
            }
        }
    }
}
    
