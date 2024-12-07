using System;
using System.Security.Cryptography;

public class Polynomial
{
    private int degree;
    private double[] Coef;
    public int Degree
    {
        get => degree;
        set
        {
            degree = value;
            Coef = new double[degree + 1];
        }
    }
    public double[] coef => Coef;
    public void display()
    {
        for (int i = 0, j = Degree; i < Degree; i++, j--)
        {
            if (i != Degree - 1)
            {
                if (coef[i] < 0)
                {
                    if (coef[i] == -1)
                    {
                        Console.Write("-x^{0}", j);
                    }
                    else
                    {
                        Console.Write("-{0}x^{1}", Math.Abs(coef[i]), j);
                    }

                }
                else if (coef[i] == 0)
                {
                    continue;
                }
                else
                {
                    if (i == 0 && coef[i] == 1)
                    {
                        Console.Write("x^{0}",j);
                    }
                    else if (i == 0)
                    {
                        Console.Write("{0}x^{1}", coef[i], j);
                    }
                    else
                    {
                        Console.Write("+{0}x^{1}", coef[i], j);
                    }
                }
            }
            else if (i == Degree - 1)
            {
                if (coef[i] < 0)
                {
                    if (coef[i] == -1)
                    {
                        Console.Write("-x");
                    }
                    else
                    {
                        Console.Write("-{0}x", Math.Abs(coef[i]));
                    }

                }
                else if (coef[i] == 0)
                {
                    continue;
                }
                else
                {
                    if (i == 0 && coef[i] == 1)
                    {
                        Console.Write("x");
                    }
                    else if (i == 0)
                    {
                        Console.Write("{0}x", coef[i]);
                    }
                    else
                    {
                        Console.Write("+{0}x", coef[i]);
                    }
                }
            }

        }
        if (coef[coef.Length - 1]!= 0) {
            if(coef[coef.Length-1] > 0)
            Console.Write("+{0}",Coef[coef.Length - 1]);
            else
            {
              Console.Write("{0}", Coef[coef.Length - 1]);
            }
        }
    }

    public double methodVal;
    public void horner()
    {
        double[] hornerCoef = new double[coef.Length];
        hornerCoef[0] = coef[0];
        for (int i = 0, j = 1 ; i < hornerCoef.Length-1 && j<hornerCoef.Length; i++, j++)
        {
            hornerCoef[j] = hornerCoef[j-1] * methodVal + coef[i + 1];
        }
        if (hornerCoef[hornerCoef.Length-1] == 0)
        {
            Console.Write("{0} is a root to the equation: ",methodVal);
            display();
            Console.Write(" and the quotient is : ");
            quotienPoly quot = new quotienPoly();
            quot.Degree = Degree - 1;
            for(int i = 0; i<=quot.Degree; i++)
            {
                quot.coef[i] = hornerCoef[i];
            }
            quot.display();
        }
        else
        {
            Console.Write("{0} is not a root to the equation: ", methodVal);
                display();
            Console.Write(" however the coefficients of the method are: ");
        foreach(double element in hornerCoef)
        {
            Console.Write("{0} ",element);
        }
        }
    }

}
