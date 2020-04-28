namespace Veterinario2020
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.insertaUsuario = new System.Windows.Forms.Button();
            this.DNI = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // insertaUsuario
            // 
            this.insertaUsuario.Location = new System.Drawing.Point(171, 178);
            this.insertaUsuario.Name = "insertaUsuario";
            this.insertaUsuario.Size = new System.Drawing.Size(100, 31);
            this.insertaUsuario.TabIndex = 0;
            this.insertaUsuario.Text = "Crear";
            this.insertaUsuario.UseVisualStyleBackColor = true;
            this.insertaUsuario.Click += new System.EventHandler(this.insertaUsuario_Click);
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(104, 51);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(26, 13);
            this.DNI.TabIndex = 1;
            this.DNI.Text = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(101, 81);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Location = new System.Drawing.Point(104, 110);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(61, 13);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "Contraseña";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(171, 44);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(171, 74);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(171, 103);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass.TabIndex = 6;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.insertaUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertaUsuario;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}