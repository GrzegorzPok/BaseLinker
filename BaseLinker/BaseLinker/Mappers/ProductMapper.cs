using System.Collections.Generic;

namespace BaseLinker.Mappers
{
    public static class ProductMapper
    {
        public static List<ProductModelToSend> MapCollection(List<ProductModel> products)
        {
            var result = new List<ProductModelToSend>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    result.Add(Map(product));
                }
            }
            return result;
        }

        private static ProductModelToSend Map(ProductModel product)
        {
            return new ProductModelToSend()
            {
                Storage = "db",
                Storage_Id = product.Storage_Id,
                Product_Id = product.Product_Id,
                Variant_Id = product.Variant_Id,
                Name = product.Name,
                Sku = product.Sku,
                Ean = product.Ean,
                Price_Brutto = product.Price_Brutto,
                Tax_Rate = product.Tax_Rate,
                Quantity = product.Quantity,
                Weight = product.Weight
            };
        }
    }
}
