using System.Text;

namespace BaseLinker
{
    public class ProductModel
    {
        public string Shop { get; set; }
        public int Storage_Id { get; set; }
        public string Order_Product_Id { get; set; }
        public string Product_Id { get; set; }
        public int Variant_Id { get; set; }
        public string Name { get; set; }
        public string Attributes { get; set; }
        public string Sku { get; set; }
        public string Ean { get; set; }
        public string Auction_Id { get; set; }
        public string Price_Brutto { get; set; }
        public int Tax_Rate { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Shop: " + Shop + "\n")
                .Append("Storage_Id: " + Storage_Id + "\n")
                .Append("Order_Product_Id: " + Order_Product_Id + "\n")
                .Append("Product_Id: " + Product_Id + "\n")
                .Append("Variant_Id: " + Variant_Id + "\n")
                .Append("Name: " + Name + "\n")
                .Append("Attributes: " + Attributes + "\n")
                .Append("Sku: " + Sku + "\n")
                .Append("Ean: " + Ean + "\n")
                .Append("Auction_Id: " + Auction_Id + "\n")
                .Append("Price_Brutto: " + Price_Brutto + "\n")
                .Append("Tax_Rate: " + Tax_Rate + "\n")
                .Append("Quantity: " + Quantity + "\n")
                .Append("Weight: " + Weight + "\n");
            return result.ToString();
        }
    }
}
