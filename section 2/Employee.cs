namespace section_2
{
    internal class Employee : IComparable
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is Employee E)
            {
                return this.Age.CompareTo(E.Age);
            }
            return -1;
        }

        public override string ToString()
        {
            return $"Id {Id} : Name: {Name} : Age : {Age}";
        }
    }
}
