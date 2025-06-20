using Microservices.Demo.Reports.Service.Application.Dtos;
using Microservices.Demo.Reports.Service.Application.Interfaces;

namespace Microservices.Demo.Reports.Service.Application.Services
{
    public class ReportService : IReportService
    {

        private readonly IPolicyClient _policyClient;
        private readonly IProductClient _productClient;

        public ReportService(IPolicyClient policyClient, IProductClient productClient)
        {
            _policyClient = policyClient;
            _productClient = productClient;
        }

        public async Task<List<PolicyReportDto>> GetPolicyReportsAsync()
        {
            var policies = await _policyClient.GetPoliciesAsync();
            var report = new List<PolicyReportDto>();

            foreach (var policy in policies)
            {
                //var product = await _productClient.GetProductByIdAsync(policy.ProductId);
                //if (product == null) continue;

                report.Add(new PolicyReportDto
                {
                    //PolicyId = policy.Id,
                    //PolicyNumber = policy.Number,
                    //ProductId = product.Id,
                    //ProductName = product.Name

                    PolicyNumber = policy.Number,
                    ProductCode = policy.ProductCode,



                });
            }

            return report;
        }
    }
}
