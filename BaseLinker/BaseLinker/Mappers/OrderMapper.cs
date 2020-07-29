namespace BaseLinker.Mappers
{
    public static class OrderMapper
    {
        public static OrderModelToSend Map(OrderModel orderModel)
        {
            return new OrderModelToSend()
            {
                Order_Status_Id = orderModel.Order_Status_Id,
                Date_Add = orderModel.Date_Add,
                User_Comments = orderModel.User_Comments,
                Admin_Comments = orderModel.Admin_Comments,
                Phone = orderModel.Phone,
                Email = orderModel.Email,
                User_Login = orderModel.User_Login,
                Currency = orderModel.Currency,
                Payment_Method = orderModel.Payment_Method,
                Payment_Method_Cod = orderModel.Payment_Method_Cod,
                Paid = 1,
                Delivery_Method = orderModel.Delivery_Method,
                Delivery_Price = orderModel.Delivery_Price,
                Delivery_Company = orderModel.Delivery_Company,
                Delivery_Fullname = orderModel.Delivery_Fullname,
                Delivery_Address = orderModel.Delivery_Address,
                Delivery_City = orderModel.Delivery_City,
                Delivery_Postcode = orderModel.Delivery_Postcode,
                Delivery_Country_Code = orderModel.Delivery_Country_Code,
                Delivery_Point_Id = orderModel.Delivery_Point_Id,
                Delivery_Point_Name = orderModel.Delivery_Point_Name,
                Delivery_Point_Address = orderModel.Delivery_Point_Address,
                Delivery_Point_Postcode = orderModel.Delivery_Point_Postcode,
                Delivery_Point_City = orderModel.Delivery_Point_City,
                Invoice_Fullname = orderModel.Invoice_Fullname,
                Invoice_Company = orderModel.Invoice_Company,
                Invoice_Nip = orderModel.Invoice_Nip,
                Invoice_Address = orderModel.Invoice_Address,
                Invoice_City = orderModel.Invoice_City,
                Invoice_Postcode = orderModel.Invoice_Postcode,
                Invoice_Country_Code = orderModel.Invoice_Country_Code,
                Want_Invoice = orderModel.Want_Invoice,
                Extra_Field_1 = orderModel.Extra_Field_1,
                Extra_Field_2 = orderModel.Extra_Field_2,

                Products = ProductMapper.MapCollection(orderModel.Products)
            };
        }
    }
}
