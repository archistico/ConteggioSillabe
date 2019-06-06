namespace ConteggioSillabe
{
    partial class frmPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipale));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btCalcola = new System.Windows.Forms.Button();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(12, 12);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(653, 228);
            this.tbInput.TabIndex = 0;
            this.tbInput.Text = resources.GetString("tbInput.Text");
            // 
            // btCalcola
            // 
            this.btCalcola.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcola.Location = new System.Drawing.Point(12, 246);
            this.btCalcola.Name = "btCalcola";
            this.btCalcola.Size = new System.Drawing.Size(653, 48);
            this.btCalcola.TabIndex = 1;
            this.btCalcola.Text = "CALCOLA NUMERO SILLABE";
            this.btCalcola.UseVisualStyleBackColor = true;
            this.btCalcola.Click += new System.EventHandler(this.btCalcola_Click);
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(12, 300);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(653, 259);
            this.tbOutput.TabIndex = 2;
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 571);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.btCalcola);
            this.Controls.Add(this.tbInput);
            this.Name = "frmPrincipale";
            this.Text = "Calcola sillabe - Studio Archistico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btCalcola;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

