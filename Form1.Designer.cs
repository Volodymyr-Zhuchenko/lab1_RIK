namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.process1 = new System.Diagnostics.Process();
            this.rbDeposit = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMonths = new System.Windows.Forms.NumericUpDown();
            this.tbPercent = new System.Windows.Forms.NumericUpDown();
            this.tbAmount = new System.Windows.Forms.NumericUpDown();
            this.lblResultNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума (грн)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Відсоток (% річних)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Термін (місяці)";
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(57, 61);
            this.rbCredit.Margin = new System.Windows.Forms.Padding(2);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(61, 17);
            this.rbCredit.TabIndex = 6;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Кредит";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(173, 61);
            this.rbDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(69, 17);
            this.rbDeposit.TabIndex = 7;
            this.rbDeposit.TabStop = true;
            this.rbDeposit.Text = "Депозит";
            this.rbDeposit.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalculate.Location = new System.Drawing.Point(446, 258);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 37);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 258);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 37);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Зберегти у файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblResult.Location = new System.Drawing.Point(309, 61);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 17);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "Результат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label4.Location = new System.Drawing.Point(101, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(409, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "Калькулятор кредита та депозита";
            // 
            // tbMonths
            // 
            this.tbMonths.Location = new System.Drawing.Point(57, 203);
            this.tbMonths.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbMonths.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbMonths.Name = "tbMonths";
            this.tbMonths.Size = new System.Drawing.Size(185, 20);
            this.tbMonths.TabIndex = 14;
            this.tbMonths.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbPercent
            // 
            this.tbPercent.DecimalPlaces = 2;
            this.tbPercent.Location = new System.Drawing.Point(56, 158);
            this.tbPercent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(185, 20);
            this.tbPercent.TabIndex = 16;
            this.tbPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // tbAmount
            // 
            this.tbAmount.DecimalPlaces = 2;
            this.tbAmount.Location = new System.Drawing.Point(56, 114);
            this.tbAmount.Maximum = new decimal(new int[] {
            50000000,
            0,
            0,
            0});
            this.tbAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(185, 20);
            this.tbAmount.TabIndex = 17;
            this.tbAmount.ThousandsSeparator = true;
            this.tbAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblResultNum
            // 
            this.lblResultNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblResultNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultNum.Location = new System.Drawing.Point(306, 98);
            this.lblResultNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultNum.Name = "lblResultNum";
            this.lblResultNum.Size = new System.Drawing.Size(288, 45);
            this.lblResultNum.TabIndex = 18;
            this.lblResultNum.Text = "0,00₴";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 309);
            this.Controls.Add(this.lblResultNum);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.tbMonths);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbDeposit);
            this.Controls.Add(this.rbCredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Фінансовий помічник";
            ((System.ComponentModel.ISupportInitialize)(this.tbMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown tbMonths;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tbAmount;
        private System.Windows.Forms.NumericUpDown tbPercent;
        private System.Windows.Forms.Label lblResultNum;
    }
}

