using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

class Conexion
{
    SqlConnection cn;
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataAdapter da;
    DataTable dt;
    DataSet ds;

    //Conexion con la Base de Datos SQL Server
    public Conexion()
    {
        try
        {
            cn = new SqlConnection("Data Source=DESKTOP-E63H3AV\\SQLEXPRESS;Initial Catalog=Aire_Nuevo;Integrated Security=True");
            cn.Open();
            //MessageBox.Show("Conectado");
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
        }
    }


    //Registro del correo electronico y la contraseña
    public string insertarUsuario(string Correo, string Contraseña)
    {
        string salida = "Correo electrónico y contraseña se registraron correctamente en la Base de Datos";
        try
        {
            cmd = new SqlCommand("Insert into Usuario(Correo,Contraseña) values ('" + Correo + "','" + Contraseña + "')", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se conecto: " + ex.ToString();
        }
        return salida;
    }


    //Consulta del correo electronico y la contraseña almacenada en la Base de Datos
    public string consultarUsuario(string Correo, string Contraseña)
    {
        string salida = "Correo electrónico y contraseña correctos";
        try
        {
            cmd = new SqlCommand("Select  *  from Usuario", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                salida += dr["Correo"].ToString();
                salida += dr["Contraseña"].ToString();
            }
            dr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se realizó la consulta: " + ex.ToString());
        }
        return salida;
    }


    //Registro de un Cliente
    public string insertarCliente(string ID_Cliente, string ACU, string Nombre, string Apellidos, string Telefono, string Direccion, string Fecha, string Correo, string Placa, string Marca, string Modelo, string Año, string Cilindraje, string Kilometraje)
    {
        string salida = "Cliente se grabo correctamente en la Base de Datos";
        try
        {
            cmd = new SqlCommand("Insert into Cliente(ID_Cliente,ACU,Nombre,Apellidos,Telefono,Direccion,Fecha,Correo,Placa,Marca,Modelo,Año,Cilindraje, Kilometraje) values (" + ID_Cliente + ",'" + ACU + "','" + Nombre + "','" + Apellidos + "', '" + Telefono + "', '" + Direccion + "','" + Fecha + "','" + Correo + "','" + Placa + "', '" + Marca + "', '" + Modelo + "', '" + Año + "', '" + Cilindraje + "', '" + Kilometraje + "')", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se conecto: " + ex.ToString();
        }
        return salida;
    }


    //Consulta por medio de la Cédula (ID-Cliente), si el Cliente ya se encuentra en la Base de Datos
    public int clienteRegistrado(string ID_Cliente)
    {

        int contador = 0;

        try
        {
            cmd = new SqlCommand("SELECT * FROM Cliente WHERE ID_Cliente = " + ID_Cliente + "", cn);
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                contador++;
            }
            dr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se consulto el Cliente: " + ex.ToString());
        }

        return contador;
    }


    //Eliminar un Cliente de la Base de Datos por su numero de Cédula (ID_Cliente)
    public string eliminarCliente(string ID_Cliente)
    {
        string salida = "Se elimino correctamente el Cliente con el numero de Cédula: " + ID_Cliente;
        try
        {
            cmd = new SqlCommand("Delete Cliente from Cliente Where ID_Cliente=" + ID_Cliente + "", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se eliminó el registro: " + ex.ToString();
        }
        return salida;
    }

    public void cargarCliente(DataGridView tabla)
    {
        try
        {

            da = new SqlDataAdapter("Select  *  from Cliente", cn);
            ds = new DataSet();
            da.Fill(ds, "Cliente");
            tabla.DataSource = ds.Tables["Cliente"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se consulto la informacion: " + ex.ToString());
        }
    }

    public void cargarCliente(DataGridView tabla, string ID_Cliente)
    {
        try
        {
            da = new SqlDataAdapter("Select  *  from Cliente Where ID_Cliente like '" + "%" + ID_Cliente + "%" + "'", cn);
            ds = new DataSet();
            da.Fill(ds, "Cliente");
            tabla.DataSource = ds.Tables["Cliente"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se actualizó el registro: " + ex.ToString());
        }
    }


    //Exportar datas a Excel
   public void ExportarDataGridViewExcel(DataGridView dgv_Cliente)
    {
        try
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            fichero.FileName = "Archivo exportado";
            if (fichero.ShowDialog() == DialogResult.OK)
            {

                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //Recorremos Datagridview rellenando la hoja de trabajo
                for (int i = 0; i < dgv_Cliente.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_Cliente.Columns.Count; j++)
                    {
                        if ((dgv_Cliente.Rows[i].Cells[j].Value == null) == false)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = dgv_Cliente.Rows[i].Cells[j].Value.ToString();
                        }



                    }



                }

                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());

        }


    }


  /*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

    //Modulo de Calculos


    public int ACURegistrado(string ACU)
    {

        int contador = 0;

        try
        {
            cmd = new SqlCommand("SELECT * FROM Calculos WHERE ACU = " + ACU + "", cn);
            dr = cmd.ExecuteReader();


            while (dr.Read())
            {

                contador++;
            }
            dr.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se consulto el ACU: " + ex.ToString());
        }

        return contador;
    }


    public void cargarCalculos(DataGridView tabla)
    {
        try
        {

            da = new SqlDataAdapter("Select  *  from Calculos", cn);
            ds = new DataSet();
            da.Fill(ds, "Calculos");
            tabla.DataSource = ds.Tables["Calculos"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se consulto la informacion: " + ex.ToString());
        }
    }


    public void cargarCalculos(DataGridView tabla, string ACU)
    {
        try
        {
            da = new SqlDataAdapter("Select  *  from Calculos Where ACU  like '" + "%" +  ACU + "%" + "'", cn);
            ds = new DataSet();
            da.Fill(ds, "Calculos");
            tabla.DataSource = ds.Tables["Calculos"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se actualizó el registro: " + ex.ToString());
        }
    }


    public string grabarCalculos(string ACU, /*string Categoria_Uber1, string Cilindraje1, string Precio_Cilindraje1, string Kilometros1, string Total_Categoria_Uber1,*/ string Categoria_Uber, string Cilindraje, string Precio_Cilindraje, string Kilometros, string Total_Categoria_Uber, string Servicios, string Precio_Servicios, string Cantidad_Servicios, string Total_Servicios, string Clausula_Contrato, string Precio_Clausula, string Cantidad_Clausula, string Total_Clausula, string Pago_Uber, string Sinpe, string Abonos, string Shortfall, string Acreditado, string Pagos, string Total_Calculos)
    {
        string salida = "";
        try
        {
            //Categoria_Uber1,Cilindraje1,Precio_Cilindraje1,Kilometros1,Total_Categoria_Uber1,                                                                                                                                                                                                                                                                                '" + @Categoria_Uber1 + "','" + @Cilindraje1 + "','" + @Precio_Cilindraje1 + "','" + @Kilometros1 + "','" + @Total_Categoria_Uber1 + "',
            cmd = new SqlCommand("Insert into Calculos(ACU,Categoria_Uber,Cilindraje,Precio_Cilindraje,Kilometros,Total_Categoria_Uber,Servicios,Precio_Servicios,Cantidad_Servicios,Total_Servicios,Clausula_Contrato,Precio_Clausula,Cantidad_Clausula,Total_Clausula,Pago_Uber,Sinpe,Abonos,Shortfall,Acreditado, Pagos, Total_Calculos) values ('" + ACU + "',  '" + Categoria_Uber + "','" + Cilindraje + "','" + Precio_Cilindraje + "','" + Kilometros + "','" + Total_Categoria_Uber + "','" + Servicios + "','" + Precio_Servicios + "','" + Cantidad_Servicios + "','" + Total_Servicios + "','" + Clausula_Contrato + "','" + Precio_Clausula + "','" + Cantidad_Clausula + "','" + Total_Clausula + "','" + Pago_Uber + "','" + Sinpe + "','" + Abonos + "','" + Shortfall + "','" + Acreditado + "','" + Pagos + "','" + Total_Calculos + "')", cn);
            cmd.ExecuteNonQuery();                                                                                      
        }
        catch (Exception ex)
        {
            salida = "No se conecto: " + ex.ToString();
        }
        return salida;
    }

    

    //Eliminar un Calculos de la Base de Datos por su numero de ACU 
    public string eliminarCalculos(string ACU)
    {
        string salida = "";
        try
        {
            cmd = new SqlCommand("Delete Calculos from Calculos Where ACU='" + ACU + "'", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se eliminó el registro: " + ex.ToString();
        }
        return salida;
    }


    //Exportar datas a Excel
    public void Exportar1DataGridViewExcel(DataGridView dgv_Calculos)
    {
        try
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            fichero.FileName = "Archivo exportado";
            if (fichero.ShowDialog() == DialogResult.OK)
            {

                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;

                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                //Recorremos Datagridview rellenando la hoja de trabajo
                for (int i = 0; i < dgv_Calculos.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgv_Calculos.Columns.Count; j++)
                    {
                        if ((dgv_Calculos.Rows[i].Cells[j].Value == null) == false)
                        {
                            hoja_trabajo.Cells[i + 1, j + 1] = dgv_Calculos.Rows[i].Cells[j].Value.ToString();
                        }



                    }


                }

                libros_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al exportar la informacion debido a: " + ex.ToString());

        }


    }




}








