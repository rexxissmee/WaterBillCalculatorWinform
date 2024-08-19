namespace WaterBillCalculatorWinform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.lblNumOfPeople = new System.Windows.Forms.Label();
            this.lblLastMonthReading = new System.Windows.Forms.Label();
            this.lblThisMonthReading = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxNumOfPeople = new System.Windows.Forms.TextBox();
            this.tbxLastMonthReading = new System.Windows.Forms.TextBox();
            this.tbxThisMonthReading = new System.Windows.Forms.TextBox();
            this.cbbCustomerType = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lvwWaterBill = new System.Windows.Forms.ListView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowDetail = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSortName = new System.Windows.Forms.Button();
            this.cmsSortName = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSortConsump = new System.Windows.Forms.Button();
            this.cmsSortConsump = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lowToHighToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highToLowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSortTotalBill = new System.Windows.Forms.Button();
            this.cmsSortTotalBill = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lowToHighToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.highToLowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSortName.SuspendLayout();
            this.cmsSortConsump.SuspendLayout();
            this.cmsSortTotalBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(26, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(175, 29);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer name:";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(25, 150);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(188, 29);
            this.lblCustomerType.TabIndex = 1;
            this.lblCustomerType.Text = "Type of customer:";
            // 
            // lblNumOfPeople
            // 
            this.lblNumOfPeople.AutoSize = true;
            this.lblNumOfPeople.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfPeople.Location = new System.Drawing.Point(25, 250);
            this.lblNumOfPeople.Name = "lblNumOfPeople";
            this.lblNumOfPeople.Size = new System.Drawing.Size(199, 29);
            this.lblNumOfPeople.TabIndex = 2;
            this.lblNumOfPeople.Text = "Number of people:";
            // 
            // lblLastMonthReading
            // 
            this.lblLastMonthReading.AutoSize = true;
            this.lblLastMonthReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMonthReading.Location = new System.Drawing.Point(25, 350);
            this.lblLastMonthReading.Name = "lblLastMonthReading";
            this.lblLastMonthReading.Size = new System.Drawing.Size(335, 29);
            this.lblLastMonthReading.TabIndex = 3;
            this.lblLastMonthReading.Text = "Last month water meter reading:";
            // 
            // lblThisMonthReading
            // 
            this.lblThisMonthReading.AutoSize = true;
            this.lblThisMonthReading.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThisMonthReading.Location = new System.Drawing.Point(25, 450);
            this.lblThisMonthReading.Name = "lblThisMonthReading";
            this.lblThisMonthReading.Size = new System.Drawing.Size(336, 29);
            this.lblThisMonthReading.TabIndex = 4;
            this.lblThisMonthReading.Text = "This month water meter reading:";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(25, 85);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(330, 26);
            this.tbxCustomerName.TabIndex = 0;
            // 
            // tbxNumOfPeople
            // 
            this.tbxNumOfPeople.Enabled = false;
            this.tbxNumOfPeople.Location = new System.Drawing.Point(25, 285);
            this.tbxNumOfPeople.Name = "tbxNumOfPeople";
            this.tbxNumOfPeople.Size = new System.Drawing.Size(330, 26);
            this.tbxNumOfPeople.TabIndex = 2;
            // 
            // tbxLastMonthReading
            // 
            this.tbxLastMonthReading.Location = new System.Drawing.Point(25, 385);
            this.tbxLastMonthReading.Name = "tbxLastMonthReading";
            this.tbxLastMonthReading.Size = new System.Drawing.Size(330, 26);
            this.tbxLastMonthReading.TabIndex = 3;
            // 
            // tbxThisMonthReading
            // 
            this.tbxThisMonthReading.Location = new System.Drawing.Point(25, 485);
            this.tbxThisMonthReading.Name = "tbxThisMonthReading";
            this.tbxThisMonthReading.Size = new System.Drawing.Size(330, 26);
            this.tbxThisMonthReading.TabIndex = 4;
            // 
            // cbbCustomerType
            // 
            this.cbbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCustomerType.FormattingEnabled = true;
            this.cbbCustomerType.Location = new System.Drawing.Point(25, 185);
            this.cbbCustomerType.Name = "cbbCustomerType";
            this.cbbCustomerType.Size = new System.Drawing.Size(330, 28);
            this.cbbCustomerType.TabIndex = 1;
            this.cbbCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbbCustomerType_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculate.Location = new System.Drawing.Point(255, 535);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lvwWaterBill
            // 
            this.lvwWaterBill.FullRowSelect = true;
            this.lvwWaterBill.HideSelection = false;
            this.lvwWaterBill.Location = new System.Drawing.Point(375, 50);
            this.lvwWaterBill.Name = "lvwWaterBill";
            this.lvwWaterBill.Size = new System.Drawing.Size(875, 520);
            this.lvwWaterBill.TabIndex = 12;
            this.lvwWaterBill.UseCompatibleStateImageBehavior = false;
            this.lvwWaterBill.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwWaterBill_MouseDoubleClick);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(460, 12);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(400, 26);
            this.tbxSearch.TabIndex = 8;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(375, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(85, 29);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search:";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClear.Location = new System.Drawing.Point(25, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Enabled = false;
            this.btnShowDetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnShowDetail.Location = new System.Drawing.Point(140, 535);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(100, 35);
            this.btnShowDetail.TabIndex = 6;
            this.btnShowDetail.Text = "Show detail";
            this.btnShowDetail.UseVisualStyleBackColor = true;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.Location = new System.Drawing.Point(865, 10);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(88, 29);
            this.lblSort.TabIndex = 9;
            this.lblSort.Text = "Sort by:";
            // 
            // btnSortName
            // 
            this.btnSortName.ContextMenuStrip = this.cmsSortName;
            this.btnSortName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSortName.Location = new System.Drawing.Point(949, 8);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(81, 35);
            this.btnSortName.TabIndex = 9;
            this.btnSortName.Text = "Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // cmsSortName
            // 
            this.cmsSortName.AutoSize = false;
            this.cmsSortName.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSortName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem});
            this.cmsSortName.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.cmsSortName.Name = "cmsSortName";
            this.cmsSortName.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSortName.ShowImageMargin = false;
            this.cmsSortName.Size = new System.Drawing.Size(68, 68);
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.AutoSize = false;
            this.aZToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aZToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.aZToolStripMenuItem.Text = "A - Z";
            this.aZToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.AToZName);
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.AutoSize = false;
            this.zAToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(67, 32);
            this.zAToolStripMenuItem.Text = "Z - A";
            this.zAToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.zAToolStripMenuItem.Click += new System.EventHandler(this.ZToAName);
            // 
            // btnSortConsump
            // 
            this.btnSortConsump.ContextMenuStrip = this.cmsSortConsump;
            this.btnSortConsump.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSortConsump.Location = new System.Drawing.Point(1035, 8);
            this.btnSortConsump.Name = "btnSortConsump";
            this.btnSortConsump.Size = new System.Drawing.Size(120, 35);
            this.btnSortConsump.TabIndex = 10;
            this.btnSortConsump.Text = "Consumption";
            this.btnSortConsump.UseVisualStyleBackColor = true;
            this.btnSortConsump.Click += new System.EventHandler(this.btnSortConsump_Click);
            // 
            // cmsSortConsump
            // 
            this.cmsSortConsump.AutoSize = false;
            this.cmsSortConsump.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSortConsump.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowToHighToolStripMenuItem,
            this.highToLowToolStripMenuItem});
            this.cmsSortConsump.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.cmsSortConsump.Name = "cmsSortConsump";
            this.cmsSortConsump.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSortConsump.ShowImageMargin = false;
            this.cmsSortConsump.Size = new System.Drawing.Size(121, 68);
            // 
            // lowToHighToolStripMenuItem
            // 
            this.lowToHighToolStripMenuItem.AutoSize = false;
            this.lowToHighToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lowToHighToolStripMenuItem.Name = "lowToHighToolStripMenuItem";
            this.lowToHighToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.lowToHighToolStripMenuItem.Text = "Low to High";
            this.lowToHighToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.lowToHighToolStripMenuItem.Click += new System.EventHandler(this.LowToHighConsump);
            // 
            // highToLowToolStripMenuItem
            // 
            this.highToLowToolStripMenuItem.AutoSize = false;
            this.highToLowToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.highToLowToolStripMenuItem.Name = "highToLowToolStripMenuItem";
            this.highToLowToolStripMenuItem.Size = new System.Drawing.Size(120, 32);
            this.highToLowToolStripMenuItem.Text = "High to Low";
            this.highToLowToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.highToLowToolStripMenuItem.Click += new System.EventHandler(this.HighToLowConsump);
            // 
            // btnSortTotalBill
            // 
            this.btnSortTotalBill.ContextMenuStrip = this.cmsSortTotalBill;
            this.btnSortTotalBill.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSortTotalBill.Location = new System.Drawing.Point(1160, 8);
            this.btnSortTotalBill.Name = "btnSortTotalBill";
            this.btnSortTotalBill.Size = new System.Drawing.Size(90, 35);
            this.btnSortTotalBill.TabIndex = 11;
            this.btnSortTotalBill.Text = "Total bill";
            this.btnSortTotalBill.UseVisualStyleBackColor = true;
            this.btnSortTotalBill.Click += new System.EventHandler(this.btnSortTotalBill_Click);
            // 
            // cmsSortTotalBill
            // 
            this.cmsSortTotalBill.AutoSize = false;
            this.cmsSortTotalBill.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsSortTotalBill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowToHighToolStripMenuItem1,
            this.highToLowToolStripMenuItem1});
            this.cmsSortTotalBill.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.cmsSortTotalBill.Name = "cmsSortTotalBill";
            this.cmsSortTotalBill.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cmsSortTotalBill.ShowImageMargin = false;
            this.cmsSortTotalBill.Size = new System.Drawing.Size(121, 68);
            // 
            // lowToHighToolStripMenuItem1
            // 
            this.lowToHighToolStripMenuItem1.AutoSize = false;
            this.lowToHighToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lowToHighToolStripMenuItem1.Name = "lowToHighToolStripMenuItem1";
            this.lowToHighToolStripMenuItem1.Size = new System.Drawing.Size(120, 32);
            this.lowToHighToolStripMenuItem1.Text = "Low to High";
            this.lowToHighToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.lowToHighToolStripMenuItem1.Click += new System.EventHandler(this.LowToHighTotalBill);
            // 
            // highToLowToolStripMenuItem1
            // 
            this.highToLowToolStripMenuItem1.AutoSize = false;
            this.highToLowToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.highToLowToolStripMenuItem1.Name = "highToLowToolStripMenuItem1";
            this.highToLowToolStripMenuItem1.Size = new System.Drawing.Size(120, 32);
            this.highToLowToolStripMenuItem1.Text = "High to Low";
            this.highToLowToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.highToLowToolStripMenuItem1.Click += new System.EventHandler(this.HighToLowTotalBill);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1274, 610);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lvwWaterBill);
            this.Controls.Add(this.btnShowDetail);
            this.Controls.Add(this.btnSortTotalBill);
            this.Controls.Add(this.btnSortConsump);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cbbCustomerType);
            this.Controls.Add(this.tbxThisMonthReading);
            this.Controls.Add(this.tbxLastMonthReading);
            this.Controls.Add(this.tbxNumOfPeople);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblThisMonthReading);
            this.Controls.Add(this.lblLastMonthReading);
            this.Controls.Add(this.lblNumOfPeople);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.lblCustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Water Bill Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsSortName.ResumeLayout(false);
            this.cmsSortConsump.ResumeLayout(false);
            this.cmsSortTotalBill.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblNumOfPeople;
        private System.Windows.Forms.Label lblLastMonthReading;
        private System.Windows.Forms.Label lblThisMonthReading;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxNumOfPeople;
        private System.Windows.Forms.TextBox tbxLastMonthReading;
        private System.Windows.Forms.TextBox tbxThisMonthReading;
        private System.Windows.Forms.ComboBox cbbCustomerType;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListView lvwWaterBill;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowDetail;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortConsump;
        private System.Windows.Forms.Button btnSortTotalBill;
        private System.Windows.Forms.ContextMenuStrip cmsSortConsump;
        private System.Windows.Forms.ToolStripMenuItem lowToHighToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highToLowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSortTotalBill;
        private System.Windows.Forms.ToolStripMenuItem lowToHighToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem highToLowToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsSortName;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
    }
}

