namespace test
{
    partial class pedirPrestamo
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
            this.button10 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tablaMateriales = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button10.Location = new System.Drawing.Point(832, 501);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(157, 40);
            this.button10.TabIndex = 30;
            this.button10.Text = "Confirmar";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(618, 511);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 22);
            this.textBox4.TabIndex = 29;
            this.textBox4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(79, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(533, 29);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ingresa la ID del material que quieres solicitar:";
            this.label8.Visible = false;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button9.Location = new System.Drawing.Point(688, 33);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 40);
            this.button9.TabIndex = 27;
            this.button9.Text = "Buscar";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(403, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(259, 22);
            this.textBox3.TabIndex = 26;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(79, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ingresa material a buscar:";
            // 
            // tablaMateriales
            // 
            this.tablaMateriales.AllowUserToAddRows = false;
            this.tablaMateriales.AllowUserToDeleteRows = false;
            this.tablaMateriales.AllowUserToResizeColumns = false;
            this.tablaMateriales.AllowUserToResizeRows = false;
            this.tablaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaMateriales.Location = new System.Drawing.Point(72, 95);
            this.tablaMateriales.Name = "tablaMateriales";
            this.tablaMateriales.ReadOnly = true;
            this.tablaMateriales.RowHeadersWidth = 51;
            this.tablaMateriales.RowTemplate.Height = 24;
            this.tablaMateriales.Size = new System.Drawing.Size(933, 392);
            this.tablaMateriales.TabIndex = 24;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button8.Location = new System.Drawing.Point(420, 550);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(179, 48);
            this.button8.TabIndex = 23;
            this.button8.Text = "Cancelar";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pedirPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 630);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tablaMateriales);
            this.Controls.Add(this.button8);
            this.Name = "pedirPrestamo";
            this.Text = "Solicitud de prestamo";
            ((System.ComponentModel.ISupportInitialize)(this.tablaMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tablaMateriales;
        private System.Windows.Forms.Button button8;
    }
}