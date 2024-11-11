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
    public partial class Form3 : Form
    {
        List<alumno> alumnos = new List<alumno>();
        alumno actual;
        public Form3(string exp)
        {
            alumno.iniciar_alumnos(alumnos);
            actual = alumnos.Find(a => a.verexp() == exp);
            actual.mostrar_datos();
            InitializeComponent();
            label2.Text = actual.vernombre();
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            alumno.iniciar_alumnos(alumnos);
            this.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pedirPrestamo ventana = new pedirPrestamo(actual.verexp());
            ventana.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            misPrestamos ventana2 = new misPrestamos(actual.verexp(),2);
            ventana2.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            ventana2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            misPrestamos ventana2 = new misPrestamos(actual.verexp(), 1);
            ventana2.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            ventana2.Show();
        }
    }
}
