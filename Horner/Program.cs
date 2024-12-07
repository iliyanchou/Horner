namespace Horner
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Horner method");
            static int degreeIn()
            {
                Console.Write("Insert the highest degree of the polynomial : ");
                int n;
                if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                {
                    Console.WriteLine("Error you have entered an invalid degree");
                    return degreeIn();
                }
                else
                {
                    return n;
                }
            } // gets the degree of the polynomial

            
            Polynomial poly1 = new Polynomial();
            poly1.Degree = degreeIn();
            int n = poly1.Degree;
            for(int i = 0; i<=n; i++)
            {
                Console.Write("Insert {0} coefficient: ", i + 1);
                     double coefIn()
                {
                    double coef;
                    if(!double.TryParse(Console.ReadLine(), out coef)){
                        Console.WriteLine("Error you have enetered an invalid value!");
                        return coefIn();
                    }
                    else
                    {
                        return coef;
                    }
                }
                poly1.coef[i] = coefIn();
                
            } // gets coeficients
            Console.WriteLine("You have entered this polynomial:");
            poly1.display(); // display polynomial
            Console.WriteLine();
            Console.WriteLine("Press any key to continiue....");
            Console.ReadKey();
             void start()
            {
                 static double methodVal()
                {
                    double methodValue;
                    Console.Write("Insert value for the method: ");
                    if(!double.TryParse(Console.ReadLine(), out methodValue))
                    {
                        Console.WriteLine("You have entered an invalid value!");
                        return methodVal();
                    }
                    else
                    {
                        return methodValue;
                    }
                    
                }
                poly1.methodVal = methodVal();
                poly1.horner();
                Console.ReadKey();
                Console.WriteLine("Do you want to try again with same polynomial with another method value or do you wanna reset or close the prgoram?(T/R/C)");
                string check = Console.ReadLine();
                if (check == "T" || check == "t")
                {
                    start();
                }
                if (check == "R" || check == "r")
                {
                    Main();
                }
                    
            }
                start();
            Console.WriteLine("Thank you for using me");
            Console.WriteLine("Press any key to close the program.... bye : ) ");
            Console.ReadKey();

        }
    }
}
