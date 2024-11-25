namespace NiOP_projekt1
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
            this.btnSilaTeze = new System.Windows.Forms.Button();
            this.btnZakonGravitacije = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSilaTeze
            // 
            this.btnSilaTeze.Location = new System.Drawing.Point(292, 100);
            this.btnSilaTeze.Name = "btnSilaTeze";
            this.btnSilaTeze.Size = new System.Drawing.Size(210, 80);
            this.btnSilaTeze.TabIndex = 0;
            this.btnSilaTeze.Text = "Kalkulator sile teže";
            this.btnSilaTeze.UseVisualStyleBackColor = true;
            this.btnSilaTeze.Click += new System.EventHandler(this.btnSilaTeze_Click);
            // 
            // btnZakonGravitacije
            // 
            this.btnZakonGravitacije.Location = new System.Drawing.Point(292, 246);
            this.btnZakonGravitacije.Name = "btnZakonGravitacije";
            this.btnZakonGravitacije.Size = new System.Drawing.Size(210, 80);
            this.btnZakonGravitacije.TabIndex = 1;
            this.btnZakonGravitacije.Text = "Kalkulator zakona gravitacije";
            this.btnZakonGravitacije.UseVisualStyleBackColor = true;
            this.btnZakonGravitacije.Click += new System.EventHandler(this.btnZakonGravitacije_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnZakonGravitacije);
            this.Controls.Add(this.btnSilaTeze);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSilaTeze;
        private System.Windows.Forms.Button btnZakonGravitacije;
    }
}

