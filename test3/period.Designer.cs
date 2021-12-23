
namespace test3
{
    partial class periodform
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
            this.fromdTP = new System.Windows.Forms.DateTimePicker();
            this.todTP = new System.Windows.Forms.DateTimePicker();
            this.showbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromdTP
            // 
            this.fromdTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromdTP.Location = new System.Drawing.Point(42, 46);
            this.fromdTP.Name = "fromdTP";
            this.fromdTP.Size = new System.Drawing.Size(200, 20);
            this.fromdTP.TabIndex = 0;
            // 
            // todTP
            // 
            this.todTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.todTP.Location = new System.Drawing.Point(308, 46);
            this.todTP.Name = "todTP";
            this.todTP.Size = new System.Drawing.Size(200, 20);
            this.todTP.TabIndex = 1;
            // 
            // showbtn
            // 
            this.showbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showbtn.Location = new System.Drawing.Point(223, 109);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(99, 47);
            this.showbtn.TabIndex = 2;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // periodform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 168);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.todTP);
            this.Controls.Add(this.fromdTP);
            this.Name = "periodform";
            this.Text = "Enter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.periodform_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fromdTP;
        private System.Windows.Forms.DateTimePicker todTP;
        private System.Windows.Forms.Button showbtn;
    }
}