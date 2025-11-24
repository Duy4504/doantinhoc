using System;

namespace QuanLyChiTieu.Models
{
    public class Debt
    {
        public string? Name { get; set; }
        public double OriginalAmount { get; set; }
        public double InterestRate { get; set; } 
        public DateTime DueDate { get; set; }

        public double TotalAmount()
        {
            // tính lãi 1 lần theo lãi suất 
            return OriginalAmount + (OriginalAmount * InterestRate / 100.0);
        }
    }
}
