using System.Collections.Generic;
using System.Text;

namespace BaseLinker
{
    public class OrderModel
    {
        public int Order_Id { get; set; }
        public int? Shop_Order_Id { get; set; }
        public int? External_Order_Id { get; set; }
        public string Order_Source { get; set; }
        public int? Order_Source_Id { get; set; }
        public string Order_Source_Info { get; set; }
        public int? Order_Status_Id { get; set; }
        public bool Confirmed { get; set; }
        public int Data_Confirmed { get; set; }
        public int Date_Add { get; set; }
        public int Date_In_Status { get; set; }
        public string User_Login { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string User_Comments { get; set; }
        public string Admin_Comments { get; set; }
        public string Currency { get; set; }
        public string Payment_Method { get; set; }
        public string Payment_Method_Cod { get; set; }
        public string Payment_Done { get; set; }
        public string Delivery_Method { get; set; }
        public string Delivery_Price { get; set; }
        public string Delivery_Package_Module { get; set; }
        public string Delivery_Package_Nr { get; set; }
        public string Delivery_Company { get; set; }
        public string Delivery_Fullname { get; set; }
        public string Delivery_Address { get; set; }
        public string Delivery_City { get; set; }
        public string Delivery_Postcode { get; set; }
        public string Delivery_Country { get; set; }
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
        public string Invoice_Country { get; set; }
        public string Invoice_Country_Code { get; set; }
        public string Want_Invoice { get; set; }
        public string Extra_Field_1 { get; set; }
        public string Extra_Field_2 { get; set; }
        public string Order_Page { get; set; }
        public int Pack_State { get; set; }
        public int Pick_State { get; set; }
        public List<ProductModel> Products { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Order_Id: " + Order_Id + "\n")
                .Append("Shop_Order_Id: " + Shop_Order_Id + "\n")
                .Append("External_Order_Id: " + External_Order_Id + "\n")
                .Append("Order_Source: " + Order_Source + "\n")
                .Append("Order_Source_Id: " + Order_Source_Id + "\n")
                .Append("Order_Source_Info: " + Order_Source_Info + "\n")
                .Append("Order_Status_Id: " + Order_Status_Id + "\n")
                .Append("Confirmed: " + Confirmed + "\n")
                .Append("Data_Confirmed: " + Data_Confirmed + "\n")
                .Append("Date_Add: " + Date_Add + "\n")
                .Append("Date_In_Status: " + Date_In_Status + "\n")
                .Append("User_Login: " + User_Login + "\n")
                .Append("Phone: " + Phone + "\n")
                .Append("Email: " + Email + "\n")
                .Append("User_Comments: " + User_Comments + "\n")
                .Append("Admin_Comments: " + Admin_Comments + "\n")
                .Append("Currency: " + Currency + "\n")
                .Append("Payment_Method: " + Payment_Method + "\n")
                .Append("Payment_Method_Cod: " + Payment_Method_Cod + "\n")
                .Append("Payment_Done: " + Payment_Done + "\n")
                .Append("Delivery_Method: " + Delivery_Method + "\n")
                .Append("Delivery_Price: " + Delivery_Price + "\n")
                .Append("Delivery_Package_Module: " + Delivery_Package_Module + "\n")
                .Append("Delivery_Package_Nr: " + Delivery_Package_Nr + "\n")
                .Append("Delivery_Company: " + Delivery_Company + "\n")
                .Append("Delivery_Fullname: " + Delivery_Fullname + "\n")
                .Append("Delivery_Address: " + Delivery_Address + "\n")
                .Append("Delivery_City: " + Delivery_City + "\n")
                .Append("Delivery_Postcode: " + Delivery_Postcode + "\n")
                .Append("Delivery_Country: " + Delivery_Country + "\n")
                .Append("Delivery_Country_Code: " + Delivery_Country_Code + "\n")
                .Append("Delivery_Point_Id: " + Delivery_Point_Id + "\n")
                .Append("Delivery_Point_Name: " + Delivery_Point_Name + "\n")
                .Append("Delivery_Point_Address: " + Delivery_Point_Address + "\n")
                .Append("Delivery_Point_Postcode: " + Delivery_Point_Postcode + "\n")
                .Append("Delivery_Point_City: " + Delivery_Point_City + "\n")
                .Append("Invoice_Fullname: " + Invoice_Fullname + "\n")
                .Append("Invoice_Company: " + Invoice_Company + "\n")
                .Append("Invoice_Nip: " + Invoice_Nip + "\n")
                .Append("Invoice_Address: " + Invoice_Address + "\n")
                .Append("Invoice_City: " + Invoice_City + "\n")
                .Append("Invoice_Postcode: " + Invoice_Postcode + "\n")
                .Append("Invoice_Country: " + Invoice_Country + "\n")
                .Append("Invoice_Company: " + Invoice_Company + "\n")
                .Append("Invoice_Nip: " + Invoice_Nip + "\n")
                .Append("Invoice_Address: " + Invoice_Address + "\n")
                .Append("Invoice_City: " + Invoice_City + "\n")
                .Append("Invoice_Postcode: " + Invoice_Postcode + "\n")
                .Append("Invoice_Country: " + Invoice_Country + "\n")
                .Append("Invoice_Country_Code: " + Invoice_Country_Code + "\n")
                .Append("Want_Invoice: " + Want_Invoice + "\n")
                .Append("Extra_Field_1: " + Extra_Field_1 + "\n")
                .Append("Extra_Field_2: " + Extra_Field_2 + "\n")
                .Append("Order_Page: " + Order_Page + "\n")
                .Append("Pack_State: " + Pack_State + "\n")
                .Append("Pick_State: " + Pick_State + "\n")
                .Append("Products:\n");

            Products?.ForEach(p =>
            {
                result.Append("Product:\n")
                    .Append(p.ToString());
            });

            return result.ToString();
        }
    }
}
