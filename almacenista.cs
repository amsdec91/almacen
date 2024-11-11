using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form2 : Form
    {
        List<material> materiales = new List<material>();
        public Form2()
        {
            material.iniciar_materiales(materiales);
            InitializeComponent();
        }
        private void verPrincipal()
        {
            label1.Enabled = true;
            label1.Visible = true;
            label2.Enabled = true;
            label2.Visible = true;
            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = true;
            button2.Enabled = true;
            button3.Visible = true;
            button3.Enabled = true;
            button4.Visible = true;
            button4.Enabled = true;
            button5.Visible = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button6.Visible = true;

            foreach(var material in materiales)
            {
                Console.WriteLine(material.vernombre() + "   " + material.verID() + "   " + material.verEstado());
            }
        }
        private void esconderTodo()
        {
            foreach(Control control in this.Controls)
            {
                control.Visible = false;
                control.Enabled = false;
            }
        }
        private void paraAgregar()
        {
            label3.Visible = true;
            label3.Enabled = true;
            label4.Visible = true;
            label4.Enabled = true;
            label5.Visible = true;
            label5.Enabled = true;
            button7.Visible = true;
            button7.Enabled = true;
            textBox1.Visible = true;
            textBox1.Enabled = true;
            textBox2.Visible = true;
            textBox2.Enabled = true;
            button8.Enabled = true;
            button8.Visible = true;
        }
        private void agregarMaterial()
        {
            string id = material.nuevaID(materiales);
            materiales.Add(new material(textBox1.Text.ToLower(), id, textBox2.Text.ToLower(), "disponible"));
            material.guardar_materiales(materiales);
            MessageBox.Show("Material registrado correctamente", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vermateriales materialesForm = new vermateriales();
            this.Hide();
            materialesForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            materialesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            esconderTodo();
            paraAgregar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox2.Text == null || textBox1.Text == "" || textBox2.Text == "")
            {
                label6.Visible = true;
                label6.Enabled = true;
            }
            else
            {
                agregarMaterial();
                esconderTodo();
                verPrincipal();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            esconderTodo();
            verPrincipal();
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
        private void crear_tabla()
        {
            tablaMateriales.Columns.Clear();
            tablaMateriales.Rows.Clear();
            tablaMateriales.Columns.Add("Nombre", "Nombre");
            tablaMateriales.Columns.Add("ID", "ID");
            tablaMateriales.Columns.Add("Disponibilidad", "Disponibilidad");

            foreach (var material in materiales)
            {
                if (material.verEstado() == "deshabilitado")
                {
                    tablaMateriales.Rows.Add(material.vernombre(), material.verID(), material.verEstado());
                }
            }
            tablaMateriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void verDeshabilitar()
        {
            tablaMateriales.Enabled = true;
            tablaMateriales.Visible = true;
            label7.Visible = true;
            label7.Enabled = true;
            label8.Text = "Ingresa la ID del material a deshabilitar: ";
            textBox3.Visible = true;
            textBox3.Enabled = true;
            button8.Visible = true;
            button8.Enabled = true;
            tablaMateriales.Columns.Clear();
            tablaMateriales.Rows.Clear();
        }
        private void verHabilitar()
        {
            tablaMateriales.Enabled = true;
            tablaMateriales.Visible = true;
            label8.Text = "Ingresa la ID del material a habilitar: ";
            label8.Visible = true;
            label8.Enabled = true;
            button8.Visible = true;
            button8.Enabled = true;
            button10.Enabled = true;
            button10.Visible = true;
            textBox4.Visible = true;
            textBox4.Enabled = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            esconderTodo();
            verDeshabilitar();
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
        private void cambiarEstado (string id, int xd)
        {
            if (xd == 1)
            {
                foreach (var material in materiales)
                {
                    if (int.Parse(material.verID()) == int.Parse(id) && material.verEstado() == "disponible")
                        material.deshabilitar();
                }
                crear_tabla(textBox3.Text);
            }
            else if (xd == 2)
            {
                foreach (var material in materiales)
                {
                    if (int.Parse(material.verID()) == int.Parse(id) && material.verEstado() == "deshabilitado")
                        material.habilitar();
                }
                crear_tabla();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if(label8.Text == "Ingresa la ID del material a deshabilitar: ")
            {
                if (int.TryParse(textBox4.Text, out _))
                {
                    cambiarEstado(textBox4.Text, 1);
                    MessageBox.Show("El estado del material se actualizo", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    material.guardar_materiales(materiales);
                }
            }
            else if(label8.Text == "Ingresa la ID del material a habilitar: ")
            {
                if(int.TryParse(textBox4.Text, out _))
                {
                    cambiarEstado(textBox4.Text, 2);
                    MessageBox.Show("El estado del material se actualizo", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    material.guardar_materiales(materiales);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            esconderTodo();
            verHabilitar();
            crear_tabla();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            verPrestamos prestamos = new verPrestamos();
            this.Hide();
            prestamos.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            prestamos.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button9_Click(sender, e);
        }
    }
}
