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
    public partial class verPrestamos : Form
    {
        List<alumno> alumnos = new List<alumno>();
        List<material> materiales = new List<material>();
        public verPrestamos()
        {
            alumno.iniciar_alumnos(alumnos);
            material.iniciar_materiales(materiales);
            InitializeComponent();
            crear_tabla();
        }
        private void crear_tabla()
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();
            tabla.Columns.Add("ID", "ID Articulo");
            tabla.Columns.Add("Nombre Articulo", "Nombre Articulo");
            tabla.Columns.Add("Expedietne", "Expediente Alumno");
            tabla.Columns.Add("Nombre Alumno", "Nombre Alumno");
            foreach(var material in materiales)
            {
                if (material.verEstado() == "prestado")
                {
                    foreach (var alumno in alumnos)
                    {
                        bool deudor = alumno.checarprestamo(material.verID());
                        if (deudor)
                            tabla.Rows.Add(material.verID(), material.vernombre(), alumno.verexp(), alumno.vernombre());
                    }
                }
            }
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
