namespace WindowsFormsApp1
{
    partial class Empleado3
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv1
			// 
			this.dgv1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv1.Location = new System.Drawing.Point(38, 69);
			this.dgv1.Margin = new System.Windows.Forms.Padding(2);
			this.dgv1.Name = "dgv1";
			this.dgv1.RowTemplate.Height = 28;
			this.dgv1.Size = new System.Drawing.Size(527, 149);
			this.dgv1.TabIndex = 0;
			this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick_1);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(374, 236);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 44);
			this.button1.TabIndex = 1;
			this.button1.Text = "Solucionado";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(177, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "Reclamos En Tramite";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button3.Location = new System.Drawing.Point(490, 236);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 44);
			this.button3.TabIndex = 5;
			this.button3.Text = "Volver";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Empleado3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(607, 313);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgv1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Empleado3";
			this.Text = "Secheep";
			this.Load += new System.EventHandler(this.Empleado3_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
	}
}