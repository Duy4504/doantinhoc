using Newtonsoft.Json;
using QuanLyChiTieu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;  // Chart WinForms
using Timer = System.Windows.Forms.Timer;



namespace QuanLyChiTieu
{
    public partial class Form1 : Form
    {
        // Runtime-created chart for monthly expenses (created when missing in Designer)
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthly;

        List<Expense> expenses;
        List<Debt> debts;
        System.Windows.Forms.Timer notifyTimer;

        public Form1()
        {
            InitializeComponent();
            expenses = DataStorage.LoadExpenses();
            debts = DataStorage.LoadDebts();
            LoadToGrid();
            LoadDebtsGrid();
            SetupNotificationTimer();
            PopulateChartDefault();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(txtAmount.Text, out double amount))
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ.");
                return;
            }
            var exp = new Expense()
            {
                Amount = amount,
                Note = txtNote.Text,
                Date = dtDate.Value,
                Type = cbType.Text
            };
            expenses.Add(exp);
            DataStorage.SaveExpenses(expenses);
            LoadToGrid();
            ClearExpenseInputs();
            PopulateChartDefault();
        }

        private void ClearExpenseInputs()
        {
            txtAmount.Text = "";
            txtNote.Text = "";
            cbType.SelectedIndex = 1; // Chi
            dtDate.Value = DateTime.Now;
        }

        private void LoadToGrid()
        {
            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = expenses.OrderByDescending(x=>x.Date).ToList();
        }

        private void btnStatMonth_Click(object sender, EventArgs e)
        {
            int month = (int)numMonth.Value;
            int year = (int)numYear.Value;
            var list = expenses.Where(x => x.Date.Month == month && x.Date.Year == year);
            double totalChi = list.Where(x => x.Type == "Chi").Sum(x => x.Amount);
            double totalThu = list.Where(x => x.Type == "Thu").Sum(x => x.Amount);

            MessageBox.Show($"Thống kê {month}/{year}\\nTổng Thu: {totalThu:N0}\\nTổng Chi: {totalChi:N0}");
        }

        private void btnAddDebt_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDebtAmount.Text, out double amount))
            {
                MessageBox.Show("Số tiền nợ không hợp lệ.");
                return;
            }
            if (!double.TryParse(txtInterest.Text, out double interest))
            {
                MessageBox.Show("Lãi suất không hợp lệ.");
                return;
            }

            var d = new Debt()
            {
                Name = txtDebtName.Text,
                OriginalAmount = amount,
                InterestRate = interest,
                DueDate = dtDueDate.Value
            };
            debts.Add(d);
            DataStorage.SaveDebts(debts);
            LoadDebtsGrid();
            ClearDebtInputs();
        }

        private void ClearDebtInputs()
        {
            txtDebtName.Text = "";
            txtDebtAmount.Text = "";
            txtInterest.Text = "0";
            dtDueDate.Value = DateTime.Now;
        }

        private void LoadDebtsGrid()
        {
            dgvDebts.DataSource = null;
            dgvDebts.DataSource = debts.OrderBy(x=>x.DueDate).ToList();
        }

        private void SetupNotificationTimer()
        {
            notifyTimer = new Timer();
            notifyTimer.Interval = 60 * 1000; // kiểm tra mỗi phút
            notifyTimer.Tick += NotifyTimer_Tick;
            notifyTimer.Start();
            // kiểm tra ngay khi mở
            CheckDebtDue();
        }

        private void NotifyTimer_Tick(object? sender, EventArgs e)
        {
            CheckDebtDue();
        }

        private void CheckDebtDue()
        {
            var today = DateTime.Now.Date;
            var dueList = debts.Where(d => d.DueDate.Date <= today).ToList();
            foreach(var d in dueList)
            {
                MessageBox.Show($"Nợ \"{d.Name}\" đã đến hạn hoặc quá hạn!\\nTổng cần trả: {d.TotalAmount():N0} VND\\nHạn: {d.DueDate:d}");
            }
        }

        // --- Edit / Delete for Expenses ---
        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow == null) { MessageBox.Show("Chọn giao dịch để sửa."); return; }
            var exp = dgvExpenses.CurrentRow.DataBoundItem as Expense;
            if (exp == null) return;

            // populate fields for editing
            txtAmount.Text = exp.Amount.ToString();
            txtNote.Text = exp.Note;
            cbType.Text = exp.Type;
            dtDate.Value = exp.Date;

            // remove original temporarily; when user clicks "Update" it will re-add
            expenses.Remove(exp);
            DataStorage.SaveExpenses(expenses);
            LoadToGrid();
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.CurrentRow == null) { MessageBox.Show("Chọn giao dịch để xóa."); return; }
            var exp = dgvExpenses.CurrentRow.DataBoundItem as Expense;
            if (exp == null) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa giao dịch này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                expenses.Remove(exp);
                DataStorage.SaveExpenses(expenses);
                LoadToGrid();
                PopulateChartDefault();
            }
        }

        // To allow updating after editing fields: user edits fields then clicks "Thêm giao dịch" again to re-add.
        // Alternatively we could implement a separate Update button; keeping flow simple.

        // --- Edit / Delete for Debts ---
        private void btnEditDebt_Click(object sender, EventArgs e)
        {
            if (dgvDebts.CurrentRow == null) { MessageBox.Show("Chọn nợ để sửa."); return; }
            var d = dgvDebts.CurrentRow.DataBoundItem as Debt;
            if (d == null) return;

            txtDebtName.Text = d.Name;
            txtDebtAmount.Text = d.OriginalAmount.ToString();
            txtInterest.Text = d.InterestRate.ToString();
            dtDueDate.Value = d.DueDate;

            debts.Remove(d);
            DataStorage.SaveDebts(debts);
            LoadDebtsGrid();
        }

        private void btnDeleteDebt_Click(object sender, EventArgs e)
        {
            if (dgvDebts.CurrentRow == null) { MessageBox.Show("Chọn nợ để xóa."); return; }
            var d = dgvDebts.CurrentRow.DataBoundItem as Debt;
            if (d == null) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa nợ này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                debts.Remove(d);
                DataStorage.SaveDebts(debts);
                LoadDebtsGrid();
            }
        }

        // --- Charting: compare Thu vs Chi per month in selected year ---
        private void PopulateChartDefault()
        {
            int year = DateTime.Now.Year;
            PopulateChartForYear(year);
            numYear.Value = year;
        }

        private void PopulateChartForYear(int year)
        {
            // Ensure chart exists (create at runtime if Designer doesn't have it)
            if (this.chartMonthly == null)
            {
                this.chartMonthly = new System.Windows.Forms.DataVisualization.Charting.Chart();
                var chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("Default");
                this.chartMonthly.ChartAreas.Add(chartArea);
                this.chartMonthly.Legends.Add(new System.Windows.Forms.DataVisualization.Charting.Legend("Legend1"));
                this.chartMonthly.Name = "chartMonthly";
                this.chartMonthly.Size = new System.Drawing.Size(760, 300);
                this.chartMonthly.Location = new System.Drawing.Point(12, 300);
                this.chartMonthly.TabIndex = 0;
                this.chartMonthly.Text = "Biểu đồ theo tháng";
                try
                {
                    // Try to add into an existing panel named 'panelChart' if present, otherwise add to form controls
                    var panel = this.Controls.Cast<System.Windows.Forms.Control>().FirstOrDefault(c => c.Name == "panelChart");
                    if (panel != null)
                        panel.Controls.Add(this.chartMonthly);
                    else
                        this.Controls.Add(this.chartMonthly);
                }
                catch { }
            }

            if (chartMonthly.ChartAreas.Count == 0)
                chartMonthly.ChartAreas.Add(new ChartArea("Default"));

            chartMonthly.Series.Clear();

            var area = chartMonthly.ChartAreas[0];
            area.AxisX.Interval = 1;
            area.AxisX.Title = "Tháng";
            area.AxisY.Title = "Số tiền";

            var seriesThu = new Series("Thu")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };
            var seriesChi = new Series("Chi")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            for (int m = 1; m <= 12; m++)
            {
                var monthData = expenses.Where(x => x.Date.Year == year && x.Date.Month == m);
                double thu = 0;
                double chi = 0;
                if (monthData.Any())
                {
                    thu = monthData.Where(x => x.Type == "Thu").Sum(x => x.Amount);
                    chi = monthData.Where(x => x.Type == "Chi").Sum(x => x.Amount);
                }

                seriesThu.Points.AddXY(m.ToString(), thu);
                seriesChi.Points.AddXY(m.ToString(), chi);
            }

            chartMonthly.Series.Add(seriesThu);
            chartMonthly.Series.Add(seriesChi);

            chartMonthly.Invalidate();
        }




        private void btnRefreshChart_Click(object sender, EventArgs e)
        {
            int year = (int)numYear.Value;
            PopulateChartForYear(year);
        }
    }
}
