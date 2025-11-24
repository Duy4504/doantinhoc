namespace QuanLyChiTieu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        

        /// <summary>
        /// Dispose
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.btnRefreshChart = new System.Windows.Forms.Button();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.btnStatMonth = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabDebts = new System.Windows.Forms.TabPage();
            this.dgvDebts = new System.Windows.Forms.DataGridView();
            this.btnDeleteDebt = new System.Windows.Forms.Button();
            this.btnEditDebt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInterest = new System.Windows.Forms.TextBox();
            this.dtDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtDebtAmount = new System.Windows.Forms.TextBox();
            this.txtDebtName = new System.Windows.Forms.TextBox();
            this.btnAddDebt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            this.tabDebts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExpenses);
            this.tabControl1.Controls.Add(this.tabStats);
            this.tabControl1.Controls.Add(this.tabDebts);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(8, 4);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabExpenses
            // 
            this.tabExpenses.Controls.Add(this.dgvExpenses);
            this.tabExpenses.Controls.Add(this.btnDeleteExpense);
            this.tabExpenses.Controls.Add(this.btnEditExpense);
            this.tabExpenses.Controls.Add(this.groupBox1);
            this.tabExpenses.Location = new System.Drawing.Point(4, 32);
            this.tabExpenses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabExpenses.Size = new System.Drawing.Size(1042, 594);
            this.tabExpenses.TabIndex = 0;
            this.tabExpenses.Text = "Thu/Chi";
            this.tabExpenses.UseVisualStyleBackColor = true;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Location = new System.Drawing.Point(12, 170);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.RowTemplate.Height = 28;
            this.dgvExpenses.Size = new System.Drawing.Size(1016, 410);
            this.dgvExpenses.TabIndex = 1;
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.Location = new System.Drawing.Point(888, 126);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(140, 38);
            this.btnDeleteExpense.TabIndex = 7;
            this.btnDeleteExpense.Text = "Xóa giao dịch";
            this.btnDeleteExpense.UseVisualStyleBackColor = true;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.Location = new System.Drawing.Point(730, 126);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(140, 38);
            this.btnEditExpense.TabIndex = 6;
            this.btnEditExpense.Text = "Sửa giao dịch";
            this.btnEditExpense.UseVisualStyleBackColor = true;
            this.btnEditExpense.Click += new System.EventHandler(this.btnEditExpense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.dtDate);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.btnAddExpense);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập giao dịch";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Thu",
            "Chi"});
            this.cbType.Location = new System.Drawing.Point(82, 28);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 28);
            this.cbType.TabIndex = 0;
            this.cbType.Text = "Chi";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(82, 62);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(250, 26);
            this.dtDate.TabIndex = 2;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(430, 28);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(420, 26);
            this.txtNote.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(82, 99);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(250, 26);
            this.txtAmount.TabIndex = 4;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(430, 88);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(140, 38);
            this.btnAddExpense.TabIndex = 5;
            this.btnAddExpense.Text = "Thêm giao dịch";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ghi chú";
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.btnRefreshChart);
            this.tabStats.Controls.Add(this.numYear);
            this.tabStats.Controls.Add(this.numMonth);
            this.tabStats.Controls.Add(this.btnStatMonth);
            this.tabStats.Controls.Add(this.label4);
            this.tabStats.Controls.Add(this.label5);
            this.tabStats.Location = new System.Drawing.Point(4, 32);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabStats.Size = new System.Drawing.Size(1042, 594);
            this.tabStats.TabIndex = 1;
            this.tabStats.Text = "Thống kê";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // btnRefreshChart
            // 
            this.btnRefreshChart.Location = new System.Drawing.Point(460, 20);
            this.btnRefreshChart.Name = "btnRefreshChart";
            this.btnRefreshChart.Size = new System.Drawing.Size(140, 38);
            this.btnRefreshChart.TabIndex = 7;
            this.btnRefreshChart.Text = "Làm mới biểu đồ";
            this.btnRefreshChart.UseVisualStyleBackColor = true;
            this.btnRefreshChart.Click += new System.EventHandler(this.btnRefreshChart_Click);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(160, 28);
            this.numYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numYear.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(120, 26);
            this.numYear.TabIndex = 3;
            this.numYear.Value = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            // 
            // numMonth
            // 
            this.numMonth.Location = new System.Drawing.Point(78, 28);
            this.numMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(60, 26);
            this.numMonth.TabIndex = 2;
            this.numMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnStatMonth
            // 
            this.btnStatMonth.Location = new System.Drawing.Point(300, 20);
            this.btnStatMonth.Name = "btnStatMonth";
            this.btnStatMonth.Size = new System.Drawing.Size(140, 38);
            this.btnStatMonth.TabIndex = 1;
            this.btnStatMonth.Text = "Thống kê";
            this.btnStatMonth.UseVisualStyleBackColor = true;
            this.btnStatMonth.Click += new System.EventHandler(this.btnStatMonth_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Năm";
            // 
            // tabDebts
            // 
            this.tabDebts.Controls.Add(this.dgvDebts);
            this.tabDebts.Controls.Add(this.btnDeleteDebt);
            this.tabDebts.Controls.Add(this.btnEditDebt);
            this.tabDebts.Controls.Add(this.groupBox2);
            this.tabDebts.Location = new System.Drawing.Point(4, 32);
            this.tabDebts.Name = "tabDebts";
            this.tabDebts.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebts.Size = new System.Drawing.Size(1042, 594);
            this.tabDebts.TabIndex = 2;
            this.tabDebts.Text = "Quản lý nợ";
            this.tabDebts.UseVisualStyleBackColor = true;
            // 
            // dgvDebts
            // 
            this.dgvDebts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebts.Location = new System.Drawing.Point(12, 170);
            this.dgvDebts.Name = "dgvDebts";
            this.dgvDebts.RowTemplate.Height = 28;
            this.dgvDebts.Size = new System.Drawing.Size(1016, 410);
            this.dgvDebts.TabIndex = 1;
            // 
            // btnDeleteDebt
            // 
            this.btnDeleteDebt.Location = new System.Drawing.Point(888, 126);
            this.btnDeleteDebt.Name = "btnDeleteDebt";
            this.btnDeleteDebt.Size = new System.Drawing.Size(140, 38);
            this.btnDeleteDebt.TabIndex = 7;
            this.btnDeleteDebt.Text = "Xóa nợ";
            this.btnDeleteDebt.UseVisualStyleBackColor = true;
            this.btnDeleteDebt.Click += new System.EventHandler(this.btnDeleteDebt_Click);
            // 
            // btnEditDebt
            // 
            this.btnEditDebt.Location = new System.Drawing.Point(730, 126);
            this.btnEditDebt.Name = "btnEditDebt";
            this.btnEditDebt.Size = new System.Drawing.Size(140, 38);
            this.btnEditDebt.TabIndex = 6;
            this.btnEditDebt.Text = "Sửa nợ";
            this.btnEditDebt.UseVisualStyleBackColor = true;
            this.btnEditDebt.Click += new System.EventHandler(this.btnEditDebt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInterest);
            this.groupBox2.Controls.Add(this.dtDueDate);
            this.groupBox2.Controls.Add(this.txtDebtAmount);
            this.groupBox2.Controls.Add(this.txtDebtName);
            this.groupBox2.Controls.Add(this.btnAddDebt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm nợ";
            // 
            // txtInterest
            // 
            this.txtInterest.Location = new System.Drawing.Point(430, 28);
            this.txtInterest.Name = "txtInterest";
            this.txtInterest.Size = new System.Drawing.Size(120, 26);
            this.txtInterest.TabIndex = 3;
            this.txtInterest.Text = "0";
            // 
            // dtDueDate
            // 
            this.dtDueDate.Location = new System.Drawing.Point(82, 62);
            this.dtDueDate.Name = "dtDueDate";
            this.dtDueDate.Size = new System.Drawing.Size(250, 26);
            this.dtDueDate.TabIndex = 2;
            // 
            // txtDebtAmount
            // 
            this.txtDebtAmount.Location = new System.Drawing.Point(82, 28);
            this.txtDebtAmount.Name = "txtDebtAmount";
            this.txtDebtAmount.Size = new System.Drawing.Size(250, 26);
            this.txtDebtAmount.TabIndex = 1;
            // 
            // txtDebtName
            // 
            this.txtDebtName.Location = new System.Drawing.Point(582, 28);
            this.txtDebtName.Name = "txtDebtName";
            this.txtDebtName.Size = new System.Drawing.Size(300, 26);
            this.txtDebtName.TabIndex = 0;
            // 
            // btnAddDebt
            // 
            this.btnAddDebt.Location = new System.Drawing.Point(430, 88);
            this.btnAddDebt.Name = "btnAddDebt";
            this.btnAddDebt.Size = new System.Drawing.Size(140, 38);
            this.btnAddDebt.TabIndex = 5;
            this.btnAddDebt.Text = "Thêm nợ";
            this.btnAddDebt.UseVisualStyleBackColor = true;
            this.btnAddDebt.Click += new System.EventHandler(this.btnAddDebt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lãi suất %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Hạn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tên nợ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1070, 650);
            this.Controls.Add(this.tabControl1);
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Name = "Form1";
            this.Text = "Quản lý chi tiêu - EverBloom (Demo)";
            this.tabControl1.ResumeLayout(false);
            this.tabExpenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabStats.ResumeLayout(false);
            this.tabStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            this.tabDebts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

            this.formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            this.tabStats.Controls.Add(this.formsPlot1);
            this.formsPlot1.Location = new System.Drawing.Point(20, 80);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(980, 490);
            this.formsPlot1.TabIndex = 10;

        }

        #endregion
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExpenses;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.Button btnRefreshChart;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Button btnStatMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabDebts;
        private System.Windows.Forms.DataGridView dgvDebts;
        private System.Windows.Forms.Button btnDeleteDebt;
        private System.Windows.Forms.Button btnEditDebt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInterest;
        private System.Windows.Forms.DateTimePicker dtDueDate;
        private System.Windows.Forms.TextBox txtDebtAmount;
        private System.Windows.Forms.TextBox txtDebtName;
        private System.Windows.Forms.Button btnAddDebt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
