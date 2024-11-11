namespace test
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.carrerasbox = new System.Windows.Forms.ComboBox();
            this.nombres = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.facultadbox = new System.Windows.Forms.ComboBox();
            this.telefonobox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NIPbox = new System.Windows.Forms.TextBox();
            this.cancelarbutton = new System.Windows.Forms.Button();
            this.aceptarbutton = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPEDIENTE: ";
            // 
            // carrerasbox
            // 
            this.carrerasbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carrerasbox.FormattingEnabled = true;
            this.carrerasbox.Location = new System.Drawing.Point(519, 271);
            this.carrerasbox.Name = "carrerasbox";
            this.carrerasbox.Size = new System.Drawing.Size(387, 24);
            this.carrerasbox.TabIndex = 9;
            // 
            // nombres
            // 
            this.nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nombres.Location = new System.Drawing.Point(145, 134);
            this.nombres.Name = "nombres";
            this.nombres.Size = new System.Drawing.Size(315, 36);
            this.nombres.TabIndex = 2;
            // 
            // apellidos
            // 
            this.apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.apellidos.Location = new System.Drawing.Point(523, 134);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(383, 36);
            this.apellidos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(141, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(519, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(141, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Facultad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(519, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Carrera";
            // 
            // facultadbox
            // 
            this.facultadbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultadbox.FormattingEnabled = true;
            this.facultadbox.Items.AddRange(new object[] {
            "Bellas Artes",
            "Contaduría y administración",
            "Derecho",
            "Ciencias naturales",
            "Ciencias políticas y sociales",
            "Enfermería",
            "Filosofía",
            "Informática",
            "Ingeniería",
            "Lenguas y letras",
            "Medicina",
            "Psicología",
            "Química"});
            this.facultadbox.Location = new System.Drawing.Point(145, 271);
            this.facultadbox.Name = "facultadbox";
            this.facultadbox.Size = new System.Drawing.Size(315, 24);
            this.facultadbox.TabIndex = 8;
            this.facultadbox.SelectedIndexChanged += new System.EventHandler(this.facultadbox_SelectedIndexChanged);
            // 
            // telefonobox
            // 
            this.telefonobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.telefonobox.Location = new System.Drawing.Point(145, 383);
            this.telefonobox.Name = "telefonobox";
            this.telefonobox.Size = new System.Drawing.Size(315, 36);
            this.telefonobox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(142, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(532, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "NIP";
            // 
            // NIPbox
            // 
            this.NIPbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NIPbox.Location = new System.Drawing.Point(523, 383);
            this.NIPbox.Name = "NIPbox";
            this.NIPbox.Size = new System.Drawing.Size(383, 36);
            this.NIPbox.TabIndex = 11;
            // 
            // cancelarbutton
            // 
            this.cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelarbutton.Location = new System.Drawing.Point(357, 478);
            this.cancelarbutton.Name = "cancelarbutton";
            this.cancelarbutton.Size = new System.Drawing.Size(103, 33);
            this.cancelarbutton.TabIndex = 13;
            this.cancelarbutton.Text = "Cancelar";
            this.cancelarbutton.UseVisualStyleBackColor = true;
            this.cancelarbutton.Click += new System.EventHandler(this.cancelarbutton_Click);
            // 
            // aceptarbutton
            // 
            this.aceptarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.aceptarbutton.Location = new System.Drawing.Point(519, 478);
            this.aceptarbutton.Name = "aceptarbutton";
            this.aceptarbutton.Size = new System.Drawing.Size(103, 33);
            this.aceptarbutton.TabIndex = 12;
            this.aceptarbutton.Text = "Aceptar";
            this.aceptarbutton.UseVisualStyleBackColor = true;
            this.aceptarbutton.Click += new System.EventHandler(this.aceptarbutton_Click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(464, 441);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 20);
            this.errorlabel.TabIndex = 15;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 630);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.aceptarbutton);
            this.Controls.Add(this.cancelarbutton);
            this.Controls.Add(this.NIPbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefonobox);
            this.Controls.Add(this.facultadbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellidos);
            this.Controls.Add(this.nombres);
            this.Controls.Add(this.carrerasbox);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox carrerasbox;
        private System.Windows.Forms.TextBox nombres;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox facultadbox;
        private System.Windows.Forms.TextBox telefonobox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NIPbox;
        private System.Windows.Forms.Button cancelarbutton;
        private System.Windows.Forms.Button aceptarbutton;
        private System.Windows.Forms.Label errorlabel;
    }
}