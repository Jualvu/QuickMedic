namespace PSDemo
{
    partial class Panel_editarPassword
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
            this.textBox_NuevaPassword2 = new System.Windows.Forms.TextBox();
            this.textBox_NuevaPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_editarPassword = new System.Windows.Forms.Button();
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
            this.panel_Title.TabIndex = 3;
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
            this.picBox_CerrarVentanaEditar.Click += new System.EventHandler(this.picBox_CerrarVentanaEditar_Click_1);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Yi Baiti", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.White;
            this.label_Title.Location = new System.Drawing.Point(126, 13);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(288, 40);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Editar Contraseña";
            this.label_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_Title_MouseDown_1);
            // 
            // textBox_NuevaPassword2
            // 
            this.textBox_NuevaPassword2.Location = new System.Drawing.Point(133, 208);
            this.textBox_NuevaPassword2.Name = "textBox_NuevaPassword2";
            this.textBox_NuevaPassword2.Size = new System.Drawing.Size(292, 20);
            this.textBox_NuevaPassword2.TabIndex = 54;
            // 
            // textBox_NuevaPassword
            // 
            this.textBox_NuevaPassword.Location = new System.Drawing.Point(133, 134);
            this.textBox_NuevaPassword.Name = "textBox_NuevaPassword";
            this.textBox_NuevaPassword.Size = new System.Drawing.Size(292, 20);
            this.textBox_NuevaPassword.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(129, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Confirmar contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(129, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Contraseña nueva";
            // 
            // button_editarPassword
            // 
            this.button_editarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(209)))));
            this.button_editarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_editarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_editarPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editarPassword.ForeColor = System.Drawing.Color.White;
            this.button_editarPassword.Location = new System.Drawing.Point(213, 270);
            this.button_editarPassword.Name = "button_editarPassword";
            this.button_editarPassword.Size = new System.Drawing.Size(125, 29);
            this.button_editarPassword.TabIndex = 50;
            this.button_editarPassword.Text = "Editar";
            this.button_editarPassword.UseVisualStyleBackColor = false;
            this.button_editarPassword.Click += new System.EventHandler(this.button_editarPassword_Click);
            // 
            // Panel_editarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(578, 338);
            this.Controls.Add(this.textBox_NuevaPassword2);
            this.Controls.Add(this.textBox_NuevaPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_editarPassword);
            this.Controls.Add(this.panel_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Panel_editarPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel_editarPassword";
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
        private System.Windows.Forms.TextBox textBox_NuevaPassword2;
        private System.Windows.Forms.TextBox textBox_NuevaPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_editarPassword;
    }
}