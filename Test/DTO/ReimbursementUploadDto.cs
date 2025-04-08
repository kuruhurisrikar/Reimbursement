namespace ReceiptReimbursementAPI.DTOs
{
    public class ReimbursementUploadDto
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }
    }
}
