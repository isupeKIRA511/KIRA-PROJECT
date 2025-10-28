using System;

class Program
{
    static void Main()
    {
        for (;;)
        {
            Console.WriteLine("\n===== SINTEFIC CALCULATOR =====");
            Console.WriteLine("Enter expression:");

            string exp = Console.ReadLine();
            exp = exp.Replace(" ", ""); 

            double result = 0;

            if (exp.Contains("+"))
            {
                string[] parts = exp.Split('+');
                result = Convert.ToDouble(parts[0]) + Convert.ToDouble(parts[1]);
            }
            else if (exp.Contains("-"))
            {
                string[] parts = exp.Split('-');
                result = Convert.ToDouble(parts[0]) - Convert.ToDouble(parts[1]);
            }
            else if (exp.Contains("*"))
            {
                string[] parts = exp.Split('*');
                result = Convert.ToDouble(parts[0]) * Convert.ToDouble(parts[1]);
            }
            else if (exp.Contains("/"))
            {
                string[] parts = exp.Split('/');
                double b = Convert.ToDouble(parts[1]);
                if (b == 0)
                {
                    Console.WriteLine("Error: Division by zero");
                    continue;
                }
                result = Convert.ToDouble(parts[0]) / b;
            }
            else if (exp.Contains("^"))
            {
                string[] p = exp.Split('^');
                result = Math.Pow(Convert.ToDouble(p[0]), Convert.ToDouble(p[1]));
            }
            else if (exp.Contains("√"))
            {
                string num = exp.Replace("√", "");
                result = Math.Sqrt(Convert.ToDouble(num));
            }
            else if (exp.Contains("²"))
            {
                string num = exp.Replace("²", "");
                double n = Convert.ToDouble(num);
                result = n * n;
            }
            else
            {
                Console.WriteLine("Unknown Operation");
                continue;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
