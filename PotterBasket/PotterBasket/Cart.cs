using System;
using System.Collections.Generic;
using System.Text;

namespace PotterBasket
{
    public class Cart
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Set> Sets { get; set; } = new List<Set>();
        public double Price { get; set; }

        public static Cart GetCart()
        {
            Cart cart = new Cart();

            cart.Books = new List<Book>()
            {
                new Book("first"),
                new Book("first"),
                new Book("second"),
                new Book("second"),
                new Book("third"),
                new Book("third"),
                new Book("third"),
                new Book("third"),
                new Book("fourth"),
                new Book("fifth"),
            };
            return cart;
        }
    }
}
