namespace NiOP_projekt1
{
    partial class ZakonGravitacijeForm
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
            this.txtMasa1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMasa2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUdaljenost = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite masu prvog tijela (kg):";
            // 
            // txtMasa1
            // 
            this.txtMasa1.Location = new System.Drawing.Point(338, 67);
            this.txtMasa1.Name = "txtMasa1";
            this.txtMasa1.Size = new System.Drawing.Size(146, 20);
            this.txtMasa1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite masu drugog tijela (kg):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMasa2
            // 
            this.txtMasa2.Location = new System.Drawing.Point(338, 135);
            this.txtMasa2.Name = "txtMasa2";
            this.txtMasa2.Size = new System.Drawing.Size(146, 20);
            this.txtMasa2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unesite udaljenost između tijela (m):";
            // 
            // txtUdaljenost
            // 
            this.txtUdaljenost.Location = new System.Drawing.Point(338, 222);
            this.txtUdaljenost.Name = "txtUdaljenost";
            this.txtUdaljenost.Size = new System.Drawing.Size(146, 20);
            this.txtUdaljenost.TabIndex = 5;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(338, 271);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(146, 37);
            this.btnIzracunaj.TabIndex = 6;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(338, 335);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(95, 13);
            this.lblRezultat.TabIndex = 7;
            this.lblRezultat.Text = "Gravitacijska sila: -";
            // 
            // ZakonGravitacijeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.txtUdaljenost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMasa2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasa1);
            this.Controls.Add(this.label1);
            this.Name = "ZakonGravitacijeForm";
            this.Text = "ZakonGravitacijeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasa1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMasa2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUdaljenost;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label lblRezultat;
    }
}