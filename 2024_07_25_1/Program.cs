namespace 델리게이트
{
    public class Program
    {
        public class Customer
        {
            public void Request(Restaurant restaurant)
            {
                Console.WriteLine("레스토랑에 예약합니다.");
                restaurant.OnAcceptable = Enter; //레스토랑에서 빈자리가 생기면 Enter을 실행하겠다는 거
            }
            public void Enter(Restaurant restaurant)
            {
                Console.WriteLine("레스토랑에 입장합니다.");
                restaurant.Enter();
            }

        }
        public class Restaurant
        {

            public Action<Restaurant> OnAcceptable; //델리게이트 생성

            private int curCustomer = 5;
            private int maxCustomer = 10;

            public bool IsAccecptable()
            {
                return curCustomer < maxCustomer;
            }
            
            public void CheckCustomerCount()
            {
                if (curCustomer < maxCustomer)
                {
                    OnAcceptable(this); //빈자리가 있으면 빈자리가 있다고 호출함
                    //OnAcceptable을 진행할 때 손님이 들어오게됨
                }
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
            customer.Request(restaurant); //손님이 레스토랑한테 예약을 걸어둠

            restaurant.CheckCustomerCount(); //들어올 수 있는 상황이면 Enter이 실행되는 것임
        }

       
    }
}
