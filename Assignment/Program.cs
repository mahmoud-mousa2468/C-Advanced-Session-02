namespace Assignment
{
    internal class Program
    {

        public static List<int> GetArrayQueries(int Length)
        {
            List<int> list = new List<int>(Length);
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"Enter Element {i + 1}");
                list.Add(int.Parse(Console.ReadLine()));
            }
            return list;
        }

        #region Q1
        public static void GreaterThanX(List<int> Arr, List<int> Queries)
        {
            int count = 0;
            for (int i = 0; i < Queries.Count; i++)
            {
                for (int j = 0; j < Arr.Count; j++)
                {
                    if (Arr[j] > Queries[i])
                        count++;
                }
                Console.WriteLine($" Numbers Of Elements Grater Than {Queries[i]} is {count}");
                count = 0;
            }
        }
        #endregion

        #region Q2
        public static void PalindromeFun(List<int> list)
        {
            int j = (list.Count - 1);
            bool Palindrome = true;
            for (int i = 0; i < (list.Count) / 2; i++)
            {
                if (list[i] != list[j])
                {
                    Palindrome = false;
                    Console.WriteLine("Not Palindrome");
                    break;
                }
                j--;
            }
            if (Palindrome)
                Console.WriteLine("Palindrome ");
        }
        #endregion

        #region Q3
        public static void GetQueueAndReverseIt(int Length)
        {
            Stack<int> stack = new Stack<int>(Length);
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine($"Enter Element {i + 1}");
                stack.Push(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < Length; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
        #endregion

        #region Q4
        public static void parenthesesFun(string str)
        {
            Stack<char> open = new Stack<char>();
            bool Balanced = true;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '{' || str[i] == '[')
                    open.Push(str[i]);
                else
                {
                    if (str[i] == ')' && open.Peek() == '(' && open.Count > 0)
                        open.Pop();
                    else if (str[i] == '}' && open.Peek() == '{' && open.Count > 0)
                        open.Pop();
                    else if (str[i] == ']' && open.Peek() == '[' && open.Count > 0)
                        open.Pop();
                    else
                    {
                        Console.WriteLine("Not Balanced");
                        Balanced = false;
                        break;
                    }
                }
            }
            if (Balanced)
                Console.WriteLine("Balanced");
        }
        #endregion

        #region Q5
        public static void RemoveDuplicate(List<int> Arr)
        {

            HashSet<int> NewArr = new HashSet<int>(Arr);
            foreach (var item in NewArr)
            {
                Console.Write($"{item} ");
            }
        }
        #endregion

        #region Q6
        public static void RemoveOdd(List<int> Arr)
        {
            for (int i = 0; i < Arr.Count; i++)
            {
                if (Arr[i] % 2 != 0)
                    Arr.RemoveAt(i);
            }
            foreach (var item in Arr)
            {
                Console.Write($"{item} ");
            }
        }
        #endregion

        #region Q7
        public static void QueueDifferentTypes(int Size)
        {
            Queue<int> Q = new Queue<int>(Size);
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"Enter Element {i}");
                Q.Enqueue(int.Parse(Console.ReadLine()));
            }
            foreach (var item in Q)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(Q.GetType());
        }
        #endregion

        #region Q8
        public static void SearchInStack(int Size)
        {
            int c = 0;
            bool NotFound = true;
            Stack<int> S = new Stack<int>(Size);
            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"Enter Element {i}");
                S.Push(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter Target integer");
            int TInt = int.Parse(Console.ReadLine());
            for (int i = 0; i < Size; i++)
            {
                if (S.Pop() != TInt)
                {
                    c++;
                }
                else
                {
                    Console.WriteLine($"Target was found successfully and the count = {c}");
                    NotFound = false;
                }
            }
            if (NotFound)
                Console.WriteLine($"Target was not found");

        }
        #endregion

        #region Q9
        public static void GetIntersection(List<int> Arr1, List<int> Arr2)
        {
            List<int> intersect = new List<int>();
            List<int> Count = new List<int>();
            for (int i = 0; i < Arr1.Count; i++)
            {
                for (int j = 0; j < Arr2.Count; j++)
                {
                    if (Arr1[i] == Arr2[j])
                    {
                        if (intersect.Count == 0)
                        {
                            intersect.Add(Arr1[i]);
                            Count.Add(1);
                        }
                        else
                        {
                            if (intersect.Last() == Arr1[i])
                                Count[Count.Count - 1]++;
                            else if (intersect.Last() != Arr1[i])
                            {
                                intersect.Add(Arr1[i]);
                                Count.Add(1);

                            }
                        }
                        break;
                    }
                }
            }
            Console.Write("[ ");
            for (int i = 0; i < intersect.Count; i++)
            {

                for (int j = 0; j < Count[i]; j++)
                {
                    Console.Write($"{intersect[i]}  ");
                }
            }
            Console.Write("]");
        }
        #endregion

        #region Q10
        public static void ContiguousSub(List<int> Arr, int TSum)
        {
            List<int> ConSub = new List<int>();
            for (int i = 0; i < Arr.Count; i++)
            {

                int j = i;
                ConSub.Clear();
                int Sum = 0;
                while (Sum < TSum && j < Arr.Count)
                {
                    Sum += Arr[j];
                    if (Sum <= TSum)
                        ConSub.Add(Arr[j]);
                    j++;
                }

                if (Sum == TSum)
                    break;
            }
            Console.Write("[ ");
            foreach (var item in ConSub)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("]");
        }
        #endregion

        #region Q11
        public static void ReverseKElement(List<int> Arr, int K)
        {
            int Temp = 0;
            for (int i = 0; i < K / 2; i++)
            {
                Temp = Arr[i];
                Arr[i] = Arr[K - 1];
                Arr[K - 1] = Temp;
            }
            Console.Write("[ ");
            foreach (var item in Arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("]");
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Given an array consists of numbers with size N and number of queries.
            //in each query you will be given an integer X, and you should print
            //how many numbers in array that is greater than  X.


            //Console.WriteLine("Enter Array Size");
            //int ArrLength = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Number Of Queries");
            //int QueLength = int.Parse(Console.ReadLine());
            //List<int> Arr = GetArrayQueries(ArrLength);
            //List<int> Queries = GetArrayQueries(QueLength);

            //GreaterThanX(Arr, Queries);
            #endregion

            #region Q2
            //Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.WriteLine("Enter Array Size");
            //int ArrLength = int.Parse(Console.ReadLine());
            //List<int> Arr = GetArrayQueries(ArrLength);

            //PalindromeFun(Arr);

            #endregion

            #region Q3
            //Given a Queue, implement a function to reverse the elements of a queue
            //using a stack.


            //Console.WriteLine("Enter Queue Size");
            //int QLength = int.Parse(Console.ReadLine());
            //GetQueueAndReverseIt(QLength);
            #endregion

            #region Q4
            //Given a Stack, implement a function to check if a string of parentheses
            //is balanced using a stack.

            //Console.WriteLine("enter ur string of parentheses");
            //string parentheses = Console.ReadLine();
            //parenthesesFun(parentheses);

            #endregion

            #region Q5
            //Given an array, implement a function to remove duplicate elements from an array.


            // solution using hashset store only uniqe element
            //Console.WriteLine("enter ur array size");
            //int Size = int.Parse(Console.ReadLine());
            //List<int> Arr = GetArrayQueries(Size);
            //RemoveDuplicate(Arr);
            #endregion

            #region Q6
            //Given an array list, implement a function to remove all odd numbers from it.


            //Console.WriteLine("Enter Array Size");
            //int Size = int.Parse(Console.ReadLine());
            //List<int> Arr = GetArrayQueries(Size);
            //RemoveOdd(Arr);

            #endregion

            #region Q7
            //Implement a queue that can hold different data types.

            //Console.WriteLine("Enter Size Of Queue");
            //int Size = int.Parse(Console.ReadLine());
            //QueueDifferentTypes(Size);

            #endregion

            #region Q8
            //Create a function that pushes a series of integers onto a stack.
            //Then, search for a target integer in the stack.
            //If the target is found, print a message indicating that the target was found
            //how many elements were checked before finding the target
            //(“Target was found successfully and the count = 5”).
            //If the target is not found, print a message indicating that the target was not found
            //(“Target was not found”).


            //Console.WriteLine("Enter Size Of Stack");
            //int Size = int.Parse(Console.ReadLine());
            //SearchInStack(Size);
            #endregion

            #region Q9
            //Given two arrays, find their intersection.Each element in the result should appear
            //as many times as it shows in both arrays.

            //Console.WriteLine("Enter Size of first Array");
            //int S1 = int.Parse(Console.ReadLine());
            //List<int> Arr1 = GetArrayQueries(S1);
            //Console.WriteLine("Enter Size of Second Array");
            //int S2 = int.Parse(Console.ReadLine());
            //List<int> Arr2 = GetArrayQueries(S2);
            //GetIntersection(Arr1, Arr2);
            #endregion

            #region Q10
            //Given an ArrayList of integers and a target sum, find if there is a contiguous sub list
            //that sums up to the target.

            //Console.WriteLine("Enter Size of ArrayList");
            //int S1 = int.Parse(Console.ReadLine());
            //List<int> Arr = GetArrayQueries(S1);
            //Console.WriteLine("Enter Value Of target sum");
            //int TSum = int.Parse(Console.ReadLine());
            //ContiguousSub(Arr, TSum);


            #endregion

            #region Q11
            //Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order


            //Console.WriteLine("Enter Size of Queue");
            //int S1 = int.Parse(Console.ReadLine());
            //List<int> Arr = GetArrayQueries(S1);
            //Console.WriteLine("Enter Value Of K Element");
            //int K = int.Parse(Console.ReadLine());

            //ReverseKElement(Arr, K);
            #endregion
        }
    }
}
