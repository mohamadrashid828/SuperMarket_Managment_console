using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r
{
    internal class koga :item
    {

        protected static List<item> items = new List<item>();
        public static List<coustmer> coustemrs = new List<coustmer>();
        public void Inset_item(item a)
        {
            a.price_froshn = a.price_krin + 2;
            items.Add(a);


        }
        public void display_all_item()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("..............................................all item in warehouse................................");
            Console.WriteLine();
            Console.WriteLine($"{"name item",5}      {"barcod",4}     {"adad",4}     {"price_bay",4}        {"price_sell",4}      {"total_price_bay",8}    {"total_encome",8}");
            Console.BackgroundColor = ConsoleColor.Yellow;
            foreach (var item in items)
            {
                Console.WriteLine($"{item.name,8}{item.barcodd,12}   {item.adad,6}   {item.price_krin,8}$    {item.price_froshn,11}$    {item.price_krin * item.adad,15}${(item.price_froshn - item.price_krin) * item.adad,17}$    ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public int get_adad_all_item()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.adad;
            }
            return total;
        }
        public int get_total_price_all()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.price_krin * item.adad;
            }
            return total;
        }
        public int get_total_price_foroshtn()
        {
            int total = 0;
            foreach (var item in items)
            {
                total += item.price_froshn * item.adad;
            }
            return total;
        }
        public double dahaty_aw_kalyanay_la_kogan()
        {

            return get_total_price_foroshtn() - get_total_price_all();
        }
        public int search_item(int barcod)
        {
            int x = items.Count;

            for (int i = 0; i < x; i++)
            {
                if (items.ElementAt(i).barcodd == barcod)
                {
                    return i;
                }
            }

            return -7;
        }
    }
}
