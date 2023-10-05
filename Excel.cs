using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Excel : Form
    {
        public Excel()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Close();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {

            //Probado funcionando, suma 4 columnas diferentes de 4 hojas diferentes, coloca las 4 columnas y el resultado en datagridview y exporta datagridview a un Excel
            // Crear un cuadro de diálogo para seleccionar el archivo Excel
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de Excel|.xlsx;.xls";
            openFileDialog1.Title = "Seleccione el archivo Excel";

            // Si se selecciona un archivo, cargarlo en el datagridview
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_Ruta_Archivo.Text = openFileDialog1.FileName;
                // Crear una instancia de Excel y abrir el archivo seleccionado
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = excel.Workbooks.Open(openFileDialog1.FileName);

                // Obtener las hojas de Excel que contienen las columnas que deseamos sumar
                Worksheet worksheet1 = workbook.Sheets["A"];
                Worksheet worksheet2 = workbook.Sheets["B"];
                Worksheet worksheet3 = workbook.Sheets["C"];
                Worksheet worksheet4 = workbook.Sheets["D"];

                // Leer los datos de las columnas en cada hoja
                Range range1 = worksheet1.UsedRange.Columns[1];
                Range range2 = worksheet2.UsedRange.Columns[1];
                Range range3 = worksheet3.UsedRange.Columns[1];
                Range range4 = worksheet4.UsedRange.Columns[1];

                // Crear una lista de tuplas que contienen los datos de cada columna
                List<Tuple<int, int, int, int>> data = new List<Tuple<int, int, int, int>>();
                for (int i = 1; i <= range1.Rows.Count; i++)
                {
                    int value1 = 0;
                    if (range1.Cells[i, 1].Value2 != null)
                    {
                        value1 = (int)(range1.Cells[i, 1] as Range).Value2;
                    }

                    int value2 = 0;
                    if (range2.Cells[i, 1].Value2 != null)
                    {
                        value2 = (int)(range2.Cells[i, 1] as Range).Value2;
                    }

                    int value3 = 0;
                    if (range3.Cells[i, 1].Value2 != null)
                    {
                        value3 = (int)(range3.Cells[i, 1] as Range).Value2;
                    }

                    int value4 = 0;
                    if (range4.Cells[i, 1].Value2 != null)
                    {
                        value4 = (int)(range4.Cells[i, 1] as Range).Value2;
                    }
                    data.Add(new Tuple<int, int, int, int>(value1, value2, value3, value4));
                }

                // Sumar los valores de cada columna y agregar una quinta columna con el resultado
                List<Tuple<int, int, int, int, int>> result = new List<Tuple<int, int, int, int, int>>();
                foreach (Tuple<int, int, int, int> row in data)
                {
                    int sum = row.Item1 + row.Item2 + row.Item3 + row.Item4;
                    result.Add(new Tuple<int, int, int, int, int>(row.Item1, row.Item2, row.Item3, row.Item4, sum));
                }

                // Mostrar los datos en el datagridview
                dgv_Excel.DataSource = result;
                dgv_Excel.AutoResizeColumns();

                // Exportar los datos a un nuevo archivo Excel
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Archivos de Excel|*.xlsx;*.xls";
                saveFileDialog1.Title = "Guardar";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Workbook newWorkbook = excel.Workbooks.Add();
                    Worksheet newWorksheet = newWorkbook.ActiveSheet;

                    // Escribir los datos en la hoja de Excel
                    for (int i = 0; i < result.Count; i++)
                    {
                        newWorksheet.Cells[i + 1, 1] = result[i].Item1;
                        newWorksheet.Cells[i + 1, 2] = result[i].Item2;
                        newWorksheet.Cells[i + 1, 3] = result[i].Item3;
                        newWorksheet.Cells[i + 1, 4] = result[i].Item4;
                        newWorksheet.Cells[i + 1, 5] = result[i].Item5;
                    }

                    // Guardar el archivo Excel y cerrar Excel
                    newWorkbook.SaveAs(saveFileDialog1.FileName);
                    newWorkbook.Close();
                    excel.Quit();
                }
            }
        }






    }
}

