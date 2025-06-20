namespace Microservices.Demo.Report.Service.DTO
{
    public class ReportDto
    {
        public int PolicyId { get; set; }
        public string PolicyHolder { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Coverage { get; set; }
    }
}
