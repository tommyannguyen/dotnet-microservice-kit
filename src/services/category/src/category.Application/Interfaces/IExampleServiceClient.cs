using category.Domain.Models;
using System.Threading.Tasks;

namespace category.Application.Interfaces
{
    public interface IExampleServiceClient
    {
        Task<Example> GetExampleById(int id);
    }
}