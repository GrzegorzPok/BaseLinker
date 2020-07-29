namespace BaseLinker
{
    public class ProductModelToSend
    {
        public string Storage { get; set; }
        public int Storage_Id { get; set; }
        public string Product_Id { get; set; }
        public int Variant_Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Ean { get; set; }
        public string Price_Brutto { get; set; }
        public int Tax_Rate { get; set; }
        public int Quantity { get; set; }
        public decimal Weight { get; set; }
    }
}
