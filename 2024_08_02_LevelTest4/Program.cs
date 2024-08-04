namespace _2024_08_02_LevelTest4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Location village = new Location("마을");
            Location guild = new Location("길드");
            Location castle = new Location("성");
            Location store = new Location("상점");
            Location cemetery = new Location("묘지");
            Location forest = new Location("숲");
            Location grassland = new Location("초원");
            Location sea = new Location("바다");

            village.Connect(castle);
            village.Connect(cemetery);

            guild.Connect(store);
            guild.Connect(forest);
            guild.Connect(castle);

            castle.Connect(village);
            castle.Connect(guild);
            castle.Connect(forest);
            castle.Connect(grassland);
            castle.Connect(cemetery);

            store.Connect(guild);
            store.Connect(forest);
            store.Connect(sea);

            cemetery.Connect(village);
            cemetery.Connect(castle);
            cemetery.Connect(grassland);
            cemetery.Connect(sea);

            forest.Connect(store);
            forest.Connect(guild);
            forest.Connect(castle);
            forest.Connect(grassland);

            grassland.Connect(castle);
            grassland.Connect(forest);
            grassland.Connect(sea);
            grassland.Connect(cemetery);

            sea.Connect(store);
            sea.Connect(grassland);
            sea.Connect(cemetery);

            Player player = new Player(village);
            //player.ShowLocation();
            player.InGame();
        }

        public class Player
        {
            Location nowLocation;
            Stack<Location> locationStack;

            public Player(Location firstLocation)
            {
                nowLocation = firstLocation;
                locationStack = new Stack<Location>();
            }

            public void InGame()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("===========맵이동===========");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"현재장소: {nowLocation.Name}");
                    Console.ResetColor();
                    Console.Write($"이동경로: ");                   
                    PrintLocation();
                    
                    if (locationStack.Count > 0)
                    {
                        Console.Write($" > {nowLocation.Name}");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    ShowLocation();
                    Console.ResetColor();

                    Console.WriteLine();
                    Console.Write("이동할 장소를 선택하세요(뒤로가기 0): ");
                    string? input = Console.ReadLine();

                    if (int.TryParse(input, out int number))
                    {
                        if (number == 0 && locationStack.Count > 0)
                        {
                            Console.WriteLine("이전 장소로 이동합니다.");
                            nowLocation = locationStack.Pop();
                        }
                        else if (number > 0 && number <= nowLocation.ConnectedLocations.Count)
                        {
                            locationStack.Push(nowLocation);
                            nowLocation = nowLocation.ConnectedLocations[number - 1];
                        }

                        else
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("이동할 수 없는 번호입니다.");
                            Console.WriteLine("재이동을 원하시면 아무키나 눌러주세요.");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                    }
                }
            }

            public void ShowLocation()
            {
                Console.WriteLine();
                for (int i = 0; i < nowLocation.ConnectedLocations.Count; i++)
                {
                    Console.WriteLine($"{i + 1}번 {nowLocation.ConnectedLocations[i].Name}");
                }
            }

            public void PrintLocation()
            {
                if (locationStack.Count == 0)
                {
                    Console.WriteLine($"{nowLocation.Name}");
                }

                bool first = true;

                foreach (var location in locationStack.Reverse())
                {
                    if (!first) Console.Write(" > ");
                    //Console.Write(" > ");

                    Console.Write(location.Name);                   
                    first = false;
                }

            }
        }


        public class Location
        {
            public string Name { get; set; }
            public List<Location> ConnectedLocations { get; set; }

            public Location(string name)
            {
                Name = name;
                ConnectedLocations = new List<Location>();
            }

            public void Connect(Location location)
            {
                ConnectedLocations.Add(location);
            }

        }



    }
}
