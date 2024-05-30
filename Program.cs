namespace Challenge4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates a customers bill for an electrical company");
            Console.WriteLine("Input cutomer ID");
            string iD = Console.ReadLine();
            Console.WriteLine("Input Customer Name");
            string name = Console.ReadLine();
            Console.WriteLine("Input usage amount as integer");
            int usage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(iD);
            Console.WriteLine(name);
            calculateCost(usage);
        }

        static void calculateCost(int usage)
        {
            if (usage > 0 && usage <= 200)
            {
                Console.WriteLine($"Units Consumed: {usage}");
                Console.WriteLine($"Amount Charged at $1.20 per unit: ${usage * 1.20}");
                Console.WriteLine($"Net Amount Paid by the Customer: ${usage * 1.20}");
            }
            if (usage > 200 && usage <= 306)
            {
                Console.WriteLine($"Units Consumed: {usage}");
                Console.WriteLine($"Amount Charged at $1.20 per unit: ${200 * 1.20}");
                Console.WriteLine($"Amount Charged at $1.50 per unit: ${(usage -200) * 1.50}");
                Console.WriteLine($"Net Amount Paid by the Customer: ${(200 * 1.20)+ ((usage - 200) * 1.50)}");
            }
            if (usage > 306 && usage <= 400)
            {
                Console.WriteLine($"Units Consumed: {usage}");
                Console.WriteLine($"Amount Charged at $1.20 per unit: ${200 * 1.20}");
                Console.WriteLine($"Amount Charged at $1.50 per unit: ${(usage - 200) * 1.50}");
                Console.WriteLine($"Surcharge Amount: ${((200 * 1.20) + ((usage - 200) * 1.50)) * 0.15}");
                Console.WriteLine($"Net Amount Paid by the Customer: ${((200 * 1.20) + ((usage - 200) * 1.50))*1.15}");
            }
            if (usage > 400 && usage <= 600)
            {
                Console.WriteLine($"Units Consumed: {usage}");
                Console.WriteLine($"Amount Charged at $1.20 per unit: ${200 * 1.20}");
                Console.WriteLine($"Amount Charged at $1.50 per unit: ${200 * 1.50}");
                Console.WriteLine($"Amount Charged at $1.80 per unit: ${(usage - 400) * 1.80}");
                Console.WriteLine($"Surcharge Amount: ${((200 * 1.20) + (200 * 1.5) + ((usage - 400) * 1.80)) * 0.15}");
                Console.WriteLine($"Net Amount Paid by the Customer: ${((200 * 1.20) +(200*1.5)+ ((usage - 400) * 1.80))*1.15}");
            }
            if (usage > 600)
            {
                Console.WriteLine($"Units Consumed: {usage}");
                Console.WriteLine($"Amount Charged at $1.20 per unit: ${200 * 1.20}");
                Console.WriteLine($"Amount Charged at $1.50 per unit: ${200 * 1.50}");
                Console.WriteLine($"Amount Charged at $1.80 per unit: ${ 200 * 1.80}");
                Console.WriteLine($"Amount Charged at $2 per unit: ${(usage - 600) * 2}");
                Console.WriteLine($"Surcharge Amount: ${((200 * 1.20) + (200 * 1.5) + (200*1.8)+((usage - 600) * 2)) * 0.15}");
                Console.WriteLine($"Net Amount Paid by the Customer: ${((200 * 1.20) + (200 * 1.5) + (200*1.8)+((usage - 600) * 2)) * 1.15}");
            }
        }
    }
}
