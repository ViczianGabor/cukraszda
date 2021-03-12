namespace cukraszda
{
    partial class FrmFo
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
            this.btnOlvas = new System.Windows.Forms.Button();
            this.btnmasodik = new System.Windows.Forms.Button();
            this.btnharmadik = new System.Windows.Forms.Button();
            this.btnNegyedik = new System.Windows.Forms.Button();
            this.btnotodik = new System.Windows.Forms.Button();
            this.btnhatodik = new System.Windows.Forms.Button();
            this.btnhetedik = new System.Windows.Forms.Button();
            this.btnNyolcadik = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOlvas
            // 
            this.btnOlvas.Location = new System.Drawing.Point(40, 48);
            this.btnOlvas.Name = "btnOlvas";
            this.btnOlvas.Size = new System.Drawing.Size(92, 34);
            this.btnOlvas.TabIndex = 0;
            this.btnOlvas.Text = "Beolvasás";
            this.btnOlvas.UseVisualStyleBackColor = true;
            this.btnOlvas.Click += new System.EventHandler(this.btnOlvas_Click);
            // 
            // btnmasodik
            // 
            this.btnmasodik.Location = new System.Drawing.Point(40, 122);
            this.btnmasodik.Name = "btnmasodik";
            this.btnmasodik.Size = new System.Drawing.Size(92, 31);
            this.btnmasodik.TabIndex = 1;
            this.btnmasodik.Text = "2. feladat";
            this.btnmasodik.UseVisualStyleBackColor = true;
            this.btnmasodik.Click += new System.EventHandler(this.btnmasodik_Click);
            // 
            // btnharmadik
            // 
            this.btnharmadik.Location = new System.Drawing.Point(40, 175);
            this.btnharmadik.Name = "btnharmadik";
            this.btnharmadik.Size = new System.Drawing.Size(92, 31);
            this.btnharmadik.TabIndex = 2;
            this.btnharmadik.Text = "3. feladat";
            this.btnharmadik.UseVisualStyleBackColor = true;
            this.btnharmadik.Click += new System.EventHandler(this.btnharmadik_Click);
            // 
            // btnNegyedik
            // 
            this.btnNegyedik.Location = new System.Drawing.Point(40, 234);
            this.btnNegyedik.Name = "btnNegyedik";
            this.btnNegyedik.Size = new System.Drawing.Size(92, 31);
            this.btnNegyedik.TabIndex = 3;
            this.btnNegyedik.Text = "4. feladat";
            this.btnNegyedik.UseVisualStyleBackColor = true;
            this.btnNegyedik.Click += new System.EventHandler(this.btnNegyedik_Click);
            // 
            // btnotodik
            // 
            this.btnotodik.Location = new System.Drawing.Point(40, 289);
            this.btnotodik.Name = "btnotodik";
            this.btnotodik.Size = new System.Drawing.Size(92, 31);
            this.btnotodik.TabIndex = 4;
            this.btnotodik.Text = "5. feladat";
            this.btnotodik.UseVisualStyleBackColor = true;
            this.btnotodik.Click += new System.EventHandler(this.btnotodik_Click);
            // 
            // btnhatodik
            // 
            this.btnhatodik.Location = new System.Drawing.Point(40, 338);
            this.btnhatodik.Name = "btnhatodik";
            this.btnhatodik.Size = new System.Drawing.Size(92, 31);
            this.btnhatodik.TabIndex = 5;
            this.btnhatodik.Text = "6. feladat";
            this.btnhatodik.UseVisualStyleBackColor = true;
            this.btnhatodik.Click += new System.EventHandler(this.btnhatodik_Click);
            // 
            // btnhetedik
            // 
            this.btnhetedik.Location = new System.Drawing.Point(40, 404);
            this.btnhetedik.Name = "btnhetedik";
            this.btnhetedik.Size = new System.Drawing.Size(92, 31);
            this.btnhetedik.TabIndex = 6;
            this.btnhetedik.Text = "7. feladat";
            this.btnhetedik.UseVisualStyleBackColor = true;
            // 
            // btnNyolcadik
            // 
            this.btnNyolcadik.Location = new System.Drawing.Point(40, 467);
            this.btnNyolcadik.Name = "btnNyolcadik";
            this.btnNyolcadik.Size = new System.Drawing.Size(92, 31);
            this.btnNyolcadik.TabIndex = 7;
            this.btnNyolcadik.Text = "8. feladat";
            this.btnNyolcadik.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(359, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(382, 444);
            this.listBox1.TabIndex = 8;
            // 
            // FrmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnNyolcadik);
            this.Controls.Add(this.btnhetedik);
            this.Controls.Add(this.btnhatodik);
            this.Controls.Add(this.btnotodik);
            this.Controls.Add(this.btnNegyedik);
            this.Controls.Add(this.btnharmadik);
            this.Controls.Add(this.btnmasodik);
            this.Controls.Add(this.btnOlvas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cukrászda";
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button btnOlvas;
        private System.Windows.Forms.Button btnmasodik;
        private System.Windows.Forms.Button btnharmadik;
        private System.Windows.Forms.Button btnNegyedik;
        private System.Windows.Forms.Button btnotodik;
        private System.Windows.Forms.Button btnhatodik;
        private System.Windows.Forms.Button btnhetedik;
        private System.Windows.Forms.Button btnNyolcadik;
        private System.Windows.Forms.ListBox listBox1;
    }
}

