namespace HuellaMediweb
{
    partial class frmMain
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnverificar = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(123, 42);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(295, 28);
            this.btnregistrar.TabIndex = 0;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(123, 101);
            this.btnverificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(295, 28);
            this.btnverificar.TabIndex = 1;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(463, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(426, 146);
            this.webBrowser1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 170);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.btnregistrar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Huella Medi Web";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

