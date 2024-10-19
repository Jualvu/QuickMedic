namespace PSDemo
{
    partial class Principal
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
            this.button_CerrarSesion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Inicio = new System.Windows.Forms.Button();
            this.panelDock = new System.Windows.Forms.Panel();
            this.panelLateralPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView_Medicamentos = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtdia = new System.Windows.Forms.Label();
            this.txtReloj = new System.Windows.Forms.Label();
            this.picBox_CerrarPrograma = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.hora_dia = new System.Windows.Forms.Timer(this.components);
            this.alarma_Principal = new System.Windows.Forms.Timer(this.components);
            this.panelLateralPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicamentos)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CerrarPrograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_CerrarSesion
            // 
            this.button_CerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.button_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.button_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CerrarSesion.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.button_CerrarSesion.Location = new System.Drawing.Point(63, 494);
            this.button_CerrarSesion.Name = "button_CerrarSesion";
            this.button_CerrarSesion.Size = new System.Drawing.Size(147, 62);
            this.button_CerrarSesion.TabIndex = 4;
            this.button_CerrarSesion.Text = "Cerrar Sesión";
            this.button_CerrarSesion.UseVisualStyleBackColor = false;
            this.button_CerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(63, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Ajustes de Usuario";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnAjustesUsuario);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(63, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Medicamentos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnMedicamentos);
            // 
            // button_Inicio
            // 
            this.button_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.button_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Inicio.CausesValidation = false;
            this.button_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Inicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Inicio.FlatAppearance.BorderSize = 0;
            this.button_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Inicio.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inicio.ForeColor = System.Drawing.Color.White;
            this.button_Inicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Inicio.Location = new System.Drawing.Point(63, 43);
            this.button_Inicio.Name = "button_Inicio";
            this.button_Inicio.Size = new System.Drawing.Size(82, 49);
            this.button_Inicio.TabIndex = 1;
            this.button_Inicio.Text = "Inicio";
            this.button_Inicio.UseVisualStyleBackColor = false;
            this.button_Inicio.Click += new System.EventHandler(this.btnInicio);
            // 
            // panelDock
            // 
            this.panelDock.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDock.Location = new System.Drawing.Point(216, 77);
            this.panelDock.Name = "panelDock";
            this.panelDock.Size = new System.Drawing.Size(1035, 597);
            this.panelDock.TabIndex = 2;
            // 
            // panelLateralPrincipal
            // 
            this.panelLateralPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLateralPrincipal.Controls.Add(this.pictureBox4);
            this.panelLateralPrincipal.Controls.Add(this.pictureBox3);
            this.panelLateralPrincipal.Controls.Add(this.pictureBox2);
            this.panelLateralPrincipal.Controls.Add(this.pictureBox1);
            this.panelLateralPrincipal.Controls.Add(this.button_CerrarSesion);
            this.panelLateralPrincipal.Controls.Add(this.button_Inicio);
            this.panelLateralPrincipal.Controls.Add(this.button3);
            this.panelLateralPrincipal.Controls.Add(this.button2);
            this.panelLateralPrincipal.Controls.Add(this.dataGridView_Medicamentos);
            this.panelLateralPrincipal.Location = new System.Drawing.Point(0, 77);
            this.panelLateralPrincipal.Name = "panelLateralPrincipal";
            this.panelLateralPrincipal.Size = new System.Drawing.Size(217, 597);
            this.panelLateralPrincipal.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PSDemo.Properties.Resources.exit;
            this.pictureBox4.Location = new System.Drawing.Point(22, 509);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PSDemo.Properties.Resources.ajustes2;
            this.pictureBox3.Location = new System.Drawing.Point(22, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PSDemo.Properties.Resources.pill;
            this.pictureBox2.Location = new System.Drawing.Point(22, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSDemo.Properties.Resources.home_1_1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView_Medicamentos
            // 
            this.dataGridView_Medicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Medicamentos.Location = new System.Drawing.Point(25, 367);
            this.dataGridView_Medicamentos.Name = "dataGridView_Medicamentos";
            this.dataGridView_Medicamentos.Size = new System.Drawing.Size(169, 82);
            this.dataGridView_Medicamentos.TabIndex = 13;
            this.dataGridView_Medicamentos.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.panelTop.Controls.Add(this.txtdia);
            this.panelTop.Controls.Add(this.txtReloj);
            this.panelTop.Controls.Add(this.picBox_CerrarPrograma);
            this.panelTop.Controls.Add(this.Logo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1251, 77);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // txtdia
            // 
            this.txtdia.AutoSize = true;
            this.txtdia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.txtdia.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdia.ForeColor = System.Drawing.Color.White;
            this.txtdia.Location = new System.Drawing.Point(1056, 25);
            this.txtdia.Name = "txtdia";
            this.txtdia.Size = new System.Drawing.Size(0, 25);
            this.txtdia.TabIndex = 8;
            // 
            // txtReloj
            // 
            this.txtReloj.AutoSize = true;
            this.txtReloj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.txtReloj.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReloj.ForeColor = System.Drawing.Color.White;
            this.txtReloj.Location = new System.Drawing.Point(972, 25);
            this.txtReloj.Name = "txtReloj";
            this.txtReloj.Size = new System.Drawing.Size(0, 25);
            this.txtReloj.TabIndex = 7;
            // 
            // picBox_CerrarPrograma
            // 
            this.picBox_CerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox_CerrarPrograma.Image = global::PSDemo.Properties.Resources.x_Roja2;
            this.picBox_CerrarPrograma.Location = new System.Drawing.Point(1191, 25);
            this.picBox_CerrarPrograma.Name = "picBox_CerrarPrograma";
            this.picBox_CerrarPrograma.Size = new System.Drawing.Size(29, 29);
            this.picBox_CerrarPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_CerrarPrograma.TabIndex = 6;
            this.picBox_CerrarPrograma.TabStop = false;
            this.picBox_CerrarPrograma.Click += new System.EventHandler(this.picBox_CerrarPrograma_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::PSDemo.Properties.Resources.LogoQuickMedic2;
            this.Logo.Location = new System.Drawing.Point(22, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(273, 74);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // hora_dia
            // 
            this.hora_dia.Enabled = true;
            this.hora_dia.Interval = 1000;
            this.hora_dia.Tick += new System.EventHandler(this.hora_dia_Tick);
            // 
            // alarma_Principal
            // 
            this.alarma_Principal.Enabled = true;
            this.alarma_Principal.Interval = 1000;
            this.alarma_Principal.Tick += new System.EventHandler(this.alarma_Principal_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1251, 674);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelDock);
            this.Controls.Add(this.panelLateralPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickMedic";
            this.panelLateralPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicamentos)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CerrarPrograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_CerrarSesion;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Inicio;
        private System.Windows.Forms.Panel panelDock;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panelLateralPrincipal;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBox_CerrarPrograma;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer hora_dia;
        private System.Windows.Forms.Label txtdia;
        private System.Windows.Forms.Label txtReloj;
        private System.Windows.Forms.DataGridView dataGridView_Medicamentos;
        private System.Windows.Forms.Timer alarma_Principal;
    }
}

