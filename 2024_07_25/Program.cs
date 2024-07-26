namespace _2024_07_25
{
    internal class Program
    {
        public class Customer
        {
            public void Enter(Restaurant restaurant)
            {
                restaurant.Enter();
            }

        }
        public class Restaurant
        {
            private int curCustomer;
            private int maxCustomer;

            public bool IsAccecptable()
            {
                return curCustomer < maxCustomer;
            }

            public void Enter()
            {
                if (IsAccecptable())
                {
                    Console.WriteLine("손님을 입장시킵니다.");
                }
                else
                {
                    Console.WriteLine("손님이 가득차서 기다려야 합니다.");
                }
            }
        }

        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Restaurant restaurant = new Restaurant();

            customer.Enter(restaurant);
        }
    }
}
