namespace Application.Response
{
    public class InvoiceDto
    {
        public int Id { get; set; }
        public string ComName { get; set; }
        public int ComId { get; set; }
        public string Pattern { get; set; }
        public string Serial { get; set; }
        public decimal Total { get; set; }
        public decimal VatAmount { get; set; }
        public decimal Amount { get; set; }
    }
}