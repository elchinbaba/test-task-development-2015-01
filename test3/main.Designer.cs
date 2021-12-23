
namespace test3
{
    partial class mainform
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
            this.insbtn = new System.Windows.Forms.Button();
            this.orderdGV = new System.Windows.Forms.DataGridView();
            this.delbtn = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterPeriodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderdGV)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // insbtn
            // 
            this.insbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insbtn.Location = new System.Drawing.Point(48, 79);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(123, 59);
            this.insbtn.TabIndex = 0;
            this.insbtn.Text = "Insert Order";
            this.insbtn.UseVisualStyleBackColor = true;
            this.insbtn.Click += new System.EventHandler(this.insbtn_Click);
            // 
            // orderdGV
            // 
            this.orderdGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdGV.Location = new System.Drawing.Point(12, 194);
            this.orderdGV.Name = "orderdGV";
            this.orderdGV.Size = new System.Drawing.Size(573, 173);
            this.orderdGV.TabIndex = 1;
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delbtn.Location = new System.Drawing.Point(237, 79);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(123, 59);
            this.delbtn.TabIndex = 2;
            this.delbtn.Text = "Delete Order";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.itemToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(598, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "menu";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.lastDayToolStripMenuItem,
            this.lastWeekToolStripMenuItem,
            this.lastMonthToolStripMenuItem,
            this.lastYearToolStripMenuItem,
            this.enterPeriodToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // lastDayToolStripMenuItem
            // 
            this.lastDayToolStripMenuItem.Name = "lastDayToolStripMenuItem";
            this.lastDayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lastDayToolStripMenuItem.Text = "Last Day";
            this.lastDayToolStripMenuItem.Click += new System.EventHandler(this.lastDayToolStripMenuItem_Click);
            // 
            // lastWeekToolStripMenuItem
            // 
            this.lastWeekToolStripMenuItem.Name = "lastWeekToolStripMenuItem";
            this.lastWeekToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lastWeekToolStripMenuItem.Text = "Last Week";
            this.lastWeekToolStripMenuItem.Click += new System.EventHandler(this.lastWeekToolStripMenuItem_Click);
            // 
            // lastMonthToolStripMenuItem
            // 
            this.lastMonthToolStripMenuItem.Name = "lastMonthToolStripMenuItem";
            this.lastMonthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lastMonthToolStripMenuItem.Text = "Last Month";
            this.lastMonthToolStripMenuItem.Click += new System.EventHandler(this.lastMonthToolStripMenuItem_Click);
            // 
            // lastYearToolStripMenuItem
            // 
            this.lastYearToolStripMenuItem.Name = "lastYearToolStripMenuItem";
            this.lastYearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lastYearToolStripMenuItem.Text = "Last Year";
            this.lastYearToolStripMenuItem.Click += new System.EventHandler(this.lastYearToolStripMenuItem_Click);
            // 
            // enterPeriodToolStripMenuItem
            // 
            this.enterPeriodToolStripMenuItem.Name = "enterPeriodToolStripMenuItem";
            this.enterPeriodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enterPeriodToolStripMenuItem.Text = "Enter Period";
            this.enterPeriodToolStripMenuItem.Click += new System.EventHandler(this.enterPeriodToolStripMenuItem_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // updbtn
            // 
            this.updbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updbtn.Location = new System.Drawing.Point(432, 79);
            this.updbtn.Name = "updbtn";
            this.updbtn.Size = new System.Drawing.Size(123, 59);
            this.updbtn.TabIndex = 4;
            this.updbtn.Text = "Update Order";
            this.updbtn.UseVisualStyleBackColor = true;
            this.updbtn.Click += new System.EventHandler(this.updbtn_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 383);
            this.Controls.Add(this.updbtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.orderdGV);
            this.Controls.Add(this.insbtn);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "mainform";
            this.Text = "main";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderdGV)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insbtn;
        private System.Windows.Forms.DataGridView orderdGV;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastWeekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterPeriodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastYearToolStripMenuItem;
        private System.Windows.Forms.Button updbtn;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
    }
}

