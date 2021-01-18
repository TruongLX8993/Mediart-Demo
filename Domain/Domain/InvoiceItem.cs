namespace Domain.Domain
{
    public class InvoiceItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public decimal Total { get; set; }
        public int VatRate { get; set; }
        public int VatAmount { get; set; }
        public int Amount { get; set; }
    }
}