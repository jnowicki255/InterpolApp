using InterpolApp.Models;
using System.Threading.Tasks;

namespace InterpolApp.Services
{
    public interface IApiClient
    {
        Task<NoticesQuery> GetRedNoticesAsync();
    }
}
