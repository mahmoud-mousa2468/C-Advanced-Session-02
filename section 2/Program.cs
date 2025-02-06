using System.Collections;

namespace section_2
{
    internal class Program
    {
        public static void PrintList<T>(List<T> list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public static int SumList(List<int> list)
        {
            int Sum = 0;
            if(list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Sum += list[i];
                }
            }
            return Sum;
        }
        public static void PrintLinkedList<T>(LinkedList<T> ts)
        {
            Console.WriteLine("null");
            foreach (var item in ts)
            {
                Console.Write($"->{item}->");
            }
            Console.WriteLine("null");

        }
        public static void PrintStack(Stack<int> ints)
        {
            Console.WriteLine();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
        }
        public static void PrintQueue(Queue<int> ints)
        {
            Console.WriteLine();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
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

            #region Non-Generic Lists : Arraylist
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

            #region Generic Lists :List
            // array based
            //List<int> list = new List<int> { 1, 2, 3, 4 };
            //PrintList<int>(list);
            ////list.Add("hello world"); // complier
            //int Sum = SumList(list);
            //Console.WriteLine(Sum);

            //list.AddRange(new List<int> { 10, 11, 12, 13 });
            ////list.AsReadOnly();

            //list.BinarySearch(2);

            //Employee E01 = new Employee() { Age = 20, Id = 10, Name = "Ahmed" };
            //Employee E02 = new Employee() { Age = 30, Id = 11, Name = "Ali" };
            //Employee E03 = new Employee() { Age = 40, Id = 12, Name = "Adam" };
            //List<Employee> employees = new List<Employee> { E01, E02, E03 };
            //Console.WriteLine(employees.BinarySearch(E03));

            //Console.WriteLine($"Count : {list.Count} :: Capacity : {list.Capacity}");
            //list.EnsureCapacity(10);
            //Console.WriteLine($"Count : {list.Count} :: Capacity : {list.Capacity}");
            //List<int> result = list.GetRange(0, 2);
            //PrintList(result);
            //list.Sort();
            //Console.WriteLine($"Count : {list.Count} :: Capacity : {list.Capacity}");
            //list.TrimExcess();
            //Console.WriteLine($"Count : {list.Count} :: Capacity : {list.Capacity}");

            #endregion

            #region Generic Lists : LinkedList
            // node based
            // prev value next
            // double linked list
            // single linked list dosen't exist in c#
            //LinkedList<int> ints = new LinkedList<int>();
            //ints.AddFirst(1);
            //ints.AddFirst(2);
            //ints.AddLast(3);
            //ints.AddLast(4);

            //LinkedListNode<int> node = new LinkedListNode<int>(2);
            //ints.AddLast(node);

            //ints.AddAfter(node, 4);
            //LinkedListNode<int> result = ints.Find(1);
            //PrintLinkedList<int>(ints);

            //Console.WriteLine(ints.First.Value);
            //Console.WriteLine(ints.Last.Value);

            //ints.Clear();

            //Console.WriteLine(ints.First.Next.Value);

            //ints.Remove(2);
            //ints.RemoveLast();

            #endregion

            #region Generic Lists : Stack
            //LIFO  last input first output
            // array based
            //Stack<int> S = new Stack<int>();
            //S.Push(1);
            //S.Push(2);
            //S.Push(3);
            //S.Push(4);

            ////int Top = S.Peek();
            ////Console.WriteLine(Top);

            //bool Flag = S.TryPeek(out int Top);
            //Console.WriteLine(Top);

            //PrintStack(S);
            #endregion

            #region Generic Lists : Queue
            //Queue<int> Q = new Queue<int>();
            //Q.Enqueue(1);
            //Q.Enqueue(2);
            //Q.Enqueue(3);
            //Q.Enqueue(4);
            //Q.Dequeue();
            //Q.Peek();
            //PrintQueue(Q);
            

            #endregion
        }
    }
}
