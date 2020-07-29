using System.Text;

namespace BaseLinker.Results
{
    public class AddOrderResult
    {
        public string Status { get; set; }
        public int Order_Id { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\nstatus: = " + Status)
                .Append("\norder_id: = " + Order_Id + "\n}");
            return sb.ToString();
        }
    }
}
