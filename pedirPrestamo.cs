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
    public partial class pedirPrestamo : Form
    {
        List<alumno> alumnos = new List<alumno>();
        alumno actual;
        List<material> materiales = new List<material>();
        public pedirPrestamo(string exp)
        {
            alumno.iniciar_alumnos(alumnos);
            material.iniciar_materiales(materiales);
            actual = alumnos.Find(a => a.verexp() == exp);
            actual.mostrar_datos();
            InitializeComponent();
            button9.Enabled = false;
            button9.Visible = false;
        }
        private void crear_tabla(string tag)
        {
            tablaMateriales.Columns.Clear();
            tablaMateriales.Rows.Clear();
            tablaMateriales.Columns.Add("Nombre", "Nombre");
            tablaMateriales.Columns.Add("ID", "ID");
            tablaMateriales.Columns.Add("Disponibilidad", "Disponibilidad");

            foreach (var material in materiales)
            {
                if (material.verTags().Contains(tag) || material.vernombre() == tag)
                {
                    if (material.verEstado() == "disponible")
                    {
                        tablaMateriales.Rows.Add(material.vernombre(), material.verID(), material.verEstado());
                    }
                }
            }
            tablaMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            crear_tabla(textBox3.Text.ToLower());
            if (tablaMateriales.Rows.Count > 0)
            {
                label8.Visible = true;
                label8.Enabled = true;
                textBox4.Visible = true;
                textBox4.Enabled = true;
                button10.Visible = true;
                button10.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out _))
            {
                material articulo;
                articulo = materiales.Find(a => a.verID() == textBox4.Text);
                if (actual.disponible())
                {
                    actual.pedirPrestamo(articulo);
                    articulo.prestado();
                }
            }
            crear_tabla(textBox3.Text);
            alumno.guardar_alumnos(alumnos);
            material.guardar_materiales(materiales);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            alumno.guardar_alumnos(alumnos);
            material.guardar_materiales(materiales);
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button9_Click(sender,e);
        }
    }
}
