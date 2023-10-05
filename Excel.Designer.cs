namespace capaPresentacion
{
    partial class Excel
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
            this.dgv_Excel = new System.Windows.Forms.DataGridView();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.txt_Ruta_Archivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Excel
            // 
            this.dgv_Excel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Excel.Location = new System.Drawing.Point(45, 77);
            this.dgv_Excel.Name = "dgv_Excel";
            this.dgv_Excel.Size = new System.Drawing.Size(696, 169);
            this.dgv_Excel.TabIndex = 0;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Location = new System.Drawing.Point(405, 35);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(75, 23);
            this.btn_Excel.TabIndex = 1;
            this.btn_Excel.Text = "Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(666, 268);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 2;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // txt_Ruta_Archivo
            // 
            this.txt_Ruta_Archivo.Location = new System.Drawing.Point(507, 37);
            this.txt_Ruta_Archivo.Name = "txt_Ruta_Archivo";
            this.txt_Ruta_Archivo.Size = new System.Drawing.Size(234, 20);
            this.txt_Ruta_Archivo.TabIndex = 8;
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 306);
            this.Controls.Add(this.txt_Ruta_Archivo);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.dgv_Excel);
            this.Name = "Excel";
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Excel;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox txt_Ruta_Archivo;
    }
}