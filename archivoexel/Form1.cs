using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;

namespace archivoexel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnleer_Click(object sender, EventArgs e)
        {
            string rutaexel = Application.StartupPath + "\\Datos.xlsx";
            var book = new ExcelQueryFactory(rutaexel);
            var rs = (from row in book.Worksheet("hoja1")
                      let item = new Person
                      {
                          Id = row[0].Cast<int>(),
                          nombre = row[1].Cast<string>(),
                          apellido = row[2].Cast<string>()
                      }
                      select item).ToList();
            book.Dispose();
            tbDatos.Text = "Datos de archivo "+ Environment.NewLine;
            foreach(var it in rs)
            {
                tbDatos.Text += it.Id + " " + it.nombre + " " + it.apellido+Environment.NewLine;
            }

            dgvExel.DataSource = rs;
            dgvExel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
    }
}
