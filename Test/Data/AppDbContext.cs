using Microsoft.EntityFrameworkCore;
using ReceiptReimbursementAPI.Models;

namespace ReceiptReimbursementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Reimbursement> Reimbursements { get; set; }
    }
}
