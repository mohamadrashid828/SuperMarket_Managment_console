using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r
{
    class coustmer : koga
    {
        public string name_coustmer { get; set; }
        public string phone_number { get; set; }
        public List<item> total_item = new List<item>();

        public coustmer(string name = "", string phone_number = "")
        {
            this.phone_number = phone_number;
            this.name_coustmer = name;
        }
        public void sell_item_c(int bacod, int adad)
        {

            int single_item = search_item(bacod);
            if (single_item < 0)
            {
                Console.WriteLine("am kalaya la koga namwa");
            }
            else
            {
                if (items.ElementAt(single_item).adad - adad <= 0)
                {
                    Console.WriteLine("this item is unvilable");
                }
                else
                {
                    if (items.ElementAt(single_item).total_item_coustmer == 0)
                    {
                        var i = items.ElementAt(single_item);
                        i.total_item_coustmer = adad;
                        total_item.Add(i);
                    }
                    else
                    {
                        items.ElementAt(single_item).total_item_coustmer += adad;
                    }
                    item temp = items.ElementAt(single_item);

                    temp.adad -= adad;


                }


            }

        }


    }
}
