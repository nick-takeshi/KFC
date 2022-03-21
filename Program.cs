using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meal.InputMeals();
        }
    }

    public class Meal
    {
        public string name;

        public double price;
        public Meal(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public static void InputMeals()
        {
            

            Meal cola = new Meal("cola", 1.99);
            Meal burger = new Meal("burger", 1.79);
            Meal friedPotato = new Meal("fried potato", 2.19);
            Meal busket = new Meal("busket", 3.99);
            Meal sauce = new Meal("sauce", 0.79);

            Console.WriteLine($"Menu:\n{cola.name} - {cola.price}$\n{burger.name} - {burger.price}$\n{friedPotato.name} - {friedPotato.price}$\n{busket.name} - {busket.price}$\n{sauce.name} - {sauce.price}$");

            Console.WriteLine("Input your meals");

            int i = 0;

            double summ = 0;

            List<string> meals = new List<string>();

            do
            {
                switch (Console.ReadLine())
                {
                    case "cola":
                        summ += cola.price; meals.Add(cola.name);
                        break;

                    case "burger":
                        summ += burger.price; meals.Add(burger.name);
                        break;

                    case "fried potato":
                        summ += friedPotato.price; meals.Add(friedPotato.name);
                        break;

                    case "busket":
                        summ += busket.price; meals.Add(busket.name);
                        break;

                    case "sauce":
                        summ += sauce.price; meals.Add(sauce.name);
                        break;

                    default:
                        i += 1;
                        break;
                }

            } while (i < 1);

            Console.WriteLine($"order cost = {summ}$");

            Console.WriteLine($"Your change - {CalculateChange(summ)}$ \nYour order: ");

            OrderList(meals);
        }

        private static double CalculateChange(double summ)
        {
            Console.WriteLine("Enter your money");

            return Math.Round(Convert.ToDouble(Console.ReadLine()) - summ, 2);
        }

        private static void OrderList(List<string> meals)
        {
            foreach (var c in meals)
            {
                Console.Write(c + ", ");
            }
        }
    }
}
