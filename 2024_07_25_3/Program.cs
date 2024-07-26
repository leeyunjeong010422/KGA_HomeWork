namespace 델리게이트_지정자 
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int less1 = CountIf(array, 4, Less); //배열에서 4보다 작은 애들은 몇 개 있니?
            int bigger1 = CountIf(array, 3, Bigger); //배열에서 3보다 큰 애 몇 개 있니?
            int equal1 = CountIf(array, 3, Equal); //배열에서 3이랑 같은 애가 몇 개 있니?

            bool bigger = Compare(3, 2, Bigger);
            bool less = Compare(3, 5, Less);
            bool equal = Compare(3, 3, Equal);


        }

        public static bool Bigger(int left, int right)
        {
            return left > right;
        }

        public static bool Less(int left, int right)
        {

            return left < right;
        }

        public static bool Equal(int left, int right)
        {
            return left == right;
        }

        public static int CountIf(int[] array, int value, Func<int, int, bool> comparer)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (comparer(element, value))
                {
                    count++;
                }
            }
            return count;
        }


        //Compare는 comparer에 따라 결과가 달라진다
        public static bool Compare(int left, int right, Func<int, int, bool> comparer)
        {
            return comparer(left, right);
        }
    }

}
