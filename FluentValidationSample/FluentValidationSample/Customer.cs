namespace FluentValidationSample
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DocumentId { get; set; }
        public decimal Discount { get; set; }
        public bool HasDiscount { get; set; }
        public string Postcode { get; set; }
    }
}