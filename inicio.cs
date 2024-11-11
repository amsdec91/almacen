using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class inicio : Form
    {
        List<alumno> alumnos = new List<alumno>();

        public inicio()
        {
            alumno.iniciar_alumnos(alumnos);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            instruccionAlmacen.Enabled = true;
            instruccionAlmacen.Text = "Ingresa la clave de acceso";
            LoginAlmacen.Enabled = true;
            LoginAlmacen.Visible = true;
            button3.Enabled = false;
            button4.Enabled = false;
            button3.Visible = false;
            button4.Visible = false;
            EXP.Visible = false;
            expedientebox.Visible = false;
            NIP.Visible = false;
            NIPbox.Visible = false;
            EXP.Enabled = false;
            expedientebox.Enabled = false;
            NIP.Enabled = false;
            NIPbox.Enabled = false;
            label2.Visible = false;
            label2.Enabled = false;
            EXPregister.Visible = false;
            EXPregister.Enabled = false;
            label3.Visible = false;
            expedientebox.Text = "";
            NIPbox.Text = expedientebox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            instruccionAlmacen.Enabled = false;
            instruccionAlmacen.Text = " ";
            LoginAlmacen.Enabled = false;
            LoginAlmacen.Visible = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button3.Visible = true;
            button4.Visible = true;
            Errorlogginalmacen.Visible = false;
            label1.Text = "oli uwu";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EXP.Visible = true;
            expedientebox.Visible = true;
            NIP.Visible = true;
            NIPbox.Visible = true;
            EXP.Enabled = true;
            expedientebox.Enabled = true;
            NIP.Enabled = true;
            NIPbox.Enabled = true;
            label2.Visible = false;
            label2.Enabled = false;
            EXPregister.Visible = false;
            EXPregister.Enabled = false;
            label3 .Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EXP.Visible = false;
            expedientebox.Visible = false;
            NIP.Visible = false;
            NIPbox.Visible = false;
            EXP.Enabled = false;
            expedientebox.Enabled = false;
            NIP.Enabled = false;
            NIPbox.Enabled = false;
            EXPregister.Visible = true;
            EXPregister.Enabled = true;
            label2.Visible = true;
            label2.Enabled = true;
            label3.Visible = false;
            expedientebox.Text = "";
            NIPbox.Text = expedientebox.Text;
        }

        private void LoginAlmacen_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (LoginAlmacen.Text == "INA22")
                {
                    LoginAlmacen.Text = "";
                    this.Hide();    
                    Form2 form2 = new Form2();
                    form2.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                    form2.Show();
                }
                else if (LoginAlmacen.Text != "INA22")
                {
                    Errorlogginalmacen.Visible = true;
                }
            }
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            alumno.iniciar_alumnos(alumnos);
            this.Show();
        }

        private int checar(string exp)
        {
            int contador;

            for (contador = 0; contador < alumnos.Count; contador++)
            {
                if (alumnos[contador]==null)
                {
                    return 200;
                }
                else
                {
                    if (alumnos[contador].verexp() == exp)
                    {
                        return contador;
                    }
                }
            }
            return 200;
        }
        private bool autorizar(string NIP, int i)
        {
            if (alumnos[i].vernip()==NIP)
                return true;
            else
                return false;
        }
        private void autorizar()
        {
            if (NIPbox.Text == "" || expedientebox.Text == "")
            {
                label3.Text = "Por favor rellena todos los datos";
                label3.Visible = true;
            }
            else
            {
                int i = checar(expedientebox.Text);
                Console.WriteLine(i);

                if (i == 200 || !autorizar(NIPbox.Text, i))
                {
                    label3.Text = "Expediente o NIP erroneo";
                    label3.Visible = true;
                }
                else if (autorizar(NIPbox.Text, i))
                {
                    this.Hide();
                    Form3 form3 = new Form3(expedientebox.Text);
                    form3.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                    expedientebox.Text = null;
                    NIPbox.Text = null;
                    form3.Show();
                }
            }
        }
        private void expedientebox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autorizar();
            }
        }

        private void NIPbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autorizar();
            }
        }

        private void EXPregister_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool esono = int.TryParse(EXPregister.Text,out _);
                if (EXPregister.Text.Length != 6)
                    esono = false;
                int i = checar(EXPregister.Text);
                if (i != 200)
                    esono = false;

                if (!esono)
                {
                    label3.Text = "El expediente ya existe o es incorrecto";
                    label3.Visible = true;
                    EXPregister.Text = null;
                }
                else
                {
                    label3.Text = null;
                    Registro form4 = new Registro(EXPregister.Text);
                    EXPregister.Text = null;
                    this.Hide();
                    form4.FormClosed += new FormClosedEventHandler(Form_FormClosed);
                    form4.Show();
                }
            }
        }
    }
}
