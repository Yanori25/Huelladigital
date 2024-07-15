namespace HuellaMediweb
{
    partial class FrmRegistrar
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txthuella = new System.Windows.Forms.TextBox();
            this.btnhuella = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.dgvhuellas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhuellas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Huella";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(163, 80);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(247, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // txthuella
            // 
            this.txthuella.Location = new System.Drawing.Point(163, 148);
            this.txthuella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthuella.Name = "txthuella";
            this.txthuella.Size = new System.Drawing.Size(247, 22);
            this.txthuella.TabIndex = 3;
            // 
            // btnhuella
            // 
            this.btnhuella.Location = new System.Drawing.Point(419, 145);
            this.btnhuella.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhuella.Name = "btnhuella";
            this.btnhuella.Size = new System.Drawing.Size(100, 28);
            this.btnhuella.TabIndex = 4;
            this.btnhuella.Text = "Registrar";
            this.btnhuella.UseVisualStyleBackColor = true;
            this.btnhuella.Click += new System.EventHandler(this.btnhuella_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Enabled = false;
            this.btnagregar.Location = new System.Drawing.Point(163, 193);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 28);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // dgvhuellas
            // 
            this.dgvhuellas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhuellas.Location = new System.Drawing.Point(23, 273);
            this.dgvhuellas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvhuellas.Name = "dgvhuellas";
            this.dgvhuellas.RowHeadersWidth = 51;
            this.dgvhuellas.Size = new System.Drawing.Size(508, 185);
            this.dgvhuellas.TabIndex = 6;
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 473);
            this.Controls.Add(this.dgvhuellas);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnhuella);
            this.Controls.Add(this.txthuella);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRegistrar";
            this.Text = "FrmRegistrar";
            this.Load += new System.EventHandler(this.FrmRegistrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhuellas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txthuella;
        private System.Windows.Forms.Button btnhuella;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.DataGridView dgvhuellas;
    }
}