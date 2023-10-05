using System.Data.SqlClient;
using System;
using System.Windows.Forms;


namespace capaPresentacion
{
    public partial class Form1 : Form 
    {
       

        public Form1()
        {
           

            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion cc = new Conexion(); 
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            Conexion cc1 = new Conexion();

            MessageBox.Show(cc1.insertarUsuario(txt_Correo.Text, txt_Contraseña.Text));

        }


        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-E63H3AV\\SQLEXPRESS;Initial Catalog=Aire_Nuevo;Integrated Security=True");
       

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            
       
            cn.Open();
            SqlCommand comando = new SqlCommand("SELECT Correo, Contraseña FROM Usuario WHERE Correo = @vcorreo AND Contraseña = @vcontraseña ", cn);
                comando.Parameters.AddWithValue("@vcorreo",txt_Correo.Text);
                comando.Parameters.AddWithValue("@vcontraseña", txt_Contraseña.Text);

            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read()) 
            {
                cn.Close();
                Sistema pantalla = new Sistema();
                pantalla.Show();
            
            }


            



        }
      }
    }








