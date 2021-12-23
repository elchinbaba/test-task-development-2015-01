
namespace test3
{
    partial class delorupdform
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
            this.delorupdbtn = new System.Windows.Forms.Button();
            this.numlbl = new System.Windows.Forms.Label();
            this.numtxtB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // delorupdbtn
            // 
            this.delorupdbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delorupdbtn.Location = new System.Drawing.Point(67, 92);
            this.delorupdbtn.Name = "delorupdbtn";
            this.delorupdbtn.Size = new System.Drawing.Size(103, 33);
            this.delorupdbtn.TabIndex = 0;
            this.delorupdbtn.Text = "DelorUpd";
            this.delorupdbtn.UseVisualStyleBackColor = true;
            this.delorupdbtn.Click += new System.EventHandler(this.delorupdbtn_Click);
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numlbl.Location = new System.Drawing.Point(29, 36);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(69, 20);
            this.numlbl.TabIndex = 1;
            this.numlbl.Text = "Number:";
            // 
            // numtxtB
            // 
            this.numtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numtxtB.Location = new System.Drawing.Point(107, 33);
            this.numtxtB.Name = "numtxtB";
            this.numtxtB.Size = new System.Drawing.Size(100, 26);
            this.numtxtB.TabIndex = 2;
            // 
            // delorupdform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 137);
            this.Controls.Add(this.numtxtB);
            this.Controls.Add(this.numlbl);
            this.Controls.Add(this.delorupdbtn);
            this.Name = "delorupdform";
            this.Text = "DelorUpd";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.delorupdform_FormClosed);
            this.Load += new System.EventHandler(this.delorupdform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delorupdbtn;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.TextBox numtxtB;
    }
}