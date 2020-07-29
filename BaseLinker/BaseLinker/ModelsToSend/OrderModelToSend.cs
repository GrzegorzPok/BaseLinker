using System.Collections.Generic;

namespace BaseLinker
{
    public class OrderModelToSend
    {

        public int? Order_Status_Id { get; set; }
        public int Date_Add { get; set; }
        public string User_Comments { get; set; }
        public string Admin_Comments { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string User_Login { get; set; }
        public string Currency { get; set; }
        public string Payment_Method { get; set; }
        public string Payment_Method_Cod { get; set; }
        public int Paid { get; set; }
        public string Delivery_Method { get; set; }
        public string Delivery_Price { get; set; }
        public string Delivery_Company { get; set; }
        public string Delivery_Fullname { get; set; }
        public string Delivery_Address { get; set; }
        public string Delivery_City { get; set; }
        public string Delivery_Postcode { get; set; }
        public string Delivery_Country_Code { get; set; }
        public string Delivery_Point_Id { get; set; }
        public string Delivery_Point_Name { get; set; }
        public string Delivery_Point_Address { get; set; }
        public string Delivery_Point_Postcode { get; set; }
        public string Delivery_Point_City { get; set; }
        public string Invoice_Fullname { get; set; }
        public string Invoice_Company { get; set; }
        public string Invoice_Nip { get; set; }
        public string Invoice_Address { get; set; }
        public string Invoice_City { get; set; }
        public string Invoice_Postcode { get; set; }
        public string Invoice_Country_Code { get; set; }
        public string Want_Invoice { get; set; }
        public string Extra_Field_1 { get; set; }
        public string Extra_Field_2 { get; set; }

        public List<ProductModelToSend> Products { get; set; }
    }
}
