using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterBasket
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Cart cart = Cart.GetCart();

            Cart cart = new Cart();
            while (true)
            {
                Console.WriteLine("If you want to stop shopping input '1' ");
                var input = Console.ReadLine();
                if (input == "1")
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("which book do you want to buy");
                Console.WriteLine("1. first \n2. second \n3. third \n4. fourth \n5. fifth");
                string bookInput = Console.ReadLine();
                Book book;
                switch (bookInput)
                {
                    case "1":
                        book = new Book("first");
                        break;
                    case "2":
                        book = new Book("second");
                        break;
                    case "3":
                        book = new Book("third");
                        break;
                    case "4":
                        book = new Book("fourth");
                        break;
                    case "5":
                        book = new Book("fifth");
                        break;
                    default:
                        book = new Book("first");
                        break;
                }
                cart.Books.Add(book);
            }
            var result = Calculate.LowestPrice(cart);
            Console.WriteLine($"{result} Euros");
        }
    }
}
