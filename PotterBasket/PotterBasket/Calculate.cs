using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterBasket
{
    public static class Calculate
    {
        public static double LowestPrice(Cart cart)
        {
            int numberOfBooks = cart.Books.Count;

            var groupBooksByName = cart.Books.GroupBy(x => x.Name);

            var groupedBooks = new List<List<Book>>();

            foreach (var item in groupBooksByName)
            {
                var list = new List<Book>();
                foreach (var book in item)
                {
                    list.Add(book);
                }
                groupedBooks.Add(list);
            }

            int maxDifferent = 5;

            if (groupBooksByName.Count() == maxDifferent && IsNumberBit(numberOfBooks))
            {
                var countOfSmallestGroup = groupedBooks.OrderByDescending(x => x.Count()).FirstOrDefault().Count();
                var threeGroupsCountSame = groupedBooks.OrderByDescending(x => x.Count()).Take(3).All(x => x.Count() == countOfSmallestGroup);

                if (threeGroupsCountSame)
                {
                    return 51.2 * countOfSmallestGroup / 2;
                }
            }

            while (maxDifferent > 0)
            {
                if (groupedBooks.Count() == maxDifferent)
                {
                    var smallestGroupOfBooks = groupedBooks.Min(x => x.Count());

                    for (int i = 0; i < smallestGroupOfBooks; i++)
                    {
                        double price = 0;

                        if (maxDifferent == 5)
                            price = maxDifferent * 8 * 0.75;
                        if (maxDifferent == 4)
                            price = maxDifferent * 8 * 0.8;
                        if (maxDifferent == 3)
                            price = maxDifferent * 8 * 0.9;
                        if (maxDifferent == 2)
                            price = maxDifferent * 8 * 0.95;
                        if (maxDifferent == 1)
                            price = 8;

                        Set set = new Set(price);
                        cart.Sets.Add(set);

                        foreach (var item in groupedBooks)
                        {
                            item.RemoveAt(0);
                        }
                    }

                    groupedBooks = groupedBooks.Where(x => x.Count() != 0).ToList();
                }
                maxDifferent--;
            }
            return cart.Sets.Sum(x => x.Price);
        }

        public static bool IsNumberBit(int numberOfBooks)
        {
            int num = 1;
            while (num <= numberOfBooks)
            {
                if (num == numberOfBooks)
                {
                    return true;
                }
                num *= 2;
            }
            return false;
        }
    }
}
