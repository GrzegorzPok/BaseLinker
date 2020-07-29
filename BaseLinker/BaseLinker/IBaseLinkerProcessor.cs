
using BaseLinker.Results;
using System.Threading.Tasks;

namespace BaseLinker
{
    public interface IBaseLinkerProcessor
    {
        Task<OrderResult> LoadOrder(int orderId);
        Task<AddOrderResult> AddOrder(OrderResult orderResult);
    }
}
