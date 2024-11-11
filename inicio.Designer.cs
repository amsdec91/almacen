using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Windows.Forms;
class alumno
{
    string expediente;
    string nip;
    string nombre;
    string telefono;
    string carrera;
    string facultad;
    string[] ID_material = new string[5];
    
    public alumno(string expediente, string nip, string nombre, string telefono, string carrera, string facultad, string ID_material1, string ID_material2, string ID_material3, string ID_material4, string ID_material5)
    {
        this.expediente = expediente;
        this.nip = nip;
        this.nombre = nombre;
        this.telefono = telefono;
        this.carrera = carrera;
        this.facultad = facultad;
        this.ID_material[0] = ID_material1;
        this.ID_material[1] = ID_material2;
        this.ID_material[2] = ID_material3;
        this.ID_material[3] = ID_material4;
        this.ID_material[4] = ID_material5;
    }
    public void mostrar_datos()
    {
        System.Console.WriteLine(this.expediente + "\n" + this.nip + "\n" + this.nombre);
    }
    public string verexp()
    {
        return this.expediente;
    }
    public string vernombre()
    {
        return this.nombre;
    }
    public string vernip()
    {
        return this.nip;
    }
    public static void iniciar_alumnos(List<alumno> alumnos)
    {
        string ruta = "alumnos.txt";

        using (StreamReader lector = new StreamReader(ruta))
        {
            string linea;

            while ((linea = lector.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                string[] datos = linea.Split('ª');
                alumnos.Add(new alumno(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6], datos[7], datos[8], datos[9], datos[10]));
            }
            Console.WriteLine("\n");
        }
    }
    public static void guardar_alumnos(List<alumno> alumnos)
    {
        string ruta = "alumnos.txt";
        using (StreamWriter escritor = new StreamWriter(ruta))
        {
            foreach(var alumno in alumnos)
            {
                string linea = $"{alumno.expediente}ª{alumno.nip}ª{alumno.nombre}ª{alumno.telefono}ª{alumno.carrera}ª{alumno.facultad}ª{alumno.ID_material[0]}ª{alumno.ID_material[1]}ª{alumno.ID_material[2]}ª{alumno.ID_material[3]}ª{alumno.ID_material[4]}";
                escritor.WriteLine(linea);
            }
        }
        Console.WriteLine("guarde los datos.");
    }
    public bool checarprestamo(string id)
    {
        for(int i = 0; i < 5; i++)
        {
            if (this.ID_material[i] == id)
                return true;
        }
        return false;
    }
    public void pedirPrestamo(material articulo)
    {
        for(int i = 0; i <= 5; i++)
        {
            if(i==5)
            {
                MessageBox.Show("No tienes espacio para prestamos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.ID_material[i] == "000")
            {
                this.ID_material[i] = articulo.verID();
                MessageBox.Show("Prestamo aprovado", "confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
    }
    public bool disponible()
    {
        for(int i = 0; i <= 5; i++)
        {
            if (i == 5)
            {
                MessageBox.Show("No tienes espacio para prestamos disponibles", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.ID_material[i] == "000")
            {
                return true;
            }
        }
        return false;
    }
    public void devolver(string id)
    {
        for(int i = 0; i < 5; i++)
        {
            if (this.ID_material[i] == id)
            {
                this.ID_material[i] = "000";
                return;
            }
        }
    }
}
class material
{
    string nombre;
    string ID;
    string tags;
    string estado;

    public material(string nombre, string iD, string tags, string estado)
    {
        this.nombre = nombre;
        this.ID = iD;
        this.tags = tags;
        this.estado = estado;
    }
    public static void iniciar_materiales(List<material> materiales)
    {
        string ruta = "materiales.txt";

        using (StreamReader lector = new StreamReader(ruta))
        {
            string linea;

            while ((linea = lector.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                string[] datos = linea.Split('ª');
                materiales.Add(new material(datos[0], datos[1], datos[2], datos[3]));
            }
            Console.WriteLine('\n');
        }
    }
    public static void guardar_materiales(List<material> materiales)
    {
        string ruta = "materiales.txt";
        using (StreamWriter escritor = new StreamWriter(ruta))
        {
            foreach (var material in materiales)
            {
                string linea = $"{material.nombre}ª{material.ID}ª{material.tags}ª{material.estado}";
                escritor.WriteLine(linea);
            }
        }
        Console.WriteLine("guarde los datos.");
    }
    public string vernombre()
    {
        return this.nombre;
    }
    public string verID()
    {
        return this.ID;
    }
    public string verEstado()
    {
        return this.estado;
    }
    public string verTags()
    {
        return this.tags;
    }
    public void deshabilitar()
    {
        this.estado = "deshabilitado";
    }
    public void habilitar()
    {
        this.estado = "disponible";
    }
    public void prestado()
    {
        this.estado = "prestado";
    }
    public static string nuevaID(List<material> materiales)
    {
        int ultimo=0;
        string final;
        foreach(var material in materiales)
        {
            ultimo = int.Parse(material.ID);
        }
        ultimo++;
        final = ultimo.ToString();
        if (final.Length == 1)
            return ("00" + final);
        else if (final.Length == 2)
            return "0" + final;
        else if (final.Length == 3)
            return final;
        return "0";
    }
}
namespace test
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginAlmacen = new System.Windows.Forms.TextBox();
            this.instruccionAlmacen = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.expedientebox = new System.Windows.Forms.TextBox();
            this.NIPbox = new System.Windows.Forms.TextBox();
            this.EXP = new System.Windows.Forms.Label();
            this.NIP = new System.Windows.Forms.Label();
            this.Errorlogginalmacen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EXPregister = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Almacenista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Alumno";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "¿Quién desea ingresar?";
            // 
            // LoginAlmacen
            // 
            this.LoginAlmacen.Enabled = false;
            this.LoginAlmacen.Location = new System.Drawing.Point(334, 325);
            this.LoginAlmacen.Name = "LoginAlmacen";
            this.LoginAlmacen.Size = new System.Drawing.Size(407, 22);
            this.LoginAlmacen.TabIndex = 3;
            this.LoginAlmacen.Visible = false;
            this.LoginAlmacen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LoginAlmacen_KeyUp);
            // 
            // instruccionAlmacen
            // 
            this.instruccionAlmacen.AutoSize = true;
            this.instruccionAlmacen.BackColor = System.Drawing.SystemColors.Control;
            this.instruccionAlmacen.Enabled = false;
            this.instruccionAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruccionAlmacen.Location = new System.Drawing.Point(349, 261);
            this.instruccionAlmacen.Name = "instruccionAlmacen";
            this.instruccionAlmacen.Size = new System.Drawing.Size(21, 32);
            this.instruccionAlmacen.TabIndex = 4;
            this.instruccionAlmacen.Text = " ";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(367, 261);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 43);
            this.button3.TabIndex = 5;
            this.button3.Text = "Iniciar sesion";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(545, 261);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 43);
            this.button4.TabIndex = 6;
            this.button4.Text = "Registrarse";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // expedientebox
            // 
            this.expedientebox.Enabled = false;
            this.expedientebox.Location = new System.Drawing.Point(391, 325);
            this.expedientebox.Name = "expedientebox";
            this.expedientebox.Size = new System.Drawing.Size(350, 22);
            this.expedientebox.TabIndex = 7;
            this.expedientebox.Visible = false;
            this.expedientebox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.expedientebox_KeyUp);
            // 
            // NIPbox
            // 
            this.NIPbox.Enabled = false;
            this.NIPbox.Location = new System.Drawing.Point(391, 380);
            this.NIPbox.Name = "NIPbox";
            this.NIPbox.Size = new System.Drawing.Size(350, 22);
            this.NIPbox.TabIndex = 8;
            this.NIPbox.Visible = false;
            this.NIPbox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NIPbox_KeyUp);
            // 
            // EXP
            // 
            this.EXP.AutoSize = true;
            this.EXP.Enabled = false;
            this.EXP.Location = new System.Drawing.Point(284, 328);
            this.EXP.Name = "EXP";
            this.EXP.Size = new System.Drawing.Size(75, 16);
            this.EXP.TabIndex = 9;
            this.EXP.Text = "Expediente";
            this.EXP.Visible = false;
            // 
            // NIP
            // 
            this.NIP.AutoSize = true;
            this.NIP.Enabled = false;
            this.NIP.Location = new System.Drawing.Point(308, 383);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(29, 16);
            this.NIP.TabIndex = 10;
            this.NIP.Text = "NIP";
            this.NIP.Visible = false;
            // 
            // Errorlogginalmacen
            // 
            this.Errorlogginalmacen.AutoSize = true;
            this.Errorlogginalmacen.Enabled = false;
            this.Errorlogginalmacen.Location = new System.Drawing.Point(423, 385);
            this.Errorlogginalmacen.Name = "Errorlogginalmacen";
            this.Errorlogginalmacen.Size = new System.Drawing.Size(138, 16);
            this.Errorlogginalmacen.TabIndex = 12;
            this.Errorlogginalmacen.Text = "Contraseña incorrecta";
            this.Errorlogginalmacen.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(284, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Expediente";
            this.label2.Visible = false;
            // 
            // EXPregister
            // 
            this.EXPregister.Enabled = false;
            this.EXPregister.Location = new System.Drawing.Point(391, 325);
            this.EXPregister.Name = "EXPregister";
            this.EXPregister.Size = new System.Drawing.Size(350, 22);
            this.EXPregister.TabIndex = 13;
            this.EXPregister.Visible = false;
            this.EXPregister.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EXPregister_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(442, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 630);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EXPregister);
            this.Controls.Add(this.Errorlogginalmacen);
            this.Controls.Add(this.NIP);
            this.Controls.Add(this.EXP);
            this.Controls.Add(this.NIPbox);
            this.Controls.Add(this.expedientebox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.instruccionAlmacen);
            this.Controls.Add(this.LoginAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "inicio";
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void limpiarcomponentes()
        {
            this.Controls.Clear();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginAlmacen;
        private System.Windows.Forms.Label instruccionAlmacen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox expedientebox;
        private System.Windows.Forms.TextBox NIPbox;
        private System.Windows.Forms.Label EXP;
        private System.Windows.Forms.Label NIP;
        private System.Windows.Forms.Label Errorlogginalmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EXPregister;
        private System.Windows.Forms.Label label3;
    }
}

