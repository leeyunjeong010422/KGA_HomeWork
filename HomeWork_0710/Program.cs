using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_0710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ReadLine을 통해 유저로부터 정수를 입력받아 1을 입력받을 경우,
            //"Cocked Pistol" 발령, 2일 경우, "Fast Pace 발령" 3일 경우,
            //"Round House 발령" 이라고 출력. 이외에 대한 입력값은 "비상 태세" 출력하는 기능을 if문으로 제작하고,
            //이와 똑같은 내용으로 switch 문으로 제작하시오.

            //if문
            Console.Write("정수를 입력하세요: ");
            string input = Console.ReadLine();
            int num;
            int.TryParse(input, out num);

            if (num == 1)
            {
                Console.WriteLine("Coked Pistol");
            }
            else if (num == 2)
            {
                Console.WriteLine("Fast pace");
            }
            else if (num == 3)
            {
                Console.WriteLine("Round House");
            }
            else
            {
                Console.WriteLine("비상 태세");
            }

            //switch문

            switch (num)
            {
                case 1:
                    Console.WriteLine("Coked Pistol");
                    break;

                case 2:
                    Console.WriteLine("Fast pace");
                    break;

                case 3:
                    Console.WriteLine("Round House");
                    break;

                default:
                    Console.WriteLine("비상 태세");
                    break;
            }

        }
    }
}
