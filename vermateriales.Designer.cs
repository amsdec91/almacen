namespace test
{
    partial class vermateriales
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
            this.tablita = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablita)).BeginInit();
            this.SuspendLayout();
            // 
            // tablita
            // 
            this.tablita.AllowUserToAddRows = false;
            this.tablita.AllowUserToDeleteRows = false;
            this.tablita.AllowUserToOrderColumns = true;
            this.tablita.AllowUserToResizeColumns = false;
            this.tablita.AllowUserToResizeRows = false;
            this.tablita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablita.Location = new System.Drawing.Point(28, 26);
            this.tablita.Name = "tablita";
            this.tablita.ReadOnly = true;
            this.tablita.RowHeadersWidth = 51;
            this.tablita.RowTemplate.Height = 24;
            this.tablita.Size = new System.Drawing.Size(1012, 522);
            this.tablita.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(409, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vermateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 630);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablita);
            this.Name = "vermateriales";
            this.Text = "Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.tablita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablita;
        private System.Windows.Forms.Button button1;
    }
}