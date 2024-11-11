using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class vermateriales : Form
    {
        List<material> materiales = new List<material>();
        public vermateriales()
        {
            InitializeComponent();
            material.iniciar_materiales(materiales);
            crear_tabla();
        }
        private void crear_tabla()
        {
            tablita.Columns.Clear();
            tablita.Rows.Clear();
            tablita.Columns.Add("Nombre","Nombre");
            tablita.Columns.Add("ID", "ID");
            tablita.Columns.Add("Disponibilidad", "Disponibilidad");

            foreach(var material in materiales)
            {
                tablita.Rows.Add(material.vernombre(),material.verID(),material.verEstado());
            }
            tablita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
