namespace Generic_Maximum_Among_Three
{


    class FindMax<T> where T : IComparable<T>
    {
        private T Value1;
        private T Value2;
        private T Value3;
        public FindMax(T Value1, T Value2, T Value3)
        {
            this.Value1 = Value1;
            this.Value2 = Value2;
            this.Value3 = Value3;
        }
        public T findMaximum()
        {
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0) return Value1;
            if (Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) > 0) return Value2;
            if (Value3.CompareTo(Value1) > 0 && Value3.CompareTo(Value2) > 0) return Value3;
            else throw new Exception("Values are same");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = new FindMax<int>(3, 4, 9).findMaximum();
            Console.WriteLine(max);
            //Console.WriteLine("Welcome to Generic");
            //Maximum<int, int, int> obj1=new Maximum<int, int, int>();
            //obj1.Value1 = 100;
            //obj1.Value2 = 26;
            //obj1.Value3 = 300;
            //obj1.FindMaximum(100,26,300);
        }
    }
}