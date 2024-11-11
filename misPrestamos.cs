using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test
{
    public partial class misPrestamos : Form
    {
        List<alumno> alumnos = new List<alumno>();
        alumno actual;
        List<material> materiales = new List<material>();
        public misPrestamos(string exp, int i)
        {
            alumno.iniciar_alumnos(alumnos);
            material.iniciar_materiales(materiales);
            actual = alumnos.Find(a => a.verexp() == exp);
            actual.mostrar_datos();
            InitializeComponent();
            crear_tabla();
            if (i == 1)
            {
                label1.Enabled = true;
                label1.Visible = true;
                textBox1.Enabled = true;
                textBox1.Visible = true;
                button2.Visible = true;
                button2.Enabled = true;
            }
        }
        private void crear_tabla()
        {
            tabla.Rows.Clear();
            tabla.Columns.Clear();
            tabla.Columns.Add("ID", "ID material");
            tabla.Columns.Add("Nombre", "Nombre material");
            foreach (var material in materiales)
            {
                if (actual.checarprestamo(material.verID()))
                    tabla.Rows.Add(material.verID(), material.vernombre());
            }
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alumno.guardar_alumnos(alumnos);
            material.guardar_materiales(materiales); 
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _))
            {
                if (actual.checarprestamo(textBox1.Text))
                {
                    foreach (var material in materiales)
                    {
                        if (material.verID() == textBox1.Text)
                        {
                            material.habilitar();
                            MessageBox.Show("Material devuelto con exito", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            actual.devolver(material.verID());
                            alumno.guardar_alumnos(alumnos);
                            material.guardar_materiales(materiales);
                        }
                    }
                }
            }
            alumno.guardar_alumnos(alumnos);
            material.guardar_materiales(materiales);
            crear_tabla();
        }
    }
}
