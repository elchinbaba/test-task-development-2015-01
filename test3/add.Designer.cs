
namespace test3
{
    partial class addform
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
            this.addbtn = new System.Windows.Forms.Button();
            this.prodnamelbl = new System.Windows.Forms.Label();
            this.prodnametxtB = new System.Windows.Forms.TextBox();
            this.pricetxtB = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.numtxtB = new System.Windows.Forms.TextBox();
            this.numlbl = new System.Windows.Forms.Label();
            this.valuetxtB = new System.Windows.Forms.TextBox();
            this.valuelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(127, 243);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(106, 65);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // prodnamelbl
            // 
            this.prodnamelbl.AutoSize = true;
            this.prodnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnamelbl.Location = new System.Drawing.Point(63, 54);
            this.prodnamelbl.Name = "prodnamelbl";
            this.prodnamelbl.Size = new System.Drawing.Size(114, 20);
            this.prodnamelbl.TabIndex = 1;
            this.prodnamelbl.Text = "Product Name:";
            // 
            // prodnametxtB
            // 
            this.prodnametxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodnametxtB.Location = new System.Drawing.Point(207, 51);
            this.prodnametxtB.Name = "prodnametxtB";
            this.prodnametxtB.Size = new System.Drawing.Size(100, 26);
            this.prodnametxtB.TabIndex = 2;
            // 
            // pricetxtB
            // 
            this.pricetxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetxtB.Location = new System.Drawing.Point(207, 89);
            this.pricetxtB.Name = "pricetxtB";
            this.pricetxtB.Size = new System.Drawing.Size(100, 26);
            this.pricetxtB.TabIndex = 4;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(63, 92);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(47, 20);
            this.pricelbl.TabIndex = 3;
            this.pricelbl.Text = "price:";
            // 
            // numtxtB
            // 
            this.numtxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numtxtB.Location = new System.Drawing.Point(207, 128);
            this.numtxtB.Name = "numtxtB";
            this.numtxtB.Size = new System.Drawing.Size(100, 26);
            this.numtxtB.TabIndex = 6;
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numlbl.Location = new System.Drawing.Point(63, 131);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(67, 20);
            this.numlbl.TabIndex = 5;
            this.numlbl.Text = "number:";
            // 
            // valuetxtB
            // 
            this.valuetxtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuetxtB.Location = new System.Drawing.Point(207, 164);
            this.valuetxtB.Name = "valuetxtB";
            this.valuetxtB.Size = new System.Drawing.Size(100, 26);
            this.valuetxtB.TabIndex = 8;
            // 
            // valuelbl
            // 
            this.valuelbl.AutoSize = true;
            this.valuelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuelbl.Location = new System.Drawing.Point(63, 167);
            this.valuelbl.Name = "valuelbl";
            this.valuelbl.Size = new System.Drawing.Size(50, 20);
            this.valuelbl.TabIndex = 7;
            this.valuelbl.Text = "value:";
            // 
            // addform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 335);
            this.Controls.Add(this.valuetxtB);
            this.Controls.Add(this.valuelbl);
            this.Controls.Add(this.numtxtB);
            this.Controls.Add(this.numlbl);
            this.Controls.Add(this.pricetxtB);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.prodnametxtB);
            this.Controls.Add(this.prodnamelbl);
            this.Controls.Add(this.addbtn);
            this.Name = "addform";
            this.Text = "Add";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.addform_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label prodnamelbl;
        private System.Windows.Forms.TextBox prodnametxtB;
        private System.Windows.Forms.TextBox pricetxtB;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox numtxtB;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.TextBox valuetxtB;
        private System.Windows.Forms.Label valuelbl;
    }
}