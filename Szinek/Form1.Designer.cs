
namespace Szinek
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
            this.lblNegyzetMeret = new System.Windows.Forms.Label();
            this.lblNegyzet = new System.Windows.Forms.Label();
            this.sbMeret = new System.Windows.Forms.HScrollBar();
            this.sbPiros = new System.Windows.Forms.HScrollBar();
            this.sbZold = new System.Windows.Forms.HScrollBar();
            this.sbKek = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpirosszin = new System.Windows.Forms.Label();
            this.lblzoldszin = new System.Windows.Forms.Label();
            this.lblkekszin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "A négyzet oldalai:";
            // 
            // lblNegyzetMeret
            // 
            this.lblNegyzetMeret.AutoSize = true;
            this.lblNegyzetMeret.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNegyzetMeret.Location = new System.Drawing.Point(310, 18);
            this.lblNegyzetMeret.Name = "lblNegyzetMeret";
            this.lblNegyzetMeret.Size = new System.Drawing.Size(30, 31);
            this.lblNegyzetMeret.TabIndex = 1;
            this.lblNegyzetMeret.Text = "1";
            // 
            // lblNegyzet
            // 
            this.lblNegyzet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNegyzet.Location = new System.Drawing.Point(335, 139);
            this.lblNegyzet.Name = "lblNegyzet";
            this.lblNegyzet.Size = new System.Drawing.Size(100, 100);
            this.lblNegyzet.TabIndex = 2;
            this.lblNegyzet.Click += new System.EventHandler(this.lblNegyzet_Click);
            // 
            // sbMeret
            // 
            this.sbMeret.Location = new System.Drawing.Point(35, 66);
            this.sbMeret.Minimum = 10;
            this.sbMeret.Name = "sbMeret";
            this.sbMeret.Size = new System.Drawing.Size(585, 17);
            this.sbMeret.TabIndex = 3;
            this.sbMeret.Value = 10;
            this.sbMeret.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sbMeret_Scroll);
            // 
            // sbPiros
            // 
            this.sbPiros.Location = new System.Drawing.Point(195, 292);
            this.sbPiros.Maximum = 264;
            this.sbPiros.Name = "sbPiros";
            this.sbPiros.Size = new System.Drawing.Size(240, 17);
            this.sbPiros.TabIndex = 4;
            this.sbPiros.Scroll += new System.Windows.Forms.ScrollEventHandler(this.szinez);
            // 
            // sbZold
            // 
            this.sbZold.Location = new System.Drawing.Point(195, 321);
            this.sbZold.Maximum = 264;
            this.sbZold.Name = "sbZold";
            this.sbZold.Size = new System.Drawing.Size(240, 17);
            this.sbZold.TabIndex = 4;
            this.sbZold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.szinez);
            // 
            // sbKek
            // 
            this.sbKek.Location = new System.Drawing.Point(195, 353);
            this.sbKek.Maximum = 264;
            this.sbKek.Name = "sbKek";
            this.sbKek.Size = new System.Drawing.Size(240, 17);
            this.sbKek.TabIndex = 4;
            this.sbKek.Scroll += new System.Windows.Forms.ScrollEventHandler(this.szinez);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(74, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(74, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zöld";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(79, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kék";
            // 
            // lblpirosszin
            // 
            this.lblpirosszin.AutoSize = true;
            this.lblpirosszin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblpirosszin.Location = new System.Drawing.Point(129, 289);
            this.lblpirosszin.Name = "lblpirosszin";
            this.lblpirosszin.Size = new System.Drawing.Size(0, 20);
            this.lblpirosszin.TabIndex = 5;
            // 
            // lblzoldszin
            // 
            this.lblzoldszin.AutoSize = true;
            this.lblzoldszin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblzoldszin.Location = new System.Drawing.Point(129, 318);
            this.lblzoldszin.Name = "lblzoldszin";
            this.lblzoldszin.Size = new System.Drawing.Size(0, 20);
            this.lblzoldszin.TabIndex = 5;
            // 
            // lblkekszin
            // 
            this.lblkekszin.AutoSize = true;
            this.lblkekszin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblkekszin.Location = new System.Drawing.Point(129, 350);
            this.lblkekszin.Name = "lblkekszin";
            this.lblkekszin.Size = new System.Drawing.Size(0, 20);
            this.lblkekszin.TabIndex = 5;
            this.lblkekszin.Click += new System.EventHandler(this.lblkekszin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkekszin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblzoldszin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblpirosszin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sbKek);
            this.Controls.Add(this.sbZold);
            this.Controls.Add(this.sbPiros);
            this.Controls.Add(this.sbMeret);
            this.Controls.Add(this.lblNegyzet);
            this.Controls.Add(this.lblNegyzetMeret);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNegyzetMeret;
        private System.Windows.Forms.Label lblNegyzet;
        private System.Windows.Forms.HScrollBar sbMeret;
        private System.Windows.Forms.HScrollBar sbPiros;
        private System.Windows.Forms.HScrollBar sbZold;
        private System.Windows.Forms.HScrollBar sbKek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpirosszin;
        private System.Windows.Forms.Label lblzoldszin;
        private System.Windows.Forms.Label lblkekszin;
    }
}

