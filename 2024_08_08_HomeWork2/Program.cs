namespace _2024_08_08_HomeWork2
{
    public class Program
    {
        static void Main(string[] args)
        {
            AnimalBuilder puppy1 = new AnimalBuilder();
            puppy1.SetName("유자")
                .SetType("말티즈")
                .SetAge(2)
                .SetWeight(4.5);

            AnimalBuilder puppy2 = new AnimalBuilder();
            puppy2.SetName("통이")
                .SetType("시츄")
                .SetAge(13)
                .SetWeight(5.7);

            AnimalBuilder puppy3 = new AnimalBuilder();
            puppy3.SetName("츄츄")
                .SetType("토이푸들")
                .SetAge(1)
                .SetWeight(2.3);


            Animal[] animals = new Animal[10];
            animals[0] = puppy1.Build();
            animals[1] = puppy2.Build();
            animals[2] = puppy3.Build();

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"종류: {animals[i].type}");
                Console.WriteLine($"이름: {animals[i].name}");
                Console.WriteLine($"나이: {animals[i].age}살");
                Console.WriteLine($"몸무게: {animals[i].weight}kg");
                Console.WriteLine();
            }

        }


    }
}
