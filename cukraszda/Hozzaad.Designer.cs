namespace cukraszda
{
    partial class Hozzaad
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
            this.btnFelvetel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTipus = new System.Windows.Forms.TextBox();
            this.tbEgyseg = new System.Windows.Forms.TextBox();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.cbDijazott = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnFelvetel
            // 
            this.btnFelvetel.Location = new System.Drawing.Point(62, 399);
            this.btnFelvetel.Name = "btnFelvetel";
            this.btnFelvetel.Size = new System.Drawing.Size(295, 39);
            this.btnFelvetel.TabIndex = 0;
            this.btnFelvetel.Text = "Új süti felvétele";
            this.btnFelvetel.UseVisualStyleBackColor = true;
            this.btnFelvetel.Click += new System.EventHandler(this.btnFelvetel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Típus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Egység";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ár";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(124, 59);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(233, 22);
            this.tbNev.TabIndex = 5;
            // 
            // tbTipus
            // 
            this.tbTipus.Location = new System.Drawing.Point(124, 118);
            this.tbTipus.Name = "tbTipus";
            this.tbTipus.Size = new System.Drawing.Size(233, 22);
            this.tbTipus.TabIndex = 6;
            // 
            // tbEgyseg
            // 
            this.tbEgyseg.Location = new System.Drawing.Point(124, 177);
            this.tbEgyseg.Name = "tbEgyseg";
            this.tbEgyseg.Size = new System.Drawing.Size(233, 22);
            this.tbEgyseg.TabIndex = 7;
            // 
            // tbAr
            // 
            this.tbAr.Location = new System.Drawing.Point(124, 236);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(233, 22);
            this.tbAr.TabIndex = 8;
            // 
            // cbDijazott
            // 
            this.cbDijazott.AutoSize = true;
            this.cbDijazott.Location = new System.Drawing.Point(62, 295);
            this.cbDijazott.Name = "cbDijazott";
            this.cbDijazott.Size = new System.Drawing.Size(77, 21);
            this.cbDijazott.TabIndex = 9;
            this.cbDijazott.Text = "Díjazott";
            this.cbDijazott.UseVisualStyleBackColor = true;
            // 
            // Hozzaad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.cbDijazott);
            this.Controls.Add(this.tbAr);
            this.Controls.Add(this.tbEgyseg);
            this.Controls.Add(this.tbTipus);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFelvetel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Hozzaad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hozzaad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFelvetel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTipus;
        private System.Windows.Forms.TextBox tbEgyseg;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.CheckBox cbDijazott;
    }
}