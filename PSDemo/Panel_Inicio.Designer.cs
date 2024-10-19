namespace PSDemo
{
    partial class Panel_Inicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Container = new System.Windows.Forms.Panel();
            this.lbl_Dia = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.panel_esconder1 = new System.Windows.Forms.Panel();
            this.dataGridView_Medicamentos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Container
            // 
            this.panel_Container.AutoSize = true;
            this.panel_Container.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Container.Controls.Add(this.lbl_Dia);
            this.panel_Container.Controls.Add(this.lbl_Hora);
            this.panel_Container.Controls.Add(this.panel_esconder1);
            this.panel_Container.Controls.Add(this.dataGridView_Medicamentos);
            this.panel_Container.Controls.Add(this.pictureBox1);
            this.panel_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Container.Location = new System.Drawing.Point(0, 0);
            this.panel_Container.Name = "panel_Container";
            this.panel_Container.Size = new System.Drawing.Size(969, 592);
            this.panel_Container.TabIndex = 0;
            // 
            // lbl_Dia
            // 
            this.lbl_Dia.AutoSize = true;
            this.lbl_Dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dia.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Dia.Location = new System.Drawing.Point(811, 42);
            this.lbl_Dia.Name = "lbl_Dia";
            this.lbl_Dia.Size = new System.Drawing.Size(0, 18);
            this.lbl_Dia.TabIndex = 7;
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_Hora.Location = new System.Drawing.Point(679, 42);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 18);
            this.lbl_Hora.TabIndex = 6;
            // 
            // panel_esconder1
            // 
            this.panel_esconder1.Location = new System.Drawing.Point(0, 105);
            this.panel_esconder1.Name = "panel_esconder1";
            this.panel_esconder1.Size = new System.Drawing.Size(124, 475);
            this.panel_esconder1.TabIndex = 5;
            // 
            // dataGridView_Medicamentos
            // 
            this.dataGridView_Medicamentos.AllowUserToAddRows = false;
            this.dataGridView_Medicamentos.AllowUserToDeleteRows = false;
            this.dataGridView_Medicamentos.AllowUserToResizeColumns = false;
            this.dataGridView_Medicamentos.AllowUserToResizeRows = false;
            this.dataGridView_Medicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Medicamentos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Medicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Medicamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_Medicamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Medicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Medicamentos.ColumnHeadersHeight = 35;
            this.dataGridView_Medicamentos.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Medicamentos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Medicamentos.EnableHeadersVisualStyles = false;
            this.dataGridView_Medicamentos.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView_Medicamentos.Location = new System.Drawing.Point(-9, 105);
            this.dataGridView_Medicamentos.Name = "dataGridView_Medicamentos";
            this.dataGridView_Medicamentos.ReadOnly = true;
            this.dataGridView_Medicamentos.RowHeadersVisible = false;
            this.dataGridView_Medicamentos.RowHeadersWidth = 72;
            this.dataGridView_Medicamentos.RowTemplate.Height = 70;
            this.dataGridView_Medicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Medicamentos.Size = new System.Drawing.Size(916, 461);
            this.dataGridView_Medicamentos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSDemo.Properties.Resources.Recordatorios;
            this.pictureBox1.Location = new System.Drawing.Point(80, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(969, 592);
            this.Controls.Add(this.panel_Container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Panel_Inicio";
            this.Text = "Panel_Inicio";
            this.Load += new System.EventHandler(this.Panel_Inicio_Load);
            this.panel_Container.ResumeLayout(false);
            this.panel_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Medicamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Container;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_Medicamentos;
        private System.Windows.Forms.Panel panel_esconder1;
        private System.Windows.Forms.Label lbl_Dia;
        private System.Windows.Forms.Label lbl_Hora;
    }
}