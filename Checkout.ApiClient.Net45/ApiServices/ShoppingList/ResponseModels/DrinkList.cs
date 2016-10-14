using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.ShoppingList.ResponseModels
{
    public class DrinkList
    {
        public string PrevPageUrl { get; set; }
        public string NextPageUrl { get; set; }

        public List<Drink> Data { get; set; }

        public int TotalCount { get; set;  }

        public int TotalPages { get;  set}
    }
}
