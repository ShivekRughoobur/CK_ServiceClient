using Checkout.ApiServices.SharedModels;
using Checkout.ApiServices.ShoppingList.RequestModels;
using Checkout.ApiServices.ShoppingList.ResponseModels;
using Checkout.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.ApiServices.ShoppingList
{
    public class DrinkService
    {

        public HttpResponse<Uri> CreateDrink(DrinkCreate requestModel)
        {
            return new ApiHttpClient().PostRequest<Uri>(ApiUrls.ShoppingDrinkList, requestModel);
        }

        public HttpResponse<OkResponse> UpdateDrink(DrinkUpdate requestModel)
        {
            var updateDrinkUri = string.Format(ApiUrls.ShoppingDrinkList, requestModel.Name);
            return new ApiHttpClient().PutRequest<OkResponse>(updateDrinkUri, requestModel);
        }

        public HttpResponse<Drink> GetDrink(string drinkName)
        {
            var getDrinkUri = string.Format(ApiUrls.ShoppingDrinkList, drinkName);
            return new ApiHttpClient().GetRequest<Drink>(getDrinkUri);
        }

        public HttpResponse<OkResponse> DeleteDrink(string drinkName)
        {
            var deleteDrinkUri = string.Format(ApiUrls.ShoppingDrinkList, drinkName);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteDrinkUri);
        }

        public HttpResponse<DrinkList> GetDrinkList(int? pageNo)
        {
            var getDrinkListUri = ApiUrls.ShoppingDrinkList;
            
            if (pageNo.HasValue)
            {
                getDrinkListUri = UrlHelper.AddParameterToUrl(getDrinkListUri, "page", pageNo.ToString());
            }
            return new ApiHttpClient().GetRequest<DrinkList>(getDrinkListUri);

        }


   }
}
