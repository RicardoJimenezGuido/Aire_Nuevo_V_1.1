namespace capaPresentacion
{
    partial class Sistema
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
            this.components = new System.ComponentModel.Container();
            this.btn_Salir_Sistema = new System.Windows.Forms.Button();
            this.lbl_ID_Cliente = new System.Windows.Forms.Label();
            this.lbl_ACU = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Dirección = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.txt_ID_Cliente = new System.Windows.Forms.TextBox();
            this.txt_ACU = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.aireNuevoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aire_NuevoDataSet = new capaPresentacion.Aire_NuevoDataSet();
            this.btn_Grabar_Sistema = new System.Windows.Forms.Button();
            this.btn_Borrar_Sistema = new System.Windows.Forms.Button();
            this.btn_Exportar_Excel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Placa = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.txt_Cilindraje = new System.Windows.Forms.TextBox();
            this.txt_Kilometraje = new System.Windows.Forms.TextBox();
            this.lbl_Placa = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Modelo = new System.Windows.Forms.Label();
            this.lbl_Cilindraje = new System.Windows.Forms.Label();
            this.lbl_Kilometraje = new System.Windows.Forms.Label();
            this.lbl_Año = new System.Windows.Forms.Label();
            this.txt_Año = new System.Windows.Forms.TextBox();
            this.btn_Importar_Excel = new System.Windows.Forms.Button();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aireNuevoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aire_NuevoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir_Sistema
            // 
            this.btn_Salir_Sistema.Location = new System.Drawing.Point(679, 526);
            this.btn_Salir_Sistema.Name = "btn_Salir_Sistema";
            this.btn_Salir_Sistema.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir_Sistema.TabIndex = 0;
            this.btn_Salir_Sistema.Text = "Salir";
            this.btn_Salir_Sistema.UseVisualStyleBackColor = true;
            this.btn_Salir_Sistema.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // lbl_ID_Cliente
            // 
            this.lbl_ID_Cliente.AutoSize = true;
            this.lbl_ID_Cliente.Location = new System.Drawing.Point(31, 33);
            this.lbl_ID_Cliente.Name = "lbl_ID_Cliente";
            this.lbl_ID_Cliente.Size = new System.Drawing.Size(40, 13);
            this.lbl_ID_Cliente.TabIndex = 1;
            this.lbl_ID_Cliente.Text = "Cédula";
            // 
            // lbl_ACU
            // 
            this.lbl_ACU.AutoSize = true;
            this.lbl_ACU.Location = new System.Drawing.Point(31, 70);
            this.lbl_ACU.Name = "lbl_ACU";
            this.lbl_ACU.Size = new System.Drawing.Size(29, 13);
            this.lbl_ACU.TabIndex = 2;
            this.lbl_ACU.Text = "ACU";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(31, 102);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(31, 135);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(49, 13);
            this.lbl_Apellidos.TabIndex = 4;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(31, 168);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 5;
            this.lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_Dirección
            // 
            this.lbl_Dirección.AutoSize = true;
            this.lbl_Dirección.Location = new System.Drawing.Point(31, 209);
            this.lbl_Dirección.Name = "lbl_Dirección";
            this.lbl_Dirección.Size = new System.Drawing.Size(52, 13);
            this.lbl_Dirección.TabIndex = 6;
            this.lbl_Dirección.Text = "Dirección";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(31, 245);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 7;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Location = new System.Drawing.Point(31, 281);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(38, 13);
            this.lbl_Correo.TabIndex = 8;
            this.lbl_Correo.Text = "Correo";
            // 
            // txt_ID_Cliente
            // 
            this.txt_ID_Cliente.Location = new System.Drawing.Point(107, 30);
            this.txt_ID_Cliente.Name = "txt_ID_Cliente";
            this.txt_ID_Cliente.Size = new System.Drawing.Size(172, 20);
            this.txt_ID_Cliente.TabIndex = 9;
            // 
            // txt_ACU
            // 
            this.txt_ACU.Location = new System.Drawing.Point(107, 63);
            this.txt_ACU.Name = "txt_ACU";
            this.txt_ACU.Size = new System.Drawing.Size(172, 20);
            this.txt_ACU.TabIndex = 10;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(107, 99);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(172, 20);
            this.txt_Nombre.TabIndex = 11;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Location = new System.Drawing.Point(107, 132);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(172, 20);
            this.txt_Apellidos.TabIndex = 12;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(107, 165);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(172, 20);
            this.txt_Telefono.TabIndex = 13;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(107, 206);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(172, 20);
            this.txt_Direccion.TabIndex = 14;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(107, 278);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(172, 20);
            this.txt_Correo.TabIndex = 16;
            // 
            // aireNuevoDataSetBindingSource
            // 
            this.aireNuevoDataSetBindingSource.DataSource = this.aire_NuevoDataSet;
            this.aireNuevoDataSetBindingSource.Position = 0;
            // 
            // aire_NuevoDataSet
            // 
            this.aire_NuevoDataSet.DataSetName = "Aire_NuevoDataSet";
            this.aire_NuevoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Grabar_Sistema
            // 
            this.btn_Grabar_Sistema.Location = new System.Drawing.Point(663, 33);
            this.btn_Grabar_Sistema.Name = "btn_Grabar_Sistema";
            this.btn_Grabar_Sistema.Size = new System.Drawing.Size(75, 23);
            this.btn_Grabar_Sistema.TabIndex = 18;
            this.btn_Grabar_Sistema.Text = "Grabar";
            this.btn_Grabar_Sistema.UseVisualStyleBackColor = true;
            this.btn_Grabar_Sistema.Click += new System.EventHandler(this.btn_Grabar_Click);
            // 
            // btn_Borrar_Sistema
            // 
            this.btn_Borrar_Sistema.Location = new System.Drawing.Point(663, 83);
            this.btn_Borrar_Sistema.Name = "btn_Borrar_Sistema";
            this.btn_Borrar_Sistema.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar_Sistema.TabIndex = 20;
            this.btn_Borrar_Sistema.Text = "Borrar";
            this.btn_Borrar_Sistema.UseVisualStyleBackColor = true;
            this.btn_Borrar_Sistema.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Exportar_Excel
            // 
            this.btn_Exportar_Excel.Location = new System.Drawing.Point(209, 526);
            this.btn_Exportar_Excel.Name = "btn_Exportar_Excel";
            this.btn_Exportar_Excel.Size = new System.Drawing.Size(103, 23);
            this.btn_Exportar_Excel.TabIndex = 21;
            this.btn_Exportar_Excel.Text = "Exportar Excel";
            this.btn_Exportar_Excel.UseVisualStyleBackColor = true;
            this.btn_Exportar_Excel.Click += new System.EventHandler(this.btn_Exportar_Excel_Click);
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Cliente,
            this.ACU,
            this.Nombre,
            this.Apellidos,
            this.Telefono,
            this.Direccion,
            this.Fecha,
            this.Correo});
            this.dgv_Cliente.Location = new System.Drawing.Point(34, 337);
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.Size = new System.Drawing.Size(720, 166);
            this.dgv_Cliente.TabIndex = 23;
            this.dgv_Cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Cliente_CellClick);
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "Cédula";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.Visible = false;
            // 
            // ACU
            // 
            this.ACU.HeaderText = "ACU";
            this.ACU.Name = "ACU";
            this.ACU.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = false;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Visible = false;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Visible = false;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.Visible = false;
            // 
            // txt_Placa
            // 
            this.txt_Placa.Location = new System.Drawing.Point(415, 30);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(172, 20);
            this.txt_Placa.TabIndex = 24;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(415, 67);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(172, 20);
            this.txt_Marca.TabIndex = 25;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(415, 99);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(172, 20);
            this.txt_Modelo.TabIndex = 26;
            // 
            // txt_Cilindraje
            // 
            this.txt_Cilindraje.Location = new System.Drawing.Point(415, 171);
            this.txt_Cilindraje.Name = "txt_Cilindraje";
            this.txt_Cilindraje.Size = new System.Drawing.Size(172, 20);
            this.txt_Cilindraje.TabIndex = 27;
            // 
            // txt_Kilometraje
            // 
            this.txt_Kilometraje.Location = new System.Drawing.Point(415, 206);
            this.txt_Kilometraje.Name = "txt_Kilometraje";
            this.txt_Kilometraje.Size = new System.Drawing.Size(172, 20);
            this.txt_Kilometraje.TabIndex = 28;
            // 
            // lbl_Placa
            // 
            this.lbl_Placa.AutoSize = true;
            this.lbl_Placa.Location = new System.Drawing.Point(339, 33);
            this.lbl_Placa.Name = "lbl_Placa";
            this.lbl_Placa.Size = new System.Drawing.Size(34, 13);
            this.lbl_Placa.TabIndex = 29;
            this.lbl_Placa.Text = "Placa";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(339, 70);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marca.TabIndex = 30;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_Modelo
            // 
            this.lbl_Modelo.AutoSize = true;
            this.lbl_Modelo.Location = new System.Drawing.Point(339, 106);
            this.lbl_Modelo.Name = "lbl_Modelo";
            this.lbl_Modelo.Size = new System.Drawing.Size(42, 13);
            this.lbl_Modelo.TabIndex = 31;
            this.lbl_Modelo.Text = "Modelo";
            // 
            // lbl_Cilindraje
            // 
            this.lbl_Cilindraje.AutoSize = true;
            this.lbl_Cilindraje.Location = new System.Drawing.Point(339, 174);
            this.lbl_Cilindraje.Name = "lbl_Cilindraje";
            this.lbl_Cilindraje.Size = new System.Drawing.Size(49, 13);
            this.lbl_Cilindraje.TabIndex = 32;
            this.lbl_Cilindraje.Text = "Cilindraje";
            // 
            // lbl_Kilometraje
            // 
            this.lbl_Kilometraje.AutoSize = true;
            this.lbl_Kilometraje.Location = new System.Drawing.Point(339, 209);
            this.lbl_Kilometraje.Name = "lbl_Kilometraje";
            this.lbl_Kilometraje.Size = new System.Drawing.Size(58, 13);
            this.lbl_Kilometraje.TabIndex = 33;
            this.lbl_Kilometraje.Text = "Kilometraje";
            // 
            // lbl_Año
            // 
            this.lbl_Año.AutoSize = true;
            this.lbl_Año.Location = new System.Drawing.Point(339, 140);
            this.lbl_Año.Name = "lbl_Año";
            this.lbl_Año.Size = new System.Drawing.Size(26, 13);
            this.lbl_Año.TabIndex = 35;
            this.lbl_Año.Text = "Año";
            // 
            // txt_Año
            // 
            this.txt_Año.Location = new System.Drawing.Point(415, 137);
            this.txt_Año.Name = "txt_Año";
            this.txt_Año.Size = new System.Drawing.Size(172, 20);
            this.txt_Año.TabIndex = 34;
            // 
            // btn_Importar_Excel
            // 
            this.btn_Importar_Excel.Location = new System.Drawing.Point(34, 526);
            this.btn_Importar_Excel.Name = "btn_Importar_Excel";
            this.btn_Importar_Excel.Size = new System.Drawing.Size(103, 23);
            this.btn_Importar_Excel.TabIndex = 36;
            this.btn_Importar_Excel.Text = "Importar Excel";
            this.btn_Importar_Excel.UseVisualStyleBackColor = true;
            this.btn_Importar_Excel.Click += new System.EventHandler(this.btn_Importar_Excel_Click);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(565, 526);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 38;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(107, 245);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(172, 20);
            this.txt_Fecha.TabIndex = 40;
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.btn_Importar_Excel);
            this.Controls.Add(this.lbl_Año);
            this.Controls.Add(this.txt_Año);
            this.Controls.Add(this.lbl_Kilometraje);
            this.Controls.Add(this.lbl_Cilindraje);
            this.Controls.Add(this.lbl_Modelo);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.lbl_Placa);
            this.Controls.Add(this.txt_Kilometraje);
            this.Controls.Add(this.txt_Cilindraje);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.txt_Placa);
            this.Controls.Add(this.dgv_Cliente);
            this.Controls.Add(this.btn_Exportar_Excel);
            this.Controls.Add(this.btn_Borrar_Sistema);
            this.Controls.Add(this.btn_Grabar_Sistema);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_ACU);
            this.Controls.Add(this.txt_ID_Cliente);
            this.Controls.Add(this.lbl_Correo);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.lbl_Dirección);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Apellidos);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_ACU);
            this.Controls.Add(this.lbl_ID_Cliente);
            this.Controls.Add(this.btn_Salir_Sistema);
            this.Name = "Sistema";
            this.Text = "Sistema";
            this.Load += new System.EventHandler(this.Sistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aireNuevoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aire_NuevoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Salir_Sistema;
        private System.Windows.Forms.Label lbl_ID_Cliente;
        private System.Windows.Forms.Label lbl_ACU;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Dirección;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.TextBox txt_ID_Cliente;
        private System.Windows.Forms.TextBox txt_ACU;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Button btn_Grabar_Sistema;
        private System.Windows.Forms.Button btn_Borrar_Sistema;
        private System.Windows.Forms.Button btn_Exportar_Excel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource aireNuevoDataSetBindingSource;
        private Aire_NuevoDataSet aire_NuevoDataSet;
        private System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.TextBox txt_Placa;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.TextBox txt_Cilindraje;
        private System.Windows.Forms.TextBox txt_Kilometraje;
        private System.Windows.Forms.Label lbl_Placa;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Modelo;
        private System.Windows.Forms.Label lbl_Cilindraje;
        private System.Windows.Forms.Label lbl_Kilometraje;
        private System.Windows.Forms.Label lbl_Año;
        private System.Windows.Forms.TextBox txt_Año;
        private System.Windows.Forms.Button btn_Importar_Excel;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_Fecha;
    }
}