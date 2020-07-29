using BaseLinker.Mappers;
using BaseLinker.Results;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BaseLinker
{
    public class BaseLinkerProcessor : IBaseLinkerProcessor
    {
        private const string url = "https://api.baselinker.com/connector.php";

        public async Task<OrderResult> LoadOrder(int orderId)
        {
            var parameters = new Dictionary<string, string> 
            { 
                { "token", ConfigurationManager.AppSettings["token"] } , //change on your own token!
                { "method", "getOrders" } , 
                { "parameters", $"{{ \"order_id\": {orderId},  \"get_unconfirmed_orders\": true}}" }    //example { "date_confirmed_from": 1407341754, "get_unconfirmed_orders": true }
            };
            var encodedContent = new FormUrlEncodedContent(parameters);

            using (var response = await ApiHelper.ApiClient.PostAsync(url, encodedContent).ConfigureAwait(false))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<OrderResult>(json);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<AddOrderResult> AddOrder(OrderResult orderResult)
        {
            var orderToCopy = orderResult.Orders.Single();

            var ordersToSend = OrderMapper.Map(orderToCopy);

            var parameters = new Dictionary<string, string>
            {
                { "token", ConfigurationManager.AppSettings["token"] } , //change on your own token!
                { "method", "addOrder" } ,
                { "parameters", JsonConvert.SerializeObject(ordersToSend).ToLower() } 
            };
            var encodedContent = new FormUrlEncodedContent(parameters); 
            using (var response = await ApiHelper.ApiClient.PostAsync(url, encodedContent).ConfigureAwait(false))
            {
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<AddOrderResult>(json);
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
