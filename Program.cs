using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int user = 0;
            int cpu = 0;

            userThrow(user, cpu);
        }
        static string cpuThrow()
        {
            Random r = new Random();
            int genRandom = r.Next(1, 3);
            return $"{genRandom}";
        }

        static void userThrow(int user, int cpu)
        {
            Console.WriteLine($@"Player: {user} | Computer: {cpu}");
            Console.WriteLine(@"What would you like to throw?
            1) Rock
            2) Paper
            3) Scissors");

            string x = Console.ReadLine();
            string y = cpuThrow();

            if (x == "1")
            {
                if (y == "1") { tie(user, cpu); }
                else if (y == "2") { cpuWins(user, cpu); }
                else if (y == "3") { userWins(user, cpu); }
            }
            else if (x == "2")
            {
                if (y == "2") { tie(user, cpu); }
                else if (y == "3") { cpuWins(user, cpu); }
                else if (y == "1") { userWins(user, cpu); }
            }
            else if (x == "3")
            {
                if (y == "3") { tie(user, cpu); }
                else if (y == "1") { cpuWins(user, cpu); }
                else if (y == "2") { userWins(user, cpu); }
            }
        }

        static void tie(int user, int cpu)
        {
            userThrow(user, cpu);
        }

        static void cpuWins(int user, int cpu)
        {
            cpu++;
            if (cpu > 2)
            {
                Console.WriteLine("Computer Wins!");
            }
            else
            {
                userThrow(user, cpu);
            }
        }

        static void userWins(int user, int cpu)
        {
            user++;
            if (user > 2)
            {
                Console.WriteLine("Player Wins!");
            }
            else
            {
                userThrow(user, cpu);
            }
        }
    }
}
