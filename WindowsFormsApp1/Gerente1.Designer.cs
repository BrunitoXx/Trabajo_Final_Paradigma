namespace WindowsFormsApp1
{
    partial class Gerente1
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
			this.label3 = new System.Windows.Forms.Label();
			this.dgv2 = new System.Windows.Forms.DataGridView();
			this.dgv3 = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.dgv4 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv1
			// 
			this.dgv1.AllowUserToAddRows = false;
			this.dgv1.AllowUserToDeleteRows = false;
			this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv1.Location = new System.Drawing.Point(39, 41);
			this.dgv1.Margin = new System.Windows.Forms.Padding(2);
			this.dgv1.Name = "dgv1";
			this.dgv1.ReadOnly = true;
			this.dgv1.RowTemplate.Height = 28;
			this.dgv1.Size = new System.Drawing.Size(1020, 106);
			this.dgv1.TabIndex = 2;
			this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick_1);
			// 
			// btnVolver
			// 
			this.btnVolver.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnVolver.Location = new System.Drawing.Point(1260, 601);
			this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
			this.btnVolver.Name = "btnVolver";
			this.btnVolver.Size = new System.Drawing.Size(71, 44);
			this.btnVolver.TabIndex = 3;
			this.btnVolver.Text = "Volver";
			this.btnVolver.UseVisualStyleBackColor = false;
			this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(34, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 30);
			this.label1.TabIndex = 5;
			this.label1.Text = "Clientes:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(34, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 30);
			this.label3.TabIndex = 7;
			this.label3.Text = "Empleados:";
			// 
			// dgv2
			// 
			this.dgv2.AllowUserToAddRows = false;
			this.dgv2.AllowUserToDeleteRows = false;
			this.dgv2.AllowUserToOrderColumns = true;
			this.dgv2.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv2.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv2.Location = new System.Drawing.Point(39, 181);
			this.dgv2.Margin = new System.Windows.Forms.Padding(2);
			this.dgv2.Name = "dgv2";
			this.dgv2.ReadOnly = true;
			this.dgv2.RowTemplate.Height = 28;
			this.dgv2.Size = new System.Drawing.Size(1020, 106);
			this.dgv2.TabIndex = 8;
			this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
			// 
			// dgv3
			// 
			this.dgv3.AllowUserToAddRows = false;
			this.dgv3.AllowUserToDeleteRows = false;
			this.dgv3.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv3.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv3.Location = new System.Drawing.Point(39, 324);
			this.dgv3.Margin = new System.Windows.Forms.Padding(2);
			this.dgv3.Name = "dgv3";
			this.dgv3.ReadOnly = true;
			this.dgv3.RowTemplate.Height = 28;
			this.dgv3.Size = new System.Drawing.Size(1020, 106);
			this.dgv3.TabIndex = 10;
			this.dgv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellContentClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(34, 292);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(135, 30);
			this.label4.TabIndex = 9;
			this.label4.Text = "Reclamos:";
			// 
			// dgv4
			// 
			this.dgv4.AllowUserToAddRows = false;
			this.dgv4.AllowUserToDeleteRows = false;
			this.dgv4.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv4.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv4.Location = new System.Drawing.Point(39, 473);
			this.dgv4.Margin = new System.Windows.Forms.Padding(2);
			this.dgv4.Name = "dgv4";
			this.dgv4.ReadOnly = true;
			this.dgv4.RowTemplate.Height = 28;
			this.dgv4.Size = new System.Drawing.Size(1020, 141);
			this.dgv4.TabIndex = 12;
			this.dgv4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv4_CellContentClick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(34, 441);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 30);
			this.label5.TabIndex = 11;
			this.label5.Text = "Vehiculos:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(1064, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(276, 48);
			this.label2.TabIndex = 14;
			this.label2.Text = "Se puede Borrar un registro \r\ndandole Doble Click";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label6.Location = new System.Drawing.Point(1064, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 24);
			this.label6.TabIndex = 15;
			this.label6.Text = "Atencion!";
			// 
			// Gerente1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1351, 656);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dgv4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgv3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dgv2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVolver);
			this.Controls.Add(this.dgv1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Gerente1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gerente";
			this.Load += new System.EventHandler(this.Gerente1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgv2;
		private System.Windows.Forms.DataGridView dgv3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgv4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
	}
}