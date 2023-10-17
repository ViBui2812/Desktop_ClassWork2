namespace BTTL_Buoi2
{
    partial class BTTL_Buoi2
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
            this.txtAx = new System.Windows.Forms.TextBox();
            this.txtAy = new System.Windows.Forms.TextBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.txtBy = new System.Windows.Forms.TextBox();
            this.btnNhapA = new System.Windows.Forms.Button();
            this.btnNhapB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm A: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm B: ";
            // 
            // txtAx
            // 
            this.txtAx.Location = new System.Drawing.Point(211, 31);
            this.txtAx.Name = "txtAx";
            this.txtAx.Size = new System.Drawing.Size(67, 22);
            this.txtAx.TabIndex = 2;
            this.txtAx.Text = "Ax";
            this.txtAx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAy
            // 
            this.txtAy.Location = new System.Drawing.Point(314, 31);
            this.txtAy.Name = "txtAy";
            this.txtAy.Size = new System.Drawing.Size(67, 22);
            this.txtAy.TabIndex = 3;
            this.txtAy.Text = "Ay";
            this.txtAy.TextChanged += new System.EventHandler(this.txtAy_TextChanged);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(211, 76);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(67, 22);
            this.txtBx.TabIndex = 4;
            this.txtBx.Text = "Bx";
            // 
            // txtBy
            // 
            this.txtBy.Location = new System.Drawing.Point(314, 76);
            this.txtBy.Name = "txtBy";
            this.txtBy.Size = new System.Drawing.Size(67, 22);
            this.txtBy.TabIndex = 5;
            this.txtBy.Text = "By";
            // 
            // btnNhapA
            // 
            this.btnNhapA.Location = new System.Drawing.Point(420, 31);
            this.btnNhapA.Name = "btnNhapA";
            this.btnNhapA.Size = new System.Drawing.Size(75, 23);
            this.btnNhapA.TabIndex = 6;
            this.btnNhapA.Text = "Nhập A";
            this.btnNhapA.UseVisualStyleBackColor = true;
            this.btnNhapA.Click += new System.EventHandler(this.btnNhapA_Click);
            // 
            // btnNhapB
            // 
            this.btnNhapB.Location = new System.Drawing.Point(420, 75);
            this.btnNhapB.Name = "btnNhapB";
            this.btnNhapB.Size = new System.Drawing.Size(75, 23);
            this.btnNhapB.TabIndex = 7;
            this.btnNhapB.Text = "Nhập B";
            this.btnNhapB.UseVisualStyleBackColor = true;
            this.btnNhapB.Click += new System.EventHandler(this.btnNhapB_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(152, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 260);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(287, 113);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // BTTL_Buoi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNhapB);
            this.Controls.Add(this.btnNhapA);
            this.Controls.Add(this.txtBy);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.txtAy);
            this.Controls.Add(this.txtAx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BTTL_Buoi2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BTTL_Buoi2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAx;
        private System.Windows.Forms.TextBox txtAy;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.TextBox txtBy;
        private System.Windows.Forms.Button btnNhapA;
        private System.Windows.Forms.Button btnNhapB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOK;
    }
}

