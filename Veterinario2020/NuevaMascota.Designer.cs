namespace Veterinario2020
{
    partial class NuevaMascota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaMascota));
            this.insertaMascota = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDueno = new System.Windows.Forms.TextBox();
            this.textBoxVacunado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edadMascota = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // insertaMascota
            // 
            this.insertaMascota.BackColor = System.Drawing.SystemColors.ControlText;
            this.insertaMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.insertaMascota.Location = new System.Drawing.Point(181, 197);
            this.insertaMascota.Name = "insertaMascota";
            this.insertaMascota.Size = new System.Drawing.Size(75, 23);
            this.insertaMascota.TabIndex = 0;
            this.insertaMascota.Text = "Añadir";
            this.insertaMascota.UseVisualStyleBackColor = false;
            this.insertaMascota.Click += new System.EventHandler(this.insertaMascota_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(156, 76);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDueno
            // 
            this.textBoxDueno.Location = new System.Drawing.Point(156, 128);
            this.textBoxDueno.Name = "textBoxDueno";
            this.textBoxDueno.Size = new System.Drawing.Size(100, 20);
            this.textBoxDueno.TabIndex = 3;
            // 
            // textBoxVacunado
            // 
            this.textBoxVacunado.Location = new System.Drawing.Point(156, 154);
            this.textBoxVacunado.Name = "textBoxVacunado";
            this.textBoxVacunado.Size = new System.Drawing.Size(100, 20);
            this.textBoxVacunado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(56, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(56, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(59, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vacunado:";
            // 
            // edadMascota
            // 
            this.edadMascota.Location = new System.Drawing.Point(156, 102);
            this.edadMascota.Name = "edadMascota";
            this.edadMascota.Size = new System.Drawing.Size(100, 20);
            this.edadMascota.TabIndex = 9;
            // 
            // NuevaMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Veterinario2020.Properties.Resources.login1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 467);
            this.Controls.Add(this.edadMascota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVacunado);
            this.Controls.Add(this.textBoxDueno);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.insertaMascota);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NuevaMascota";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertaMascota;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDueno;
        private System.Windows.Forms.TextBox textBoxVacunado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker edadMascota;
    }
}