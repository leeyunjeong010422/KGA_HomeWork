namespace _2024_08_01_HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] graph =
            {
                { false, false, false, true,  false, false, false, false },
                { false, false, false, true,  false, false, false, false },
                { false, false, false, false, false, false, true,  false },
                { true,  true,  false, false, false, true,  false, false },
                { false, false, false, false, false, false, false, false },
                { false, false, false, true,  false, false, true,  true  },
                { false, false, false, false, false, true,  false, false },
                { false, false, false, false, false, true,  false, false } 
            };
        }
    }
}
