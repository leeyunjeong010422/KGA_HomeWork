﻿namespace DelegateNEvent_예시
{
    public class Program
    {
        public static void Main()
        {
            InputDevice device = new InputDevice();
            Player player = new Player();

            device.aKey = player.Jump;

            device.Input('a');

            device.aKey = player.Skill;

            device.Input('a');
        }

        public class InputDevice
        {
            public Action aKey;
            public Action sKey;

            public void Input(char key)
            {
                switch (key)
                {
                    case 'a':
                        aKey();
                        break;
                    case 's':
                        sKey();
                        break;
                }
            }
        }

        public class Player
        {
            public void Jump()
            {
                Console.WriteLine("플레이어 점프");
            }
            public void Skill()
            {
                Console.WriteLine("플레이어 스킬");
            }
        }
    }
}
