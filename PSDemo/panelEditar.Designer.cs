namespace PSDemo
{
    partial class panelEditar
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
            this.button_editarMedicamento = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.picBox_CerrarVentanaEditar = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Minutos = new System.Windows.Forms.TextBox();
            this.textBox_Hora = new System.Windows.Forms.TextBox();
            this.comboBox_Dias = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NuevoNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Comentario = new System.Windows.Forms.TextBox();
            this.textBox_Dosis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CerrarVentanaEditar)).BeginInit();
            this.SuspendLayout();
            // 
            // button_editarMedicamento
            // 
            this.button_editarMedicamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.button_editarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarMedicamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarMedicamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editarMedicamento.ForeColor = System.Drawing.Color.White;
            this.button_editarMedicamento.Location = new System.Drawing.Point(230, 275);
            this.button_editarMedicamento.Name = "button_editarMedicamento";
            this.button_editarMedicamento.Size = new System.Drawing.Size(125, 29);
            this.button_editarMedicamento.TabIndex = 14;
            this.button_editarMedicamento.Text = "Editar";
            this.button_editarMedicamento.UseVisualStyleBackColor = false;
            this.button_editarMedicamento.Click += new System.EventHandler(this.button_editarMedicamento_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(116, 13);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(314, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Editar Medicamento";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseDown);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.panel_Title.Controls.Add(this.picBox_CerrarVentanaEditar);
            this.panel_Title.Controls.Add(this.label_Title);
            this.panel_Title.Location = new System.Drawing.Point(1, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Size = new System.Drawing.Size(580, 66);
            this.panel_Title.TabIndex = 1;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(441, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 21);
            this.label7.TabIndex = 34;
            this.label7.Text = ":";
            // 
            // textBox_Minutos
            // 
            this.textBox_Minutos.Location = new System.Drawing.Point(454, 216);
            this.textBox_Minutos.Name = "textBox_Minutos";
            this.textBox_Minutos.Size = new System.Drawing.Size(42, 20);
            this.textBox_Minutos.TabIndex = 33;
            // 
            // textBox_Hora
            // 
            this.textBox_Hora.Location = new System.Drawing.Point(397, 216);
            this.textBox_Hora.Name = "textBox_Hora";
            this.textBox_Hora.Size = new System.Drawing.Size(42, 20);
            this.textBox_Hora.TabIndex = 32;
            // 
            // comboBox_Dias
            // 
            this.comboBox_Dias.FormattingEnabled = true;
            this.comboBox_Dias.Items.AddRange(new object[] {
            "lunes",
            "martes",
            "miércoles",
            "jueves",
            "viernes",
            "sábado",
            "domingo"});
            this.comboBox_Dias.Location = new System.Drawing.Point(397, 156);
            this.comboBox_Dias.Name = "comboBox_Dias";
            this.comboBox_Dias.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Dias.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(393, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(393, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Día";
            // 
            // textBox_NuevoNombre
            // 
            this.textBox_NuevoNombre.Location = new System.Drawing.Point(53, 122);
            this.textBox_NuevoNombre.Name = "textBox_NuevoNombre";
            this.textBox_NuevoNombre.Size = new System.Drawing.Size(292, 20);
            this.textBox_NuevoNombre.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nuevo Nombre";
            // 
            // textBox_Comentario
            // 
            this.textBox_Comentario.Location = new System.Drawing.Point(53, 216);
            this.textBox_Comentario.Name = "textBox_Comentario";
            this.textBox_Comentario.Size = new System.Drawing.Size(292, 20);
            this.textBox_Comentario.TabIndex = 26;
            // 
            // textBox_Dosis
            // 
            this.textBox_Dosis.Location = new System.Drawing.Point(53, 169);
            this.textBox_Dosis.Name = "textBox_Dosis";
            this.textBox_Dosis.Size = new System.Drawing.Size(292, 20);
            this.textBox_Dosis.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Comentario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(49, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dosis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(391, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "Formato 24hrs";
            // 
            // panelEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(578, 338);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Minutos);
            this.Controls.Add(this.textBox_Hora);
            this.Controls.Add(this.comboBox_Dias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_NuevoNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Comentario);
            this.Controls.Add(this.textBox_Dosis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_editarMedicamento);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "panelEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "panelEditar";
            this.panel_Title.ResumeLayout(false);
            this.panel_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_CerrarVentanaEditar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_editarMedicamento;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Title;
        private System.Windows.Forms.PictureBox picBox_CerrarVentanaEditar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Minutos;
        private System.Windows.Forms.TextBox textBox_Hora;
        private System.Windows.Forms.ComboBox comboBox_Dias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NuevoNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Comentario;
        private System.Windows.Forms.TextBox textBox_Dosis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}