using Newtonsoft.Json;
using QuanLyChiTieu.Models;
using System;
using System.Collections.Generic;
using System.IO;

public static class DataStorage
{
    private static string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
    private static string expenseFile = Path.Combine(dataDir, "expenses.json");
    private static string debtFile = Path.Combine(dataDir, "debts.json");

    static DataStorage()
    {
        if (!Directory.Exists(dataDir)) Directory.CreateDirectory(dataDir);
    }

    public static List<Expense> LoadExpenses()
    {
        if (!File.Exists(expenseFile)) return new List<Expense>();
        return JsonConvert.DeserializeObject<List<Expense>>(File.ReadAllText(expenseFile)) ?? new List<Expense>();
    }

    public static void SaveExpenses(List<Expense> data)
    {
        File.WriteAllText(expenseFile, JsonConvert.SerializeObject(data, Formatting.Indented));
    }

    public static List<Debt> LoadDebts()
    {
        if (!File.Exists(debtFile)) return new List<Debt>();
        return JsonConvert.DeserializeObject<List<Debt>>(File.ReadAllText(debtFile)) ?? new List<Debt>();
    }

    public static void SaveDebts(List<Debt> data)
    {
        File.WriteAllText(debtFile, JsonConvert.SerializeObject(data, Formatting.Indented));
    }
}
