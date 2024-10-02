using System.Linq.Expressions;

namespace BankTreKonton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Investeringskonto isakInvesteringskonto = new Investeringskonto("Isak");
            Sparkonto isakSparkonto = new Sparkonto("Isak Regell");
            Personkonto isakPersonkonto = new Personkonto("Isak Axel Regell");

            bool programIsRuning = true;
            

            while (programIsRuning)
            {
                Console.WriteLine("Välkomen Isak, vilket konto vill du kolla till!");
                Console.WriteLine("Tryck (1) för Investeringskonto");
                Console.WriteLine("Tryck (2) för Sparkonto");
                Console.WriteLine("Tryck (3) för Personkonto");
                bool isRuning = true;
                String val = Console.ReadLine();


                while (isRuning)
                {

                    switch (val)
                    {
                        case "1":
                            Console.WriteLine("Detta är ditt investeringskonto");
                            Console.WriteLine("Tryck (1) för att kolla ditt saldo");
                            Console.WriteLine("Tryck (2) för överföra pengar mellan dina konton");
                            Console.WriteLine("Tryck (3) för att gå till kontomeny");
                            Console.WriteLine("Tryck (4) för att stänga av programet");
                            String investeringskontoVal = Console.ReadLine();

                            if (investeringskontoVal == "1")
                            {
                                Console.WriteLine($"Ditt saldo är {isakInvesteringskonto.checkSaldo()}kr på ditt investeringskonto");
                            }
                            if (investeringskontoVal == "2")
                            {
                                Console.WriteLine("hur mycket pengar vill du föra över");
                                int pengarAttFörraÖver = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Vilken konto vill du förra över pengarna till");
                                string kontoAttFörraÖverPengarnaTill = Console.ReadLine();

                                switch (kontoAttFörraÖverPengarnaTill)
                                {
                                    //hantering av överföring
                                }

                            }
                            if (investeringskontoVal == "3")
                            {
                                
                                isRuning = false;
                            }
                            if (investeringskontoVal == "4")
                            {
                                Console.WriteLine("Du stängde ner programet");
                                programIsRuning = false;
                                isRuning = false;
                            }

                            break;

                        case "2":
                            Console.WriteLine("Detta är ditt Sparkonto");
                            Console.WriteLine("Tryck (1) för att kolla ditt saldo");
                            Console.WriteLine("Tryck (2) för överföra pengar mellan dina konton");
                            Console.WriteLine("Tryck (3) för att gå till kontomeny");
                            Console.WriteLine("Tryck (4) för att stänga av programet");
                            String sparkontoVal = Console.ReadLine();

                            if (sparkontoVal == "1")
                            {
                                Console.WriteLine($"Ditt saldo är {isakSparkonto.checkSaldo()}kr på ditt Sparkonto");
                            }
                            if (sparkontoVal == "2")
                            {
                                Console.WriteLine("Metod saknas för att överförapengar");
                            }
                            if (sparkontoVal == "3")
                            {
                                isRuning = false;
                            }
                            if (sparkontoVal == "4")
                            {
                                Console.WriteLine("Du stängde ner programet");
                                programIsRuning = false;
                                isRuning = false;
                            }


                            break;



                        case "3":
                            Console.WriteLine("Detta är ditt Personkonto");
                            Console.WriteLine("Tryck (1) för att kolla ditt saldo");
                            Console.WriteLine("Tryck (2) för överföra pengar mellan dina konton");
                            Console.WriteLine("Tryck (3) för att gå till kontomeny");
                            Console.WriteLine("Tryck (4) för att stänga av programet");
                            String PersonkontoVal = Console.ReadLine();

                            if (PersonkontoVal == "1")
                            {
                                Console.WriteLine($"Ditt saldo är {isakPersonkonto.checkSaldo()}kr på ditt Personkonto");
                            }
                            if (PersonkontoVal == "2")
                            {
                                Console.WriteLine("Metod saknas för att överförapengar");
                            }
                            if (PersonkontoVal == "3")
                            {
                                isRuning = false;
                            }
                            if (PersonkontoVal == "4")
                            {
                                Console.WriteLine("Du stängde ner programet");
                                programIsRuning = false;
                                isRuning = false;
                            }
                            break;
                    }
                }
            }
            

            



        }


    }
}
