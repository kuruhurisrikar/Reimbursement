﻿namespace ReceiptReimbursementAPI.Models
{
    public class Reimbursement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
    }
}
