using Microservices.Demo.Report.Service.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Demo.Report.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public ReportController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }


        //[HttpGet(Name = "policies")]
        //public async Task<IActionResult> GetPoliciesReportAsync()
        //{

        //    var policies = await _httpClient.GetFromJsonAsync<List<PolicyDto>>("http://localhost:5182/api/policies");

        //    var report = new List<ReportDto>();

        //    //foreach (var policy in policies)
        //    //{
        //    //    var product = await _httpClient.GetFromJsonAsync<ProductDto>($"http://products.service/api/products/{policy.ProductId}");

        //    //    report.Add(new ReportDto
        //    //    {
        //    //        PolicyId = policy.Id,
        //    //        PolicyHolder = policy.Holder,
        //    //        ProductId = product.Id,
        //    //        ProductName = product.Name,
        //    //        Coverage = product.Coverage
        //    //    });
        //    //}

        //    return Ok(report);
        //}
    }
}
