using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Security.Cryptography.X509Certificates;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Reflection;
using System.Text.RegularExpressions;
using capaPresentacion.Aire_NuevoDataSetTableAdapters;

namespace capaPresentacion
{
    public partial class Sistema : Form
    {
        Conexion c = new Conexion();

        public Sistema()
        {
            InitializeComponent();
        }



        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-E63H3AV\\SQLEXPRESS;Initial Catalog=Aire_Nuevo;Integrated Security=True");

        private void Sistema_Load(object sender, EventArgs e)
        {
            Conexion c1 = new Conexion();

            c1.cargarCliente(dgv_Cliente);

            dgv_Cliente.AllowUserToAddRows = false;


        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();

        }

        private void btn_Grabar_Click(object sender, EventArgs e)
        {
            Conexion c2 = new Conexion();

            c2.cargarCliente(dgv_Cliente);



            if (c2.clienteRegistrado(txt_ID_Cliente.Text) == 0)
            {

                MessageBox.Show(c2.insertarCliente(txt_ID_Cliente.Text, txt_ACU.Text, txt_Nombre.Text, txt_Apellidos.Text, txt_Telefono.Text, txt_Direccion.Text, txt_Fecha.Text, txt_Correo.Text, txt_Placa.Text, txt_Marca.Text, txt_Modelo.Text, txt_Año.Text, txt_Cilindraje.Text, txt_Kilometraje.Text));
                //c2.cargarCliente(dgv_Cliente);
            }
            else
            {
                MessageBox.Show("Imposible registrar, el cliente ya existe");


            }


        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            Conexion c3 = new Conexion();

            MessageBox.Show(c3.eliminarCliente(txt_ID_Cliente.Text));
            c3.cargarCliente(dgv_Cliente);
        }

        private void txt_ID_Cliente_TextChanged(object sender, EventArgs e)
        {
            Conexion c4 = new Conexion();
            c4.cargarCliente(dgv_Cliente, txt_ID_Cliente.Text);
        }

        


        DataView ImportarDatos(String nombrearchivo)    //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = {0}; Extended Properties = 'Execel 12.0;'", nombrearchivo);
        {
            string Conexion = string.Format("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = E:\\Aire Nuevo\\Aire_Nuevo\\Excel Exportado\\Toño3.xls; Extended Properties = \"Excel 8.0; HDR=Yes\"");
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


        //Revisar falla 
        // private void btn_Excel_Click(object sender, EventArgs e)
        private void btn_Importar_Excel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel | *.xls;*.xlsx;",
                Title = "Seleccionar Archivo"

            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dgv_Cliente.DataSource = ImportarDatos(openFileDialog.FileName);

            }
        }



        private void btn_Exportar_Excel_Click(object sender, EventArgs e)
        {

            new Conexion().ExportarDataGridViewExcel(dgv_Cliente);

        }



        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Calculos pantalla = new Calculos();
            this.Hide();
            pantalla.Show();

        }



        private void dgv_Cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
              txt_ID_Cliente.Text = dgv_Cliente.CurrentRow.Cells[9].Value.ToString();
              txt_ACU.Text = dgv_Cliente.CurrentRow.Cells[10].Value.ToString();
              txt_Nombre.Text = dgv_Cliente.CurrentRow.Cells[11].Value.ToString();
              txt_Apellidos.Text = dgv_Cliente.CurrentRow.Cells[12].Value.ToString();
              txt_Telefono.Text = dgv_Cliente.CurrentRow.Cells[13].Value.ToString();
              txt_Direccion.Text = dgv_Cliente.CurrentRow.Cells[14].Value.ToString();
              txt_Fecha.Text = dgv_Cliente.CurrentRow.Cells[15].Value.ToString();
              txt_Correo.Text = dgv_Cliente.CurrentRow.Cells[16].Value.ToString();
              txt_Placa.Text = dgv_Cliente.CurrentRow.Cells[17].Value.ToString();
              txt_Marca.Text = dgv_Cliente.CurrentRow.Cells[18].Value.ToString();
              txt_Modelo.Text = dgv_Cliente.CurrentRow.Cells[19].Value.ToString();
              txt_Año.Text = dgv_Cliente.CurrentRow.Cells[20].Value.ToString();
              txt_Cilindraje.Text = dgv_Cliente.CurrentRow.Cells[21].Value.ToString();
              //txt_Kilometraje.Text = dgv_Cliente.CurrentRow.Cells[22].Value.ToString();

            //, txt_Nombre.Text, txt_Apellidos.Text, Convert.ToInt32(txt_Telefono.Text), txt_Direccion.Text, Convert.ToInt32(txt_Fecha.Text), txt_Correo.Text, txt_Placa.Text, txt_Marca.Text, txt_Modelo.Text, Convert.ToInt32(txt_Año.Text), txt_Cilindraje.Text, txt_Kilometraje.Text

        }


    }
}

    


    
        
    


