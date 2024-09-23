using System;
namespace DZ5
{
	public class Run
	{
		public void InsertNumber()
		{
            ICalculatable calculatable = new Calculator();
            calculatable.GotResult += Calculatable_GotResult;
            bool r = true;
            while(r)
            {
                Console.WriteLine("Выберите действие: +,-,*,/ \nдля выхода введите пустую строку");
                switch (Console.ReadLine())
                    {
                    case "+":
                        calculatable.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "-":
                        calculatable.Sub(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "*":
                        calculatable.Div(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "/":
                        calculatable.Multy(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case "":
                        r = false;
                        break;
                    default:
                        break;
                    }
                
            }
           
        }

        static void Calculatable_GotResult(object? sender, EventArgs e)
        {
            Console.WriteLine($"{((Calculator)sender).Result}");
        }


    }
}

