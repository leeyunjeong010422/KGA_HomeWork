using System;

namespace HomeWork_0712
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //심화과제 원래 이렇게 코드가 긴 게 맞나요... 아님 그냥 제가 무식하게 코딩한 건가요...

            bool inventoryOk = false;

            while (!inventoryOk)
            {

                Console.Write("원하는 인벤토리의 크기를 입력하세요: ");
                int size;
                int.TryParse(Console.ReadLine(), out size);

                if (size <= 10 && size > 0)
                {
                    int[] inventory = new int[size + 1];
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"{size}개 크기 만큼의 인벤토리가 생성되었습니다.");
                    Console.ResetColor();
                    Console.WriteLine();
                    inventoryOk = true;

                    Console.WriteLine("==================================================");
                    Console.WriteLine($"경고!! \"0\"을 입력하면 프로그램은 종료됩니다.");
                    Console.WriteLine("==================================================");
                    Console.WriteLine();

                    while (true)
                    {
                        Console.Write("열람을 원하는 번호를 입력해주세요: ");
                        int openNumber;
                        int.TryParse(Console.ReadLine(), out openNumber);

                        if (openNumber == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("프로그램을 종료합니다.");
                            Console.ResetColor();
                            break;
                        }

                        if (openNumber > 0 && openNumber <= size)
                        {
                            for (int i = 0; i < size; i++)
                            {
                                if (inventory[openNumber] == 0)
                                {
                                    Console.Write("칸이 비었습니다. 값을 입력하세요: ");
                                    int value;
                                    int.TryParse(Console.ReadLine(), out value);
                                    inventory[openNumber] = value;
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine($"Inventory {openNumber}번째 칸에 {value}의 값이 저장되었습니다.");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.WriteLine($"Inventory {openNumber}번째 칸에 {inventory[openNumber]}의 값이 존재합니다.");
                                    Console.ResetColor();
                                    Console.WriteLine();
                                    //for (i = 0; i < size; i++)
                                    //{
                                    //    Console.WriteLine($"Inventory[{i}] = {inventory[i]}");
                                    //}
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("열람할 수 없습니다. 인벤토리 크기 내의 숫자를 다시 입력해주세요.");
                            Console.ResetColor();
                            Console.WriteLine();
                        }

                    }

                }

                else if (size > 10 || size <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("잘못된 입력입니다.");
                    Console.WriteLine("1~10사이의 숫자를 입력해주세요!!");
                    Console.WriteLine();
                    Console.ResetColor();
                }
            }
        }
    }
}
