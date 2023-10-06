using System.ComponentModel.Design;

namespace EnergiSpelProgram
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur mycket energi vill du börja med? ");
            String Energy = Console.ReadLine();
            int runnerEnergy = Int32.Parse(Energy);
            float originaldistance = 10;
            float runnerdistance = 0;
            Console.WriteLine("Distance remaining: " + originaldistance + " km" + "  Energy remaining: " + runnerEnergy);
            Console.WriteLine();
            Console.WriteLine();
            while ((originaldistance > 0) & (runnerEnergy > 1))
            {
                Console.WriteLine("Ange hastighet (snabbast, snabb, mÃ¥ttlig, lÃ¥ngsam, promenad): ");
                string speedlevel = Console.ReadLine();
                int energyCost;
                float distanceCovered;
                switch (speedlevel)
                {
                    case "snabbast":
                        if (runnerEnergy < 15)
                        {
                            Console.WriteLine("Du har inte sÃ¥ mycket energi, ange annat val");
                            Console.WriteLine();
                            continue;
                        }
                        energyCost = 15;
                        distanceCovered = 2;
                        break;

                    case "snabb":
                        if (runnerEnergy < 10)
                        {
                            Console.WriteLine("Du har inte sÃ¥ mycket energi, ange annat val");
                            Console.WriteLine();
                            continue;
                        }
                        energyCost = 10;
                        distanceCovered = 1;
                        break;

                    case "mÃ¥ttlig":
                        if (runnerEnergy < 8)
                        {
                            Console.WriteLine("Du har inte sÃ¥ mycket energi, ange annat val");
                            Console.WriteLine();
                            continue;
                        }
                        energyCost = 8;
                        distanceCovered = 1;
                        break;

                    case "lÃ¥ngsam":
                        if (runnerEnergy < 5)
                        {
                            Console.WriteLine("Du har inte sÃ¥ mycket energi, ange annat val");
                            Console.WriteLine();
                            continue;
                        }
                        energyCost = 5;
                        distanceCovered = 1;
                        break;

                    case "promenad":
                        if (runnerEnergy < 2)
                        {
                            Console.WriteLine("Du har inte sÃ¥ mycket energi, ange annat val");
                            Console.WriteLine();
                            continue;
                        }
                        energyCost = 2;
                        distanceCovered = 1;
                        break;

                    default:
                        Console.WriteLine("Ogiltig hastighetsnivÃ¥.");
                        Console.WriteLine();
                        continue;
                }
                runnerEnergy = runnerEnergy - energyCost;
                runnerdistance = runnerdistance + distanceCovered;
                originaldistance = originaldistance - distanceCovered;
                // Console.WriteLine("HastighetsnivÃ¥: " + speedlevel);
                // Console.WriteLine("Energy Cost: " + energyCost + " energy");
                // Console.WriteLine("Distance Covered: " + distanceCovered + " km");
                Console.WriteLine("Distance covered: " + runnerdistance + " km" + " Energy remaining: " + runnerEnergy);
                Console.WriteLine();

            }
            if (originaldistance == 0)
            {
                Console.WriteLine("Du klarade spelet bra jobbat!");
            }
            else
                Console.WriteLine("Energin rÃ¤ckte inte fÃ¶r att klara en till omgÃ¥ng");
        }

    }
}
