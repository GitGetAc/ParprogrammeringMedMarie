using Parprogrammering;

namespace Parprogrammering
{
    public class Game
    {
        public Bil RacerBil = new(10, 10, 10, 1000);
        public Bil RacerBil2 = new(0, 0, 0, 10000);
        public Bil RacerBil3 = new(0, 0, 0, 10000);

        readonly Random Rnd = new();

        //Drag racing with one car
        public void RacingForOneCar()
        {
            Console.WriteLine("\nDrag racing with one car!\n");
            Console.ReadKey();

            int TotalKjørt;
            int seconds = 0;
            int StartHastighet = RacerBil.Hastighet;


            for (TotalKjørt = StartHastighet; TotalKjørt < RacerBil.TotalAvstand; TotalKjørt += RacerBil.Hastighet)
            {
                seconds++;

                if (TotalKjørt < 500) { RacerBil.Hastighet += RacerBil.ØkHastighetMed; }
                else { RacerBil.Hastighet -= RacerBil.SenkeHastighetMed; }

                Console.WriteLine($"Distance from START after {seconds} second(s): {Convert.ToString(TotalKjørt)}m");

                Console.ReadKey();
            }

            seconds++;
            Console.WriteLine($"You finished in {seconds} seconds on {RacerBil.TotalAvstand} meters\n");

            Console.ReadKey();
        }


        //Drag racing with 2 cars
        public void RacingForTwoCars()
        {
            Console.WriteLine("\nDrag racing with two cars!\n");
            Console.ReadKey();

            int TotalKjørt2 = 0;
            int TotalKjørt3 = 0;
            int seconds = 0;

            while (TotalKjørt2 < RacerBil2.TotalAvstand && TotalKjørt3 < RacerBil3.TotalAvstand)
            {
                seconds++;

                RacerBil2.Hastighet = Rnd.Next(60, 201);
                TotalKjørt2 += RacerBil2.Hastighet;

                RacerBil3.Hastighet = Rnd.Next(60, 201);
                TotalKjørt3 += RacerBil3.Hastighet;

                Console.WriteLine($"Distance from START after {seconds} second(s): Car 1: {TotalKjørt2}m, Car 2: {TotalKjørt3}m");

                Console.ReadKey();
            }

            if (TotalKjørt2 >= RacerBil2.TotalAvstand)
            {
                Console.WriteLine($"Car 1 won in {seconds} seconds on {RacerBil2.TotalAvstand} meters\n");
            }
            else
            {
                Console.WriteLine($"Car 2 won in {seconds} seconds on {RacerBil3.TotalAvstand} meters\n");
            }

            Console.ReadKey();
        }


        public void ProgramStart()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("*******!RacingGame!*******");
            Console.WriteLine("**************************");
            Console.WriteLine("**Press any key to start**");
            Console.ReadKey();
        }

        public void ProgramEnd()
        {
            Console.WriteLine("**************************");
            Console.WriteLine("***!Thanks for playing!***");
            Console.WriteLine("**************************");
            Console.WriteLine("**Press any key to exit.**");
            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
