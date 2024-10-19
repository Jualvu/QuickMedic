namespace PSDemo
{
    partial class Panel_editarUsuario
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
            this.panel_Title = new System.Windows.Forms.Panel();
            this.picBox_CerrarVentanaEditar = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_editarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Apellido1 = new System.Windows.Forms.TextBox();
            this.textBox_Apellido2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_NuevoNombre = new System.Windows.Forms.TextBox();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CerrarVentanaEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.panel_Title.Controls.Add(this.picBox_CerrarVentanaEditar);
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(580, 66);
            this.panel_Title.TabIndex = 2;
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            // 
            // picBox_CerrarVentanaEditar
            // 
            this.picBox_CerrarVentanaEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_CerrarVentanaEditar.Image = global::PSDemo.Properties.Resources.x_Roja2;
            this.picBox_CerrarVentanaEditar.Location = new System.Drawing.Point(536, 13);
            this.picBox_CerrarVentanaEditar.Name = "picBox_CerrarVentanaEditar";
            this.picBox_CerrarVentanaEditar.Size = new System.Drawing.Size(29, 29);
            this.picBox_CerrarVentanaEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_CerrarVentanaEditar.TabIndex = 8;
            this.picBox_CerrarVentanaEditar.TabStop = false;
            this.picBox_CerrarVentanaEditar.Click += new System.EventHandler(this.picBox_CerrarVentanaEditar_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(87, 13);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(381, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Editar datos de usuario";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseDown);
            // 
            // button_editarUsuario
            // 
            this.button_editarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.button_editarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editarUsuario.ForeColor = System.Drawing.Color.White;
            this.button_editarUsuario.Location = new System.Drawing.Point(215, 283);
            this.button_editarUsuario.Name = "button_editarUsuario";
            this.button_editarUsuario.Size = new System.Drawing.Size(125, 29);
            this.button_editarUsuario.TabIndex = 43;
            this.button_editarUsuario.Text = "Editar";
            this.button_editarUsuario.UseVisualStyleBackColor = false;
            this.button_editarUsuario.Click += new System.EventHandler(this.button_editarUsuario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Primer apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(141, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Segundo apellido";
            // 
            // textBox_Apellido1
            // 
            this.textBox_Apellido1.Location = new System.Drawing.Point(145, 184);
            this.textBox_Apellido1.Name = "textBox_Apellido1";
            this.textBox_Apellido1.Size = new System.Drawing.Size(292, 20);
            this.textBox_Apellido1.TabIndex = 46;
            this.textBox_Apellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Apellido1_KeyPress);
            // 
            // textBox_Apellido2
            // 
            this.textBox_Apellido2.Location = new System.Drawing.Point(145, 245);
            this.textBox_Apellido2.Name = "textBox_Apellido2";
            this.textBox_Apellido2.Size = new System.Drawing.Size(292, 20);
            this.textBox_Apellido2.TabIndex = 47;
            this.textBox_Apellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Apellido2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(141, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nuevo Nombre";
            // 
            // textBox_NuevoNombre
            // 
            this.textBox_NuevoNombre.Location = new System.Drawing.Point(145, 115);
            this.textBox_NuevoNombre.Name = "textBox_NuevoNombre";
            this.textBox_NuevoNombre.Size = new System.Drawing.Size(292, 20);
            this.textBox_NuevoNombre.TabIndex = 49;
            this.textBox_NuevoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NuevoNombre_KeyPress);
            // 
            // Panel_editarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(578, 338);
            this.Controls.Add(this.textBox_NuevoNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Apellido2);
            this.Controls.Add(this.textBox_Apellido1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_editarUsuario);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Panel_editarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel_editarUsuario";
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CerrarVentanaEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.PictureBox picBox_CerrarVentanaEditar;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_editarUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Apellido1;
        private System.Windows.Forms.TextBox textBox_Apellido2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_NuevoNombre;
    }
}