namespace smartCalculator
{
    public struct Calculation
    {
        public double Value1 { get;  }
        public double Value2 { get;  }
        public string Operation { get;  }
        public DateTime TimeStamp { get;  }
        public double Result { get;  }

        public Calculation(double value1,double value2,string op)
        {
            Value1 = value1;
            Value2 = value2;
            TimeStamp = DateTime.Now;
            Operation = op;
            Result = op switch
            {
                "+" => value1 + value2,
                "-" => value1 - value2,
                "*" => value1 * value2,
                "/" when value2 == 0 => throw new DivideByZeroException("can not divide to zero."),
                "/" => value1 / value2,
                _ => throw new ArgumentException($"Unknown operation: {op}")
            };

        }
        public override string ToString()
        {
            return $"{Value1} {Operation} {Value2} = {Result}";
        }
        
    }
    public class CalculatorApp
    {
        public void Run()
        {
            try
            {
                Console.Write("Enter first number: ");
                double v1 = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double v2 = double.Parse(Console.ReadLine());
                Console.Write("Please Select Process: (+,-,*,/)");
                string op = Console.ReadLine();
                var calc = new Calculation(v1, v2, op);
                Console.WriteLine($"Result: {calc.Result}");
                Console.WriteLine($"Time: {calc.TimeStamp}");
            }catch(Exception ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new CalculatorApp();
            app.Run();
        }
    }
}
