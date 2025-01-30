using System.Collections;

namespace section_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region What is Collections
            // Collection : Built-in DS in C#
            // Array: Container

            // Collections in C#
            // Lists
            // HashTables

            // Generic - non-Generic
            // lists:
            // Non-Generic Lists: ArrayList -Stack-Queue
            // Generic Lists : List,Stack,Queue,LinkedList

            // HashTables:
            // Non-Generics HashTables : HashTable
            // Generics HashTable : Dictionary -SortedDictionary 
            #endregion

            #region Non-Generic Arraylist
            // lists 
            // Non-Generic list : Arraylist
            // ArrayList Like Array
            // Array Based
            // Index
            // Array Indexed Collection : Fixed Size
            // ArrayList Indexed Collection : Dynamic Size
            // it's default capacity is 4 and any expand will multible it by 2
            // Index: 0 1 2 3 4 5
            // items: 4 5 6 7 8 1
            // Size : 6

            // Arr[1]----> 5
            //int[] Numbers = { 9, 8, 7, 6, 1, 2, 3, 4, 5 };
            //Console.WriteLine(Numbers[1]);
            //Numbers[1] = 12;
            //Console.WriteLine(Numbers[1]);

            //ArrayList list = new ArrayList();
            //ArrayList list = new ArrayList(new int[] { 9, 8, 7, 6, 1, 2, 3, 4, 5 });
            ////ArrayList list = new ArrayList(5);
            //Console.WriteLine($"Count : {list.Count} :: Capacity: {list.Capacity}");
            //list.Add(10);
            //int index = list.BinarySearch(9);

            //Console.WriteLine($"Count : {list.Count} :: Capacity: {list.Capacity}");
            //Console.WriteLine(list.IsFixedSize); // return false
            //Console.WriteLine(list.IsReadOnly);  // return false

            //list.Clear();// clear the list
            //bool Flag = list.Contains(20);
            //Console.WriteLine(Flag);


            //int[] Arr = new int[4];

            //list.CopyTo(Arr);
            //list.CopyTo(2,Arr,1,1);

            //list.GetRange(1, 2);

            //int i = list.IndexOf(10);
            //Console.WriteLine(i);
            //list.Remove(5);

            //list.Sort();// sort the list

            #endregion
        }
    }
}
