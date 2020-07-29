using System.Collections.Generic;
using System.Text;

namespace BaseLinker
{
    public class OrderResult
    {
        public string Status { get; set; }
        public List<OrderModel> Orders { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            Orders.ForEach(o =>
            {
                result.Append(o.ToString());
            });
            return result.ToString();
        }
    }
}
