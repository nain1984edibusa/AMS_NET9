using Microservices.Demo.Reports.Service.Application.Dtos;

namespace Microservices.Demo.Reports.Service.Application.Interfaces
{
    public interface IPolicyClient
    {
        Task<List<PolicyDto>> GetPoliciesAsync();
    }
}
