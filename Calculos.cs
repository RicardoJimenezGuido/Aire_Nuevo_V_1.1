using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace capaPresentacion
{
    public partial class Calculos : Form
    {



        public Calculos()
        {
            InitializeComponent();
        }


        int indice = 0, precio = 0;

        int indice1 = 0, precio1 = 0;

        int indice2 = 0, precio2 = 0;

        int indice3 = 0, precio3 = 0;


        private void Calculos_Load(object sender, EventArgs e)
        {

            //Vamos a inabiltar campo precio
            txt_Precio_Clausula.Enabled = false;

            // Cargar valore del Combobox
            cbo_Clausula_Contrato.Items.Add("Selecione un Item");
            cbo_Clausula_Contrato.Items.Add("Servicio a Domicilio");

            cbo_Clausula_Contrato.Items.Add("Varias Desinstalaciones");
            cbo_Clausula_Contrato.Items.Add("Reconexion");
            cbo_Clausula_Contrato.Items.Add("Mantenimiento de Carro");
            cbo_Clausula_Contrato.Items.Add("Fallo de Telemetria");


            // Seleccionar el primer elemento por defecto
            cbo_Clausula_Contrato.SelectedIndex = 0;


            ///////////////////////////////////////////////////////////////
            //Vamos a inabiltar campo precio
            txt_Valor_Servicios.Enabled = false;

            // Cargar valore del Combobox
            cbo_Servicios.Items.Add("Selecione un Item");
            cbo_Servicios.Items.Add("Venta de Emulador");
            cbo_Servicios.Items.Add("Cuerpo de Aceleracion");
            cbo_Servicios.Items.Add("Cambio de Bobinas");
            cbo_Servicios.Items.Add("Cambio de Bujias");
            cbo_Servicios.Items.Add("Cambio de Filtro");
            cbo_Servicios.Items.Add("Cambio de Vaporizador");


            // Seleccionar el primer elemento por defecto
            cbo_Servicios.SelectedIndex = 0;

            //////////////////////////////////////////////////////////////////////////////////


            //Vamos a inabiltar campo precio
            txt_Cilindraje.Enabled = false;

            // Cargar valore del Combobox
            //  cbo_Cilindraje.Items.Add("Selecione un Item");
            cbo_Cilindraje.Items.Add("700-1049 cc");
            cbo_Cilindraje.Items.Add("1050-1299 cc");
            cbo_Cilindraje.Items.Add("1300-2800 cc");



            // Seleccionar el primer elemento por defecto
            cbo_Cilindraje.SelectedIndex = 0;


            /////////////////////////////////////////////////////////////////////////////////////////
            //Vamos a inabiltar campo precio
            txt_Cilindraje_2.Enabled = false;

            // Cargar valore del Combobox
            //  cbo_Cilindraje.Items.Add("Selecione un Item");
            cbo_Cilindraje_2.Items.Add("700-1049 cc");
            cbo_Cilindraje_2.Items.Add("1050-1299 cc");
            cbo_Cilindraje_2.Items.Add("1300-2800 cc");



            // Seleccionar el primer elemento por defecto
            cbo_Cilindraje_2.SelectedIndex = 0;


        }




        private void cbo_Categoria_Uber_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            //txt_ACU.Text.Clear();

            txt_Cilindraje.Clear();
            txt_Kilometros.Clear();
            txt_Total.Clear();

            txt_Cilindraje_2.Clear();
            txt_Kilometros_2.Clear();
            txt_Total_2.Clear();

            txt_Valor_Servicios.Clear();
            txt_Cantidad_Servicios.Clear();
            txt_Total_Servicios.Clear();

            txt_Precio_Clausula.Clear();
            txt_Cantidad_Clausula.Clear();
            txt_Total_Clausula.Clear();

            txt_Uber_Total.Clear();
            txt_Sinpe_Total.Clear();
            txt_Abonos_Total.Clear();
            txt_Shortfall_Total.Clear();
            txt_Acreditado.Clear();

            txt_Pagos.Clear();


            txt_Suma_Calculos.Clear();




        }




        private void btn_Salir_Calculos_Click(object sender, EventArgs e)
        {


            // Menu ventana = new Menu();
            //ventana.Show();

            this.Hide();
            Close();
        }


        private void dgv_Calculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_ACU.Text = dgv_Calculos.CurrentRow.Cells[17].Value.ToString();
            //cbo_Kilometraje.Text = dgv_Calculos.CurrentRow.Cells[18].Value.ToString();

            //cbo_Categoria_1.Text = dgv_Calculos.CurrentRow.Cells[18].Value.ToString();
            //cbo_Cilindraje_1.Text = dgv_Calculos.CurrentRow.Cells[19].Value.ToString();
            //txt_Cilindraje_1.Text = dgv_Calculos.CurrentRow.Cells[20].Value.ToString();
            //txt_Kilometros_1.Text = dgv_Calculos.CurrentRow.Cells[21].Value.ToString();
            // txt_Total_1.Text = dgv_Calculos.CurrentRow.Cells[22].Value.ToString();
            cbo_Categoria_2.Text = dgv_Calculos.CurrentRow.Cells[18].Value.ToString();
            cbo_Cilindraje_2.Text = dgv_Calculos.CurrentRow.Cells[19].Value.ToString();
            txt_Cilindraje_2.Text = dgv_Calculos.CurrentRow.Cells[20].Value.ToString();
            txt_Kilometros_2.Text = dgv_Calculos.CurrentRow.Cells[21].Value.ToString();
            txt_Total_2.Text = dgv_Calculos.CurrentRow.Cells[22].Value.ToString();
            cbo_Servicios.Text = dgv_Calculos.CurrentRow.Cells[23].Value.ToString();
            txt_Valor_Servicios.Text = dgv_Calculos.CurrentRow.Cells[24].Value.ToString();
            txt_Cantidad_Servicios.Text = dgv_Calculos.CurrentRow.Cells[25].Value.ToString();
            txt_Total_Servicios.Text = dgv_Calculos.CurrentRow.Cells[26].Value.ToString();
            cbo_Clausula_Contrato.Text = dgv_Calculos.CurrentRow.Cells[27].Value.ToString();
            txt_Precio_Clausula.Text = dgv_Calculos.CurrentRow.Cells[28].Value.ToString();
            txt_Cantidad_Clausula.Text = dgv_Calculos.CurrentRow.Cells[29].Value.ToString();
            txt_Total_Clausula.Text = dgv_Calculos.CurrentRow.Cells[30].Value.ToString();
            txt_Uber_Total.Text = dgv_Calculos.CurrentRow.Cells[31].Value.ToString();
            txt_Sinpe_Total.Text = dgv_Calculos.CurrentRow.Cells[32].Value.ToString();
            txt_Abonos_Total.Text = dgv_Calculos.CurrentRow.Cells[33].Value.ToString();
            txt_Shortfall_Total.Text = dgv_Calculos.CurrentRow.Cells[34].Value.ToString();
            txt_Acreditado.Text = dgv_Calculos.CurrentRow.Cells[35].Value.ToString();
            txt_Pagos.Text = dgv_Calculos.CurrentRow.Cells[36].Value.ToString();
            //txt_GasLP.Text = dgv_Calculos.CurrentRow.Cells[37].Value.ToString();
           // txt_Suma_Calculos.Text = dgv_Calculos.CurrentRow.Cells[37].Value.ToString();

        }

        private void btn_Grabar_Calculos_Click(object sender, EventArgs e)
        {

            Conexion c7 = new Conexion();


            c7.cargarCalculos(dgv_Calculos);


              MessageBox.Show(c7.grabarCalculos(txt_ACU.Text, /*cbo_Categoria_1.Text, cbo_Cilindraje_1.Text, txt_Cilindraje_1.Text, txt_Kilometros_1.Text, txt_Total_1.Text,*/ cbo_Categoria.Text, cbo_Cilindraje.Text, txt_Cilindraje.Text, txt_Kilometros.Text, txt_Total.Text,
                cbo_Servicios.Text, txt_Valor_Servicios.Text, txt_Cantidad_Servicios.Text, txt_Total_Servicios.Text, cbo_Clausula_Contrato.Text, txt_Precio_Clausula.Text, txt_Cantidad_Clausula.Text, txt_Total_Clausula.Text,
                txt_Uber_Total.Text, txt_Sinpe_Total.Text, txt_Abonos_Total.Text, txt_Shortfall_Total.Text, txt_Acreditado.Text, txt_Pagos.Text, txt_Suma_Calculos.Text));
             c7.cargarCalculos(dgv_Calculos);


        

        }



        private void btn_Borrar_Click_1(object sender, EventArgs e)
        {

            Conexion c8 = new Conexion();

            MessageBox.Show(c8.eliminarCalculos(txt_ACU.Text));
            c8.cargarCalculos(dgv_Calculos);
        }

        private void txt_ACU_TextChanged(object sender, EventArgs e)
        {
            Conexion c8 = new Conexion();
            c8.cargarCalculos(dgv_Calculos, txt_ACU.Text);
        }

        private void btn_Exportar_Excel_Click(object sender, EventArgs e)
        {
            //Parte del nuevo codigo para exportar Excel
           // ExportarDatos.Datalistado();

           new Conexion().ExportarDataGridViewExcel(dgv_Calculos);
        }




        DataView ImportarDatos(String nombrearchivo)    //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties = 'Execel 12.0;'", nombrearchivo);
        {
            string Conexion = string.Format("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\Aire Nuevo\\Aire_Nuevo\\Excel Exportado\\Toño2.xls; Extended Properties = \"Excel 8.0; HDR=Yes\"");
            OleDbConnection conector = new OleDbConnection(Conexion);
            conector.Open();


            OleDbCommand consulta = new OleDbCommand("Select * from [Hoja1$]", conector);
            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta

            };
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            conector.Close();
            return ds.Tables[0].DefaultView;
        }

        private void btn_Total_Clausula_Click_1(object sender, EventArgs e)
        {

            int Precio, Cantidad, suma;

            // Verificar si los valores en los TextBox son números válidos
            if (int.TryParse(txt_Precio_Clausula.Text, out Precio) && int.TryParse(txt_Cantidad_Clausula.Text, out Cantidad))
            {
                // Realizar la suma de los números
                suma = Precio * Cantidad;

                // Mostrar el resultado en el TextBox correspondiente
                txt_Total_Clausula.Text = suma.ToString();
            }
            else
            {
                // Mostrar un mensaje de error si los valores en los TextBox no son números válidos
                MessageBox.Show("Por favor ingrese números válidos en los en el campo");
            }
        }

        private void btn_Total_Servicios_Click(object sender, EventArgs e)
        {

            int Precio1, Cantidad1, suma;

            // Verificar si los valores en los TextBox son números válidos
            if (int.TryParse(txt_Valor_Servicios.Text, out Precio1) && int.TryParse(txt_Cantidad_Servicios.Text, out Cantidad1))
            {
                // Realizar la suma de los números
                suma = Precio1 * Cantidad1;

                // Mostrar el resultado en el TextBox correspondiente
                txt_Total_Servicios.Text = suma.ToString();
            }
            else
            {
                // Mostrar un mensaje de error si los valores en los TextBox no son números válidos
                MessageBox.Show("Por favor ingrese números válidos en los en el campo");
            }

        }

        private void btn_Total_2_Click(object sender, EventArgs e)
        {

            Conexion c5 = new Conexion();

            int Cilindraje2, Kilometros2, suma3;

            // Verificar si los valores en los TextBox son números válidos
            if (int.TryParse(txt_Cilindraje_2.Text, out Cilindraje2) && int.TryParse(txt_Kilometros_2.Text, out Kilometros2))
            {
                // Realizar la suma de los números
                suma3 = Cilindraje2 * Kilometros2;

                // Mostrar el resultado en el TextBox correspondiente
                txt_Total_2.Text = suma3.ToString();
            }
            else
            {
                // Mostrar un mensaje de error si los valores en los TextBox no son números válidos
                MessageBox.Show("Por favor ingrese números válidos en los en el campo");
            }



        }

        private void cbo_Cilindraje_2_SelectedIndexChanged(object sender, EventArgs e)
        {

            indice3 = cbo_Cilindraje_2.SelectedIndex;
            switch (indice3)
            {
                case 1:
                    precio = 19;
                    break;

                case 2:
                    precio = 22;
                    break;
                case 3:
                    precio = 27;
                    break;

            }
            txt_Cilindraje_2.Text = precio.ToString();


        }

        private void btn_Total_Calculos_Click(object sender, EventArgs e)
        { 

        //Suma y resta pero necesita correccion de controles textbox con palabra total
        int suma = 0;

        // Recorremos todos los TextBox en la ventana
        foreach (Control control in this.Controls)
        {
            if (control is TextBox && control.Name.Contains("Total"))
            {
                // Intentamos convertir el contenido del TextBox a un entero
                int numero;
                if (int.TryParse(control.Text, out numero))
                {
                    // Si se pudo convertir a un entero, lo sumamos a la variable
                    suma += numero;
                }
            }
        }






        // Intentamos convertir el contenido del TextBox que contiene el valor a restar a un entero
       int valorARestar;
        if (int.TryParse(txt_Acreditado.Text, out valorARestar))
        {
            // Si se pudo convertir a un entero, restamos el valor
            suma -= valorARestar;
        }

        int valorARestar2;
        if (int.TryParse(txt_Pagos.Text, out valorARestar))
        {
            // Si se pudo convertir a un entero, restamos el valor
            suma -= valorARestar;
        }

        // Mostramos el resultado en el TextBox correspondiente
        txt_Suma_Calculos.Text = suma.ToString();




    }

        private void cbo_Cilindraje_1_SelectedIndexChanged(object sender, EventArgs e)
        {

            indice2 = cbo_Cilindraje.SelectedIndex;
            switch (indice2)
            {
                case 1:
                    precio = 19;
                    break;

                case 2:
                    precio = 22;
                    break;
                case 3:
                    precio = 27;
                    break;

            }
            txt_Cilindraje.Text = precio.ToString();


        }

        private void btn_Total_1_Click(object sender, EventArgs e)
        {


            Conexion c5 = new Conexion();


            int Cilindraje1, Kilometros1, suma2;

            // Verificar si los valores en los TextBox son números válidos
            if (int.TryParse(txt_Cilindraje.Text, out Cilindraje1) && int.TryParse(txt_Kilometros.Text, out Kilometros1))
            {
                // Realizar la suma de los números
                suma2 = Cilindraje1 * Kilometros1;

                // Mostrar el resultado en el TextBox correspondiente
                txt_Total.Text = suma2.ToString();
            }
            else
            {
                // Mostrar un mensaje de error si los valores en los TextBox no son números válidos
                MessageBox.Show("Por favor ingrese números válidos en los en el campo");
            }


        }

        private void btn_Excel1_Click(object sender, EventArgs e)
        {
            Excel pantalla = new Excel();
            this.Hide();
            pantalla.Show();
        }

        private void txt_ACU_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            Conexion c6 = new Conexion();

            c6.cargarCalculos(dgv_Calculos);



            if (c6.ACURegistrado(Convert.ToString(txt_ACU.Text)) == 0)
            {

                MessageBox.Show(c6.grabarCalculos(txt_ACU.Text, /*cbo_Categoria_1.Text, cbo_Cilindraje_1.Text, txt_Cilindraje_1.Text, txt_Kilometros_1.Text, txt_Total_1.Text,*/ cbo_Categoria.Text, cbo_Cilindraje.Text, txt_Cilindraje.Text, txt_Kilometros.Text, txt_Total.Text,
                cbo_Servicios.Text, txt_Valor_Servicios.Text, txt_Cantidad_Servicios.Text, txt_Total_Servicios.Text, cbo_Clausula_Contrato.Text, txt_Precio_Clausula.Text, txt_Cantidad_Clausula.Text, txt_Total_Clausula.Text,
                txt_Uber_Total.Text, txt_Sinpe_Total.Text, txt_Abonos_Total.Text, txt_Shortfall_Total.Text, txt_Acreditado.Text, txt_Pagos.Text, txt_Suma_Calculos.Text));
                c6.cargarCalculos(dgv_Calculos);
            }


            else
            {
                MessageBox.Show("Imposible registrar, el ACU ya existe");


            }
        }

        private void cbo_Cilindraje_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void cbo_Servicios_SelectedIndexChanged(object sender, EventArgs e)
        {

            indice = cbo_Servicios.SelectedIndex;
            switch (indice)
            {
                case 1:
                    precio = 65000;
                    break;

                case 2:
                    precio = 35000;
                    break;
                case 3:
                    precio = 2500;
                    break;
                case 4:
                    precio = 5000;
                    break;
                case 5:
                    precio = 2500;
                    break;

                case 6:
                    precio = 135000;
                    break;
            }
            txt_Valor_Servicios.Text = precio.ToString();


        }

        private void cbo_Clausula_Contrato_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            indice = cbo_Clausula_Contrato.SelectedIndex;
            switch (indice)
            {
                case 1:
                    precio = 20000;
                    break;

                case 2:
                    precio = 400 * 600;
                    break;
                case 3:
                    precio = 5000;
                    break;
                case 4:
                    precio = 10000;
                    break;
                case 5:
                    precio = 12500;
                    break;
            }
            txt_Precio_Clausula.Text = precio.ToString();

        }



        //Importar Excel
        private void btn_Importar_Excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
                Title = "Seleccionar Archivo"

            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dgv_Calculos.DataSource = ImportarDatos(openFileDialog.FileName);

            }
        }

       

    }
}












