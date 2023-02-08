using System;
using System.Collections.Generic;
using System.Linq;

namespace r
{
    internal class Program
    {

        private static void Main()
        {


            koga koga = new koga();
            List<item> items = new List<item> {
            new item{name="brnj",adad=50,barcodd=4521,price_krin=7},
            new item{name="run",adad=10,barcodd=74,price_krin=8},
            new item{name="shir",adad=20,barcodd=78,price_krin=7}
            };


            foreach (var item in items)
            {
                koga.Inset_item(item);
            }

            Console.WriteLine("...........................Super market ......................");
        a:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            display("1-inset item to market ", "", "");
            display("2-sell item ", "", "");
            display("3 - viwe income warehouse ", "", "");
            display("4 - desplay all item in warehouse ", "", "");
            Console.WriteLine();
            Console.Write("select your option : ");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("...........................insert item to market......................");
                    Console.WriteLine();
                    while (true)
                    {
                        Console.Write("if you want to back to home wright H / for  insert I :");
                        if (Console.ReadLine().ToUpper() == "H")
                        {
                            goto a;
                        }
                        item temp = new item();
                        Console.Write("name item:");
                        temp.name = Console.ReadLine();
                    repeat_barcod:
                        try
                        {
                            Console.Write("barcode:");
                            temp.barcodd = int.Parse(Console.ReadLine());
                            if (koga.search_item(temp.barcodd) >= 0)
                            {
                                Console.WriteLine("plese Enter uniq barcod");
                                goto repeat_barcod;
                            }
                            Console.Write("adad:");
                            temp.adad = int.Parse(Console.ReadLine());
                            Console.Write("price sell:");
                            temp.price_krin = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                        }
                        catch (Exception)
                        {
                            goto repeat_barcod;
                        }
                        koga.Inset_item(temp);
                    }
                case "2":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("...........................sell item...............................");
                    Console.WriteLine();
                    Console.Write("if you want to back to home wright H / for  sell( S or Enter ):");
                    if (Console.ReadLine().ToUpper() == "H")
                    {

                        goto a;
                    }
                    Console.Write("Enter name coustmer :");
                    string name_coustmer = Console.ReadLine();
                    Console.Write("Enter phone coustmer :");
                    string phone = Console.ReadLine();
                    coustmer k = new coustmer(name_coustmer, phone);
                    while (true)
                    {
                        Console.Write("if you want to see report write( R ) and for back to home (H) for sell item (Enter):");
                        var input = Console.ReadLine().ToUpper();
                        if (input == "H")
                        {
                            koga.coustemrs.Add(k);
                            goto a;

                        }
                        else if (input == "R")
                        {

                            Display_report(k);
                            continue;
                        }
                        Console.Write("insert barcod : ");
                        int barcod = int.Parse(Console.ReadLine());
                        Console.Write("insert adad : ");
                        int adad = int.Parse(Console.ReadLine());

                        k.sell_item_c(barcod, adad);


                    }

                case "3":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("...........................income warehouse........................");
                    display("total item in warehouse : ", koga.get_adad_all_item().ToString(), "");
                    display("total item all price  withot profit: ", koga.get_total_price_all().ToString(), "$");
                    display("total item all price with  profit : ", koga.get_total_price_foroshtn().ToString(), "$");
                    display("Total income warehouse : ", koga.dahaty_aw_kalyanay_la_kogan().ToString(), "$");

                    Console.Write("if you want to back to home (pop Enter)");
                    Console.ReadLine().ToUpper();

                    goto a;

                case "4":


                    koga.display_all_item();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("if you want to back to home (Enter) ");
                    Console.ReadLine().ToUpper();

                    goto a;
                default:
                    Console.WriteLine("please choose curect option in this list ");
                    goto a;

            }





        }
        static void Display_report(coustmer coustmer)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"name coustmer :{coustmer.name_coustmer,10}         report                        ");
            Console.WriteLine($"phone coustmer :{coustmer.phone_number,10}                  {DateTime.Now} ");

            Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine();
            Console.WriteLine($"         {"name item",5}     {"adad",4}       {"price",4}      {"total",7}           ");

            Console.BackgroundColor = ConsoleColor.Yellow;
            int totoal_price_all_item = 0;
            foreach (var item in coustmer.total_item)
            {
                Console.WriteLine($"       {item.name,8}  {item.total_item_coustmer,8}     {item.price_froshn,7}$    {item.price_froshn * item.total_item_coustmer,8}$            ");
                totoal_price_all_item += item.price_froshn * item.total_item_coustmer;
            }
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"{totoal_price_all_item,50}$            ");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void display(string lable, string input, string symbile)
        {
            Console.WriteLine();
            Console.WriteLine(lable + input + symbile);

        }
       
      


    }
}