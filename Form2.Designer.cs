namespace WaterBillCalculatorWinform
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblLastMonthReading = new System.Windows.Forms.Label();
            this.lblThisMonthReading = new System.Windows.Forms.Label();
            this.lblConsumption = new System.Windows.Forms.Label();
            this.lblAmountNeedToPaid = new System.Windows.Forms.Label();
            this.lblWaterBill = new System.Windows.Forms.Label();
            this.pnlWaterBill = new System.Windows.Forms.Panel();
            this.tbxLastMonthReading = new System.Windows.Forms.TextBox();
            this.tbxThisMonthReading = new System.Windows.Forms.TextBox();
            this.tbxConsumption = new System.Windows.Forms.TextBox();
            this.tbxAmountNeedToPaid = new System.Windows.Forms.TextBox();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.pnlWaterBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(30, 100);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(175, 29);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer name:";
            // 
            // lblLastMonthReading
            // 
            this.lblLastMonthReading.AutoSize = true;
            this.lblLastMonthReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMonthReading.Location = new System.Drawing.Point(30, 150);
            this.lblLastMonthReading.Name = "lblLastMonthReading";
            this.lblLastMonthReading.Size = new System.Drawing.Size(349, 29);
            this.lblLastMonthReading.TabIndex = 1;
            this.lblLastMonthReading.Text = "Last month\'s water meter reading:";
            // 
            // lblThisMonthReading
            // 
            this.lblThisMonthReading.AutoSize = true;
            this.lblThisMonthReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisMonthReading.Location = new System.Drawing.Point(30, 200);
            this.lblThisMonthReading.Name = "lblThisMonthReading";
            this.lblThisMonthReading.Size = new System.Drawing.Size(350, 29);
            this.lblThisMonthReading.TabIndex = 2;
            this.lblThisMonthReading.Text = "This month\'s water meter reading:";
            // 
            // lblConsumption
            // 
            this.lblConsumption.AutoSize = true;
            this.lblConsumption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumption.Location = new System.Drawing.Point(30, 250);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(151, 29);
            this.lblConsumption.TabIndex = 3;
            this.lblConsumption.Text = "Consumption:";
            // 
            // lblAmountNeedToPaid
            // 
            this.lblAmountNeedToPaid.AutoSize = true;
            this.lblAmountNeedToPaid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountNeedToPaid.Location = new System.Drawing.Point(30, 300);
            this.lblAmountNeedToPaid.Name = "lblAmountNeedToPaid";
            this.lblAmountNeedToPaid.Size = new System.Drawing.Size(229, 29);
            this.lblAmountNeedToPaid.TabIndex = 4;
            this.lblAmountNeedToPaid.Text = "Amount need to paid:";
            // 
            // lblWaterBill
            // 
            this.lblWaterBill.AutoSize = true;
            this.lblWaterBill.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterBill.Location = new System.Drawing.Point(181, 30);
            this.lblWaterBill.Name = "lblWaterBill";
            this.lblWaterBill.Size = new System.Drawing.Size(203, 54);
            this.lblWaterBill.TabIndex = 0;
            this.lblWaterBill.Text = "Water Bill";
            this.lblWaterBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWaterBill
            // 
            this.pnlWaterBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlWaterBill.Controls.Add(this.btnPay);
            this.pnlWaterBill.Controls.Add(this.tbxLastMonthReading);
            this.pnlWaterBill.Controls.Add(this.tbxThisMonthReading);
            this.pnlWaterBill.Controls.Add(this.tbxConsumption);
            this.pnlWaterBill.Controls.Add(this.tbxAmountNeedToPaid);
            this.pnlWaterBill.Controls.Add(this.tbxCustomerName);
            this.pnlWaterBill.Controls.Add(this.lblWaterBill);
            this.pnlWaterBill.Controls.Add(this.lblCustomerName);
            this.pnlWaterBill.Controls.Add(this.lblLastMonthReading);
            this.pnlWaterBill.Controls.Add(this.lblThisMonthReading);
            this.pnlWaterBill.Controls.Add(this.lblConsumption);
            this.pnlWaterBill.Controls.Add(this.lblAmountNeedToPaid);
            this.pnlWaterBill.Location = new System.Drawing.Point(25, 25);
            this.pnlWaterBill.Name = "pnlWaterBill";
            this.pnlWaterBill.Size = new System.Drawing.Size(565, 405);
            this.pnlWaterBill.TabIndex = 1;
            // 
            // tbxLastMonthReading
            // 
            this.tbxLastMonthReading.BackColor = System.Drawing.SystemColors.Control;
            this.tbxLastMonthReading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLastMonthReading.Enabled = false;
            this.tbxLastMonthReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLastMonthReading.Location = new System.Drawing.Point(385, 150);
            this.tbxLastMonthReading.Name = "tbxLastMonthReading";
            this.tbxLastMonthReading.ReadOnly = true;
            this.tbxLastMonthReading.Size = new System.Drawing.Size(150, 30);
            this.tbxLastMonthReading.TabIndex = 1;
            this.tbxLastMonthReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxThisMonthReading
            // 
            this.tbxThisMonthReading.BackColor = System.Drawing.SystemColors.Control;
            this.tbxThisMonthReading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxThisMonthReading.Enabled = false;
            this.tbxThisMonthReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxThisMonthReading.Location = new System.Drawing.Point(385, 200);
            this.tbxThisMonthReading.Name = "tbxThisMonthReading";
            this.tbxThisMonthReading.ReadOnly = true;
            this.tbxThisMonthReading.Size = new System.Drawing.Size(150, 30);
            this.tbxThisMonthReading.TabIndex = 2;
            this.tbxThisMonthReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxConsumption
            // 
            this.tbxConsumption.BackColor = System.Drawing.SystemColors.Control;
            this.tbxConsumption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxConsumption.Enabled = false;
            this.tbxConsumption.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConsumption.Location = new System.Drawing.Point(385, 250);
            this.tbxConsumption.Name = "tbxConsumption";
            this.tbxConsumption.ReadOnly = true;
            this.tbxConsumption.Size = new System.Drawing.Size(150, 30);
            this.tbxConsumption.TabIndex = 3;
            this.tbxConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxAmountNeedToPaid
            // 
            this.tbxAmountNeedToPaid.BackColor = System.Drawing.SystemColors.Control;
            this.tbxAmountNeedToPaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAmountNeedToPaid.Enabled = false;
            this.tbxAmountNeedToPaid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAmountNeedToPaid.Location = new System.Drawing.Point(385, 300);
            this.tbxAmountNeedToPaid.Name = "tbxAmountNeedToPaid";
            this.tbxAmountNeedToPaid.ReadOnly = true;
            this.tbxAmountNeedToPaid.Size = new System.Drawing.Size(150, 30);
            this.tbxAmountNeedToPaid.TabIndex = 4;
            this.tbxAmountNeedToPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.tbxCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCustomerName.Enabled = false;
            this.tbxCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustomerName.Location = new System.Drawing.Point(385, 100);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.ReadOnly = true;
            this.tbxCustomerName.Size = new System.Drawing.Size(150, 30);
            this.tbxCustomerName.TabIndex = 0;
            this.tbxCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPay.Location = new System.Drawing.Point(222, 345);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(120, 35);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Click to pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(614, 459);
            this.Controls.Add(this.pnlWaterBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Bill";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlWaterBill.ResumeLayout(false);
            this.pnlWaterBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWaterBill;
        private System.Windows.Forms.Label lblWaterBill;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblLastMonthReading;
        private System.Windows.Forms.Label lblThisMonthReading;
        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.Label lblAmountNeedToPaid;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxLastMonthReading;
        private System.Windows.Forms.TextBox tbxThisMonthReading;
        private System.Windows.Forms.TextBox tbxConsumption;
        private System.Windows.Forms.TextBox tbxAmountNeedToPaid;
        private System.Windows.Forms.Button btnPay;
    }
}