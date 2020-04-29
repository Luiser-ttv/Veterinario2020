namespace Veterinario2020
{
    partial class VentanaPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.calendarioCitas = new System.Windows.Forms.MonthCalendar();
            this.peluqueriaCita = new System.Windows.Forms.Button();
            this.citaVacunas = new System.Windows.Forms.Button();
            this.spaCitas = new System.Windows.Forms.Button();
            this.fechaRevision = new System.Windows.Forms.DateTimePicker();
            this.revisionCita = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.retrocesoBoton = new System.Windows.Forms.Button();
            this.vacunaMascota = new System.Windows.Forms.Label();
            this.dueñoMascota = new System.Windows.Forms.Label();
            this.edadMascota = new System.Windows.Forms.Label();
            this.nombreMascota = new System.Windows.Forms.Label();
            this.muestraMascota = new System.Windows.Forms.Button();
            this.pictureBoxMascota = new System.Windows.Forms.PictureBox();
            this.pictureBoxSpa = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::Veterinario2020.Properties.Resources.login1;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 407);
            this.tabPage1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(187, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(410, 38);
            this.label7.TabIndex = 2;
            this.label7.Text = "Estabamos esperándote ansiosos :)";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(185, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(350, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "¡Bienvenido fraxito!";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Veterinario2020.Properties.Resources.login1;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.calendarioCitas);
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Veterinario2020.Properties.Resources.login1;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.dateTimePicker3);
            this.tabPage4.Controls.Add(this.dateTimePicker2);
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.fechaRevision);
            this.tabPage4.Controls.Add(this.spaCitas);
            this.tabPage4.Controls.Add(this.citaVacunas);
            this.tabPage4.Controls.Add(this.peluqueriaCita);
            this.tabPage4.Controls.Add(this.revisionCita);
            this.tabPage4.Controls.Add(this.pictureBoxSpa);
            this.tabPage4.Controls.Add(this.pictureBox3);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.ImageIndex = 4;
            this.tabPage4.Location = new System.Drawing.Point(4, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 407);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_dog.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_home.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_paper.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_calendar.ico");
            this.imageList1.Images.SetKeyName(4, "icons8_schedule_1.ico");
            // 
            // calendarioCitas
            // 
            this.calendarioCitas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.calendarioCitas.CalendarDimensions = new System.Drawing.Size(4, 2);
            this.calendarioCitas.Location = new System.Drawing.Point(3, 36);
            this.calendarioCitas.Name = "calendarioCitas";
            this.calendarioCitas.TabIndex = 0;
            // 
            // peluqueriaCita
            // 
            this.peluqueriaCita.BackColor = System.Drawing.Color.Black;
            this.peluqueriaCita.ForeColor = System.Drawing.SystemColors.Control;
            this.peluqueriaCita.Location = new System.Drawing.Point(265, 194);
            this.peluqueriaCita.Name = "peluqueriaCita";
            this.peluqueriaCita.Size = new System.Drawing.Size(99, 23);
            this.peluqueriaCita.TabIndex = 1;
            this.peluqueriaCita.Text = "Peluquería";
            this.peluqueriaCita.UseVisualStyleBackColor = false;
            // 
            // citaVacunas
            // 
            this.citaVacunas.BackColor = System.Drawing.Color.Black;
            this.citaVacunas.ForeColor = System.Drawing.SystemColors.Control;
            this.citaVacunas.Location = new System.Drawing.Point(425, 194);
            this.citaVacunas.Name = "citaVacunas";
            this.citaVacunas.Size = new System.Drawing.Size(99, 23);
            this.citaVacunas.TabIndex = 2;
            this.citaVacunas.Text = "Vacunas";
            this.citaVacunas.UseVisualStyleBackColor = false;
            // 
            // spaCitas
            // 
            this.spaCitas.BackColor = System.Drawing.Color.Black;
            this.spaCitas.ForeColor = System.Drawing.SystemColors.Control;
            this.spaCitas.Location = new System.Drawing.Point(592, 194);
            this.spaCitas.Name = "spaCitas";
            this.spaCitas.Size = new System.Drawing.Size(99, 23);
            this.spaCitas.TabIndex = 3;
            this.spaCitas.Text = "Spa";
            this.spaCitas.UseVisualStyleBackColor = false;
            // 
            // fechaRevision
            // 
            this.fechaRevision.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.fechaRevision.Location = new System.Drawing.Point(98, 168);
            this.fechaRevision.Name = "fechaRevision";
            this.fechaRevision.Size = new System.Drawing.Size(99, 20);
            this.fechaRevision.TabIndex = 8;
            // 
            // revisionCita
            // 
            this.revisionCita.BackColor = System.Drawing.Color.Black;
            this.revisionCita.ForeColor = System.Drawing.SystemColors.Control;
            this.revisionCita.Location = new System.Drawing.Point(98, 194);
            this.revisionCita.Name = "revisionCita";
            this.revisionCita.Size = new System.Drawing.Size(99, 23);
            this.revisionCita.TabIndex = 0;
            this.revisionCita.Text = "Revisión";
            this.revisionCita.UseVisualStyleBackColor = false;
            this.revisionCita.Click += new System.EventHandler(this.revisionCita_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker2.Location = new System.Drawing.Point(425, 168);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker3.Location = new System.Drawing.Point(592, 168);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker3.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Veterinario2020.Properties.Resources.icons8_user_64px;
            this.button3.Location = new System.Drawing.Point(719, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 64);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Veterinario2020.Properties.Resources.login1;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.retrocesoBoton);
            this.tabPage2.Controls.Add(this.vacunaMascota);
            this.tabPage2.Controls.Add(this.dueñoMascota);
            this.tabPage2.Controls.Add(this.edadMascota);
            this.tabPage2.Controls.Add(this.nombreMascota);
            this.tabPage2.Controls.Add(this.muestraMascota);
            this.tabPage2.Controls.Add(this.pictureBoxMascota);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // retrocesoBoton
            // 
            this.retrocesoBoton.BackColor = System.Drawing.Color.Black;
            this.retrocesoBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.retrocesoBoton.ForeColor = System.Drawing.SystemColors.Control;
            this.retrocesoBoton.Location = new System.Drawing.Point(8, 223);
            this.retrocesoBoton.Name = "retrocesoBoton";
            this.retrocesoBoton.Size = new System.Drawing.Size(75, 23);
            this.retrocesoBoton.TabIndex = 7;
            this.retrocesoBoton.Text = "Anterior";
            this.retrocesoBoton.UseVisualStyleBackColor = false;
            this.retrocesoBoton.Click += new System.EventHandler(this.retrocesoBoton_Click);
            // 
            // vacunaMascota
            // 
            this.vacunaMascota.AutoSize = true;
            this.vacunaMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacunaMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.vacunaMascota.Location = new System.Drawing.Point(198, 161);
            this.vacunaMascota.Name = "vacunaMascota";
            this.vacunaMascota.Size = new System.Drawing.Size(47, 15);
            this.vacunaMascota.TabIndex = 5;
            this.vacunaMascota.Text = "label4";
            // 
            // dueñoMascota
            // 
            this.dueñoMascota.AutoSize = true;
            this.dueñoMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueñoMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.dueñoMascota.Location = new System.Drawing.Point(198, 117);
            this.dueñoMascota.Name = "dueñoMascota";
            this.dueñoMascota.Size = new System.Drawing.Size(47, 15);
            this.dueñoMascota.TabIndex = 4;
            this.dueñoMascota.Text = "label3";
            // 
            // edadMascota
            // 
            this.edadMascota.AutoSize = true;
            this.edadMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.edadMascota.Location = new System.Drawing.Point(198, 73);
            this.edadMascota.Name = "edadMascota";
            this.edadMascota.Size = new System.Drawing.Size(47, 15);
            this.edadMascota.TabIndex = 3;
            this.edadMascota.Text = "label2";
            // 
            // nombreMascota
            // 
            this.nombreMascota.AutoSize = true;
            this.nombreMascota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreMascota.Location = new System.Drawing.Point(198, 31);
            this.nombreMascota.Name = "nombreMascota";
            this.nombreMascota.Size = new System.Drawing.Size(47, 15);
            this.nombreMascota.TabIndex = 2;
            this.nombreMascota.Text = "label1";
            // 
            // muestraMascota
            // 
            this.muestraMascota.BackColor = System.Drawing.Color.Black;
            this.muestraMascota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muestraMascota.ForeColor = System.Drawing.SystemColors.Control;
            this.muestraMascota.Location = new System.Drawing.Point(99, 223);
            this.muestraMascota.Name = "muestraMascota";
            this.muestraMascota.Size = new System.Drawing.Size(75, 23);
            this.muestraMascota.TabIndex = 1;
            this.muestraMascota.Text = "Siguiente";
            this.muestraMascota.UseVisualStyleBackColor = false;
            this.muestraMascota.Click += new System.EventHandler(this.muestraMascota_Click);
            // 
            // pictureBoxMascota
            // 
            this.pictureBoxMascota.Location = new System.Drawing.Point(8, 31);
            this.pictureBoxMascota.Name = "pictureBoxMascota";
            this.pictureBoxMascota.Size = new System.Drawing.Size(166, 143);
            this.pictureBoxMascota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMascota.TabIndex = 0;
            this.pictureBoxMascota.TabStop = false;
            // 
            // pictureBoxSpa
            // 
            this.pictureBoxSpa.BackgroundImage = global::Veterinario2020.Properties.Resources.icons8_wooden_massage_table_80px;
            this.pictureBoxSpa.Location = new System.Drawing.Point(592, 65);
            this.pictureBoxSpa.Name = "pictureBoxSpa";
            this.pictureBoxSpa.Size = new System.Drawing.Size(99, 94);
            this.pictureBoxSpa.TabIndex = 7;
            this.pictureBoxSpa.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Veterinario2020.Properties.Resources.icons8_syringe_96px;
            this.pictureBox3.Location = new System.Drawing.Point(425, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 94);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Veterinario2020.Properties.Resources.icons8_barber_chair_96px;
            this.pictureBox2.Location = new System.Drawing.Point(265, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 94);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Veterinario2020.Properties.Resources.icons8_veterinarian_female_96px;
            this.pictureBox1.Location = new System.Drawing.Point(98, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 94);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Si deseas añadir una nueva mascota por favor presentate en uno de nuestros centro" +
    "s más cercanos y encantados le haremos un chequeo y los datos pertinentes :)";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "Veterinario";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxMascota;
        private System.Windows.Forms.Button muestraMascota;
        private System.Windows.Forms.Label edadMascota;
        private System.Windows.Forms.Label nombreMascota;
        private System.Windows.Forms.Label vacunaMascota;
        private System.Windows.Forms.Label dueñoMascota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button retrocesoBoton;
        private System.Windows.Forms.MonthCalendar calendarioCitas;
        private System.Windows.Forms.PictureBox pictureBoxSpa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button spaCitas;
        private System.Windows.Forms.Button citaVacunas;
        private System.Windows.Forms.Button peluqueriaCita;
        private System.Windows.Forms.Button revisionCita;
        private System.Windows.Forms.DateTimePicker fechaRevision;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}

