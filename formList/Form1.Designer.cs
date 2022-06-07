
namespace formList
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
            this.LBx_a = new System.Windows.Forms.ListBox();
            this.LBx_b = new System.Windows.Forms.ListBox();
            this.LBx_unio = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.btnEloall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBx_a
            // 
            this.LBx_a.FormattingEnabled = true;
            this.LBx_a.Location = new System.Drawing.Point(0, 0);
            this.LBx_a.Name = "LBx_a";
            this.LBx_a.Size = new System.Drawing.Size(96, 277);
            this.LBx_a.TabIndex = 0;
            // 
            // LBx_b
            // 
            this.LBx_b.FormattingEnabled = true;
            this.LBx_b.Location = new System.Drawing.Point(102, 0);
            this.LBx_b.Name = "LBx_b";
            this.LBx_b.Size = new System.Drawing.Size(96, 277);
            this.LBx_b.TabIndex = 0;
            // 
            // LBx_unio
            // 
            this.LBx_unio.FormattingEnabled = true;
            this.LBx_unio.Location = new System.Drawing.Point(204, 0);
            this.LBx_unio.Name = "LBx_unio";
            this.LBx_unio.Size = new System.Drawing.Size(96, 277);
            this.LBx_unio.TabIndex = 0;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(307, 0);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(96, 277);
            this.listBox4.TabIndex = 0;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(409, 0);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(96, 277);
            this.listBox5.TabIndex = 0;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(511, 0);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(96, 277);
            this.listBox6.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Halmazok elemszáma";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(15, 326);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 3;
            // 
            // btnEloall
            // 
            this.btnEloall.Location = new System.Drawing.Point(137, 350);
            this.btnEloall.Name = "btnEloall";
            this.btnEloall.Size = new System.Drawing.Size(75, 23);
            this.btnEloall.TabIndex = 4;
            this.btnEloall.Text = "Előállít";
            this.btnEloall.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEloall);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.LBx_unio);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.LBx_b);
            this.Controls.Add(this.LBx_a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBx_a;
        private System.Windows.Forms.ListBox LBx_b;
        private System.Windows.Forms.ListBox LBx_unio;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btnEloall;
    }
}

