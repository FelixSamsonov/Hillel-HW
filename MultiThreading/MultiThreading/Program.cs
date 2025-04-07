namespace MultiThreading
{
    internal class Program
    {
        static Semaphore waitingRoom = new Semaphore(3, 3);
        static Semaphore barberRoom = new Semaphore(1, 1);
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Customer customer = new Customer(i);
            }
        }
        class Customer
        {
            Thread customerThread;

            public Customer(int i)
            {
                customerThread = new Thread(BarberWork);
                customerThread.Name = $"Customer {i}";
                customerThread.Start();
            }
            void BarberWork()
            {
                if (waitingRoom.WaitOne())
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} entered the waiting room");
                    barberRoom.WaitOne();
                    waitingRoom.Release();
                    Console.WriteLine($"{Thread.CurrentThread.Name} entered in barber room");
                    Thread.Sleep(500);
                    Console.WriteLine($"{Thread.CurrentThread.Name} is getting a haircut");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{Thread.CurrentThread.Name} left the barber room");
                    Thread.Sleep(500);
                    barberRoom.Release();
                }
            }
        }

    }
}
