namespace WindowsFormsApp1
{
    partial class Cliente3
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtNroCliente = new System.Windows.Forms.TextBox();
			this.txtApe = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv1
			// 
			this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv1.Location = new System.Drawing.Point(20, 212);
			this.dgv1.Name = "dgv1";
			this.dgv1.Size = new System.Drawing.Size(405, 150);
			this.dgv1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(16, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Estado de Reclamo";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(350, 368);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 31);
			this.button1.TabIndex = 2;
			this.button1.Text = "Volver";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.txtNroCliente);
			this.groupBox2.Controls.Add(this.txtApe);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtNombre);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox2.Location = new System.Drawing.Point(106, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(233, 140);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos del Cliente";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(29, 98);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(81, 16);
			this.label11.TabIndex = 34;
			this.label11.Text = "Nro Cliente";
			// 
			// txtNroCliente
			// 
			this.txtNroCliente.Location = new System.Drawing.Point(114, 97);
			this.txtNroCliente.Margin = new System.Windows.Forms.Padding(2);
			this.txtNroCliente.Name = "txtNroCliente";
			this.txtNroCliente.Size = new System.Drawing.Size(100, 23);
			this.txtNroCliente.TabIndex = 33;
			// 
			// txtApe
			// 
			this.txtApe.Location = new System.Drawing.Point(114, 62);
			this.txtApe.Name = "txtApe";
			this.txtApe.Size = new System.Drawing.Size(100, 23);
			this.txtApe.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(31, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 16);
			this.label3.TabIndex = 1;
			this.label3.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(114, 27);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 23);
			this.txtNombre.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.Control;
			this.button2.Location = new System.Drawing.Point(190, 146);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(65, 43);
			this.button2.TabIndex = 29;
			this.button2.Text = "Validar";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Cliente3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(449, 411);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Cliente3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RECLAMOS";
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNroCliente;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button2;
    }
}