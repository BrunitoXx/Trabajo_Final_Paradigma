﻿namespace WindowsFormsApp1
{
    partial class Gerente2
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
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.btnVolver = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTipoeclamo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtFecha1 = new System.Windows.Forms.TextBox();
			this.txtFecha2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtAltura = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCalle = new System.Windows.Forms.TextBox();
			this.txtPiso = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.comboBoxCuadrillas = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtHerramientas = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv1
			// 
			this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv1.Location = new System.Drawing.Point(95, 57);
			this.dgv1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgv1.Name = "dgv1";
			this.dgv1.RowTemplate.Height = 28;
			this.dgv1.Size = new System.Drawing.Size(323, 103);
			this.dgv1.TabIndex = 0;
			this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
			this.btnVolver.Location = new System.Drawing.Point(649, 421);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(71, 40);
			this.btnVolver.TabIndex = 1;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(249, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Detalles de Atencion";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(2, 20);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Tipo de Reclamo";
			// 
			// txtTipoeclamo
			// 
			this.txtTipoeclamo.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipoeclamo.Location = new System.Drawing.Point(195, 20);
			this.txtTipoeclamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTipoeclamo.Name = "txtTipoeclamo";
			this.txtTipoeclamo.Size = new System.Drawing.Size(159, 21);
			this.txtTipoeclamo.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(2, 57);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(189, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Fecha y Hora de Reclamo:";
			// 
			// txtFecha1
			// 
			this.txtFecha1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha1.Location = new System.Drawing.Point(195, 57);
			this.txtFecha1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtFecha1.Name = "txtFecha1";
			this.txtFecha1.Size = new System.Drawing.Size(159, 21);
			this.txtFecha1.TabIndex = 10;
			// 
			// txtFecha2
			// 
			this.txtFecha2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFecha2.Location = new System.Drawing.Point(195, 97);
			this.txtFecha2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtFecha2.Name = "txtFecha2";
			this.txtFecha2.Size = new System.Drawing.Size(159, 21);
			this.txtFecha2.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(2, 97);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(181, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Fecha y Hora de Solucion";
			// 
			// txtAltura
			// 
			this.txtAltura.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAltura.Location = new System.Drawing.Point(88, 8);
			this.txtAltura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAltura.Name = "txtAltura";
			this.txtAltura.Size = new System.Drawing.Size(68, 21);
			this.txtAltura.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 12);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 14;
			this.label5.Text = "Altura";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(17, 40);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 17);
			this.label6.TabIndex = 15;
			this.label6.Text = "Calle";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(17, 66);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 17);
			this.label7.TabIndex = 16;
			this.label7.Text = "Piso";
			// 
			// txtCalle
			// 
			this.txtCalle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalle.Location = new System.Drawing.Point(88, 36);
			this.txtCalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCalle.Name = "txtCalle";
			this.txtCalle.Size = new System.Drawing.Size(98, 21);
			this.txtCalle.TabIndex = 17;
			// 
			// txtPiso
			// 
			this.txtPiso.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPiso.Location = new System.Drawing.Point(88, 66);
			this.txtPiso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPiso.Name = "txtPiso";
			this.txtPiso.Size = new System.Drawing.Size(68, 21);
			this.txtPiso.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(2, 18);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(149, 17);
			this.label8.TabIndex = 19;
			this.label8.Text = "Cuadrillas Afectadas";
			// 
			// comboBoxCuadrillas
			// 
			this.comboBoxCuadrillas.FormattingEnabled = true;
			this.comboBoxCuadrillas.Location = new System.Drawing.Point(148, 15);
			this.comboBoxCuadrillas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.comboBoxCuadrillas.Name = "comboBoxCuadrillas";
			this.comboBoxCuadrillas.Size = new System.Drawing.Size(127, 23);
			this.comboBoxCuadrillas.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.Control;
			this.label9.Location = new System.Drawing.Point(5, 58);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(75, 17);
			this.label9.TabIndex = 21;
			this.label9.Text = "Vehiculos";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.Control;
			this.label10.Location = new System.Drawing.Point(442, 20);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(165, 17);
			this.label10.TabIndex = 22;
			this.label10.Text = "Herramientas utilizadas";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtAltura);
			this.panel1.Controls.Add(this.txtCalle);
			this.panel1.Controls.Add(this.txtPiso);
			this.panel1.ForeColor = System.Drawing.SystemColors.Control;
			this.panel1.Location = new System.Drawing.Point(425, 55);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(187, 95);
			this.panel1.TabIndex = 24;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.Controls.Add(this.txtFecha2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtFecha1);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtTipoeclamo);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(16, 55);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(387, 139);
			this.panel2.TabIndex = 25;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Transparent;
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.comboBoxCuadrillas);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.txtHerramientas);
			this.panel3.Controls.Add(this.dgv1);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel3.Location = new System.Drawing.Point(16, 238);
			this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(693, 179);
			this.panel3.TabIndex = 26;
			// 
			// txtHerramientas
			// 
			this.txtHerramientas.Location = new System.Drawing.Point(445, 44);
			this.txtHerramientas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtHerramientas.Multiline = true;
			this.txtHerramientas.Name = "txtHerramientas";
			this.txtHerramientas.Size = new System.Drawing.Size(231, 103);
			this.txtHerramientas.TabIndex = 23;
			// 
			// Gerente2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(739, 469);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVolver);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Gerente2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Secheep";
			this.Load += new System.EventHandler(this.Gerente2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipoeclamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha1;
        private System.Windows.Forms.TextBox txtFecha2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxCuadrillas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHerramientas;
    }
}