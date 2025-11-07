using System;

namespace QuanLyChiTieu.Models
{
    public class Expense
    {
        public double Amount { get; set; }
        public string? Note { get; set; }
        public DateTime Date { get; set; }
        public string? Type { get; set; } // "Thu" hoặc "Chi"
    }
}
