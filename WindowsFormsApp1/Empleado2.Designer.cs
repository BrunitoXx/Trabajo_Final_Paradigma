namespace WindowsFormsApp1
{
    partial class Empleado2
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
			this.txtFocos = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.txtNroEmpleado = new System.Windows.Forms.TextBox();
			this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
			this.checkCamioneta = new System.Windows.Forms.CheckBox();
			this.checkAuto = new System.Windows.Forms.CheckBox();
			this.checkGrua = new System.Windows.Forms.CheckBox();
			this.checkEscalera = new System.Windows.Forms.CheckBox();
			this.checkCajaHerramientas = new System.Windows.Forms.CheckBox();
			this.checkTransformador = new System.Windows.Forms.CheckBox();
			this.checkFocos = new System.Windows.Forms.CheckBox();
			this.checkPoste = new System.Windows.Forms.CheckBox();
			this.checkLlaves = new System.Windows.Forms.CheckBox();
			this.txtEscalera = new System.Windows.Forms.TextBox();
			this.checkPersonal = new System.Windows.Forms.CheckBox();
			this.comboBoxPersonalExtra = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dgv2 = new System.Windows.Forms.DataGridView();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtOtros = new System.Windows.Forms.TextBox();
			this.checkOtros = new System.Windows.Forms.CheckBox();
			this.txtLlaves = new System.Windows.Forms.TextBox();
			this.txtPoste = new System.Windows.Forms.TextBox();
			this.txtTransformador = new System.Windows.Forms.TextBox();
			this.txtCajaHerramientas = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCuadrilla = new System.Windows.Forms.TextBox();
			this.lblVerificar = new System.Windows.Forms.Label();
			this.btnVerificar = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.dgv1 = new System.Windows.Forms.DataGridView();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtFocos
			// 
			this.txtFocos.Location = new System.Drawing.Point(184, 161);
			this.txtFocos.Name = "txtFocos";
			this.txtFocos.ReadOnly = true;
			this.txtFocos.Size = new System.Drawing.Size(100, 23);
			this.txtFocos.TabIndex = 45;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(27, 24);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(221, 21);
			this.dateTimePicker1.TabIndex = 44;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnLimpiar.Location = new System.Drawing.Point(211, 468);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(82, 41);
			this.btnLimpiar.TabIndex = 41;
			this.btnLimpiar.Text = "Limpiar Campos";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnCancelar.Location = new System.Drawing.Point(115, 468);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(90, 41);
			this.btnCancelar.TabIndex = 40;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnConfirmar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnConfirmar.Location = new System.Drawing.Point(21, 468);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(88, 41);
			this.btnConfirmar.TabIndex = 39;
			this.btnConfirmar.Text = "Confirmar Atencion";
			this.btnConfirmar.UseVisualStyleBackColor = false;
			this.btnConfirmar.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtNroEmpleado
			// 
			this.txtNroEmpleado.Location = new System.Drawing.Point(136, 99);
			this.txtNroEmpleado.Name = "txtNroEmpleado";
			this.txtNroEmpleado.Size = new System.Drawing.Size(100, 23);
			this.txtNroEmpleado.TabIndex = 32;
			// 
			// txtApellidoEmpleado
			// 
			this.txtApellidoEmpleado.Location = new System.Drawing.Point(136, 63);
			this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
			this.txtApellidoEmpleado.Size = new System.Drawing.Size(100, 23);
			this.txtApellidoEmpleado.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(6, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 16);
			this.label3.TabIndex = 26;
			this.label3.Text = "N° de Empleado";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(6, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 25;
			this.label2.Text = "Apellido";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(6, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 16);
			this.label1.TabIndex = 24;
			this.label1.Text = "Nombre";
			// 
			// txtNombreEmpleado
			// 
			this.txtNombreEmpleado.Location = new System.Drawing.Point(136, 30);
			this.txtNombreEmpleado.Name = "txtNombreEmpleado";
			this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 23);
			this.txtNombreEmpleado.TabIndex = 23;
			// 
			// checkCamioneta
			// 
			this.checkCamioneta.AutoSize = true;
			this.checkCamioneta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkCamioneta.Location = new System.Drawing.Point(78, 23);
			this.checkCamioneta.Name = "checkCamioneta";
			this.checkCamioneta.Size = new System.Drawing.Size(99, 20);
			this.checkCamioneta.TabIndex = 46;
			this.checkCamioneta.Text = "Camioneta";
			this.checkCamioneta.UseVisualStyleBackColor = true;
			this.checkCamioneta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// checkAuto
			// 
			this.checkAuto.AutoSize = true;
			this.checkAuto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkAuto.Location = new System.Drawing.Point(15, 23);
			this.checkAuto.Name = "checkAuto";
			this.checkAuto.Size = new System.Drawing.Size(57, 20);
			this.checkAuto.TabIndex = 47;
			this.checkAuto.Text = "Auto";
			this.checkAuto.UseVisualStyleBackColor = true;
			this.checkAuto.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// checkGrua
			// 
			this.checkGrua.AutoSize = true;
			this.checkGrua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkGrua.Location = new System.Drawing.Point(188, 22);
			this.checkGrua.Name = "checkGrua";
			this.checkGrua.Size = new System.Drawing.Size(60, 20);
			this.checkGrua.TabIndex = 48;
			this.checkGrua.Text = "Grua";
			this.checkGrua.UseVisualStyleBackColor = true;
			this.checkGrua.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
			// 
			// checkEscalera
			// 
			this.checkEscalera.AutoSize = true;
			this.checkEscalera.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkEscalera.Location = new System.Drawing.Point(16, 30);
			this.checkEscalera.Name = "checkEscalera";
			this.checkEscalera.Size = new System.Drawing.Size(83, 20);
			this.checkEscalera.TabIndex = 49;
			this.checkEscalera.Text = "Escalera";
			this.checkEscalera.UseVisualStyleBackColor = true;
			this.checkEscalera.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
			// 
			// checkCajaHerramientas
			// 
			this.checkCajaHerramientas.AutoSize = true;
			this.checkCajaHerramientas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkCajaHerramientas.Location = new System.Drawing.Point(16, 63);
			this.checkCajaHerramientas.Name = "checkCajaHerramientas";
			this.checkCajaHerramientas.Size = new System.Drawing.Size(171, 20);
			this.checkCajaHerramientas.TabIndex = 50;
			this.checkCajaHerramientas.Text = "Caja de Herramientas";
			this.checkCajaHerramientas.UseVisualStyleBackColor = true;
			this.checkCajaHerramientas.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
			// 
			// checkTransformador
			// 
			this.checkTransformador.AutoSize = true;
			this.checkTransformador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkTransformador.Location = new System.Drawing.Point(16, 99);
			this.checkTransformador.Name = "checkTransformador";
			this.checkTransformador.Size = new System.Drawing.Size(121, 20);
			this.checkTransformador.TabIndex = 51;
			this.checkTransformador.Text = "Transformador";
			this.checkTransformador.UseVisualStyleBackColor = true;
			this.checkTransformador.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
			// 
			// checkFocos
			// 
			this.checkFocos.AutoSize = true;
			this.checkFocos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkFocos.Location = new System.Drawing.Point(16, 166);
			this.checkFocos.Name = "checkFocos";
			this.checkFocos.Size = new System.Drawing.Size(63, 20);
			this.checkFocos.TabIndex = 52;
			this.checkFocos.Text = "Focos";
			this.checkFocos.UseVisualStyleBackColor = true;
			this.checkFocos.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
			// 
			// checkPoste
			// 
			this.checkPoste.AutoSize = true;
			this.checkPoste.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkPoste.Location = new System.Drawing.Point(16, 132);
			this.checkPoste.Name = "checkPoste";
			this.checkPoste.Size = new System.Drawing.Size(60, 20);
			this.checkPoste.TabIndex = 53;
			this.checkPoste.Text = "Poste";
			this.checkPoste.UseVisualStyleBackColor = true;
			this.checkPoste.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
			// 
			// checkLlaves
			// 
			this.checkLlaves.AutoSize = true;
			this.checkLlaves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkLlaves.Location = new System.Drawing.Point(16, 203);
			this.checkLlaves.Name = "checkLlaves";
			this.checkLlaves.Size = new System.Drawing.Size(67, 20);
			this.checkLlaves.TabIndex = 54;
			this.checkLlaves.Text = "Llaves";
			this.checkLlaves.UseVisualStyleBackColor = true;
			this.checkLlaves.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
			// 
			// txtEscalera
			// 
			this.txtEscalera.Location = new System.Drawing.Point(184, 28);
			this.txtEscalera.Name = "txtEscalera";
			this.txtEscalera.ReadOnly = true;
			this.txtEscalera.Size = new System.Drawing.Size(100, 23);
			this.txtEscalera.TabIndex = 55;
			// 
			// checkPersonal
			// 
			this.checkPersonal.AutoSize = true;
			this.checkPersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkPersonal.Location = new System.Drawing.Point(18, 30);
			this.checkPersonal.Name = "checkPersonal";
			this.checkPersonal.Size = new System.Drawing.Size(38, 20);
			this.checkPersonal.TabIndex = 57;
			this.checkPersonal.Text = "SI";
			this.checkPersonal.UseVisualStyleBackColor = true;
			this.checkPersonal.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
			// 
			// comboBoxPersonalExtra
			// 
			this.comboBoxPersonalExtra.Enabled = false;
			this.comboBoxPersonalExtra.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBoxPersonalExtra.FormattingEnabled = true;
			this.comboBoxPersonalExtra.Location = new System.Drawing.Point(77, 26);
			this.comboBoxPersonalExtra.Name = "comboBoxPersonalExtra";
			this.comboBoxPersonalExtra.Size = new System.Drawing.Size(145, 23);
			this.comboBoxPersonalExtra.TabIndex = 58;
			this.comboBoxPersonalExtra.Text = "-Seleccione Cuadrilla-";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.dgv2);
			this.groupBox1.Controls.Add(this.checkGrua);
			this.groupBox1.Controls.Add(this.checkAuto);
			this.groupBox1.Controls.Add(this.checkCamioneta);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new System.Drawing.Point(603, 83);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(415, 338);
			this.groupBox1.TabIndex = 59;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vehiculos";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.button1.ForeColor = System.Drawing.SystemColors.Control;
			this.button1.Location = new System.Drawing.Point(159, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 32);
			this.button1.TabIndex = 65;
			this.button1.Text = "Seleccionar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// dgv2
			// 
			this.dgv2.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv2.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv2.Location = new System.Drawing.Point(15, 50);
			this.dgv2.Margin = new System.Windows.Forms.Padding(2);
			this.dgv2.Name = "dgv2";
			this.dgv2.RowTemplate.Height = 28;
			this.dgv2.Size = new System.Drawing.Size(387, 178);
			this.dgv2.TabIndex = 66;
			this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnSeleccionar.Location = new System.Drawing.Point(57, 64);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(121, 34);
			this.btnSeleccionar.TabIndex = 64;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = false;
			this.btnSeleccionar.Click += new System.EventHandler(this.button4_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtOtros);
			this.groupBox2.Controls.Add(this.checkOtros);
			this.groupBox2.Controls.Add(this.txtFocos);
			this.groupBox2.Controls.Add(this.txtLlaves);
			this.groupBox2.Controls.Add(this.txtPoste);
			this.groupBox2.Controls.Add(this.txtTransformador);
			this.groupBox2.Controls.Add(this.txtCajaHerramientas);
			this.groupBox2.Controls.Add(this.txtEscalera);
			this.groupBox2.Controls.Add(this.checkLlaves);
			this.groupBox2.Controls.Add(this.checkPoste);
			this.groupBox2.Controls.Add(this.checkFocos);
			this.groupBox2.Controls.Add(this.checkTransformador);
			this.groupBox2.Controls.Add(this.checkCajaHerramientas);
			this.groupBox2.Controls.Add(this.checkEscalera);
			this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox2.Location = new System.Drawing.Point(264, 163);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(290, 273);
			this.groupBox2.TabIndex = 60;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Herramientas";
			// 
			// txtOtros
			// 
			this.txtOtros.Location = new System.Drawing.Point(184, 235);
			this.txtOtros.Name = "txtOtros";
			this.txtOtros.ReadOnly = true;
			this.txtOtros.Size = new System.Drawing.Size(100, 23);
			this.txtOtros.TabIndex = 61;
			// 
			// checkOtros
			// 
			this.checkOtros.AutoSize = true;
			this.checkOtros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.checkOtros.Location = new System.Drawing.Point(16, 237);
			this.checkOtros.Name = "checkOtros";
			this.checkOtros.Size = new System.Drawing.Size(61, 20);
			this.checkOtros.TabIndex = 60;
			this.checkOtros.Text = "Otros";
			this.checkOtros.UseVisualStyleBackColor = true;
			this.checkOtros.CheckedChanged += new System.EventHandler(this.checkOtros_CheckedChanged);
			// 
			// txtLlaves
			// 
			this.txtLlaves.Location = new System.Drawing.Point(184, 197);
			this.txtLlaves.Name = "txtLlaves";
			this.txtLlaves.ReadOnly = true;
			this.txtLlaves.Size = new System.Drawing.Size(100, 23);
			this.txtLlaves.TabIndex = 59;
			// 
			// txtPoste
			// 
			this.txtPoste.Location = new System.Drawing.Point(184, 127);
			this.txtPoste.Name = "txtPoste";
			this.txtPoste.ReadOnly = true;
			this.txtPoste.Size = new System.Drawing.Size(100, 23);
			this.txtPoste.TabIndex = 58;
			// 
			// txtTransformador
			// 
			this.txtTransformador.Location = new System.Drawing.Point(184, 95);
			this.txtTransformador.Name = "txtTransformador";
			this.txtTransformador.ReadOnly = true;
			this.txtTransformador.Size = new System.Drawing.Size(100, 23);
			this.txtTransformador.TabIndex = 57;
			// 
			// txtCajaHerramientas
			// 
			this.txtCajaHerramientas.Location = new System.Drawing.Point(184, 57);
			this.txtCajaHerramientas.Name = "txtCajaHerramientas";
			this.txtCajaHerramientas.ReadOnly = true;
			this.txtCajaHerramientas.Size = new System.Drawing.Size(100, 23);
			this.txtCajaHerramientas.TabIndex = 56;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.comboBoxPersonalExtra);
			this.groupBox3.Controls.Add(this.btnSeleccionar);
			this.groupBox3.Controls.Add(this.checkPersonal);
			this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox3.Location = new System.Drawing.Point(12, 259);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(251, 120);
			this.groupBox3.TabIndex = 61;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Personal Extra";
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.txtCuadrilla);
			this.groupBox4.Controls.Add(this.lblVerificar);
			this.groupBox4.Controls.Add(this.btnVerificar);
			this.groupBox4.Controls.Add(this.label1);
			this.groupBox4.Controls.Add(this.txtNombreEmpleado);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.txtApellidoEmpleado);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.txtNroEmpleado);
			this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox4.Location = new System.Drawing.Point(12, 14);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(242, 220);
			this.groupBox4.TabIndex = 62;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Datos de Cuadrilla";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label5.Location = new System.Drawing.Point(6, 138);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(110, 16);
			this.label5.TabIndex = 35;
			this.label5.Text = "N° de Cuadrilla";
			// 
			// txtCuadrilla
			// 
			this.txtCuadrilla.Location = new System.Drawing.Point(136, 136);
			this.txtCuadrilla.Name = "txtCuadrilla";
			this.txtCuadrilla.Size = new System.Drawing.Size(100, 23);
			this.txtCuadrilla.TabIndex = 36;
			// 
			// lblVerificar
			// 
			this.lblVerificar.AutoSize = true;
			this.lblVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVerificar.ForeColor = System.Drawing.Color.DarkRed;
			this.lblVerificar.Location = new System.Drawing.Point(26, 129);
			this.lblVerificar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblVerificar.Name = "lblVerificar";
			this.lblVerificar.Size = new System.Drawing.Size(0, 13);
			this.lblVerificar.TabIndex = 34;
			// 
			// btnVerificar
			// 
			this.btnVerificar.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnVerificar.ForeColor = System.Drawing.SystemColors.Control;
			this.btnVerificar.Location = new System.Drawing.Point(57, 169);
			this.btnVerificar.Margin = new System.Windows.Forms.Padding(2);
			this.btnVerificar.Name = "btnVerificar";
			this.btnVerificar.Size = new System.Drawing.Size(103, 28);
			this.btnVerificar.TabIndex = 33;
			this.btnVerificar.Text = "Verificar";
			this.btnVerificar.UseVisualStyleBackColor = false;
			this.btnVerificar.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.Transparent;
			this.groupBox5.Controls.Add(this.dateTimePicker1);
			this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox5.Location = new System.Drawing.Point(630, 15);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(269, 61);
			this.groupBox5.TabIndex = 63;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Fecha y hora";
			// 
			// dgv1
			// 
			this.dgv1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv1.GridColor = System.Drawing.SystemColors.MenuHighlight;
			this.dgv1.Location = new System.Drawing.Point(5, 23);
			this.dgv1.Margin = new System.Windows.Forms.Padding(2);
			this.dgv1.Name = "dgv1";
			this.dgv1.RowTemplate.Height = 28;
			this.dgv1.Size = new System.Drawing.Size(331, 97);
			this.dgv1.TabIndex = 64;
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.Transparent;
			this.groupBox6.Controls.Add(this.dgv1);
			this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox6.Location = new System.Drawing.Point(259, 15);
			this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox6.Size = new System.Drawing.Size(339, 133);
			this.groupBox6.TabIndex = 65;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Reclamo a atender";
			// 
			// Empleado2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1030, 532);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnConfirmar);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Empleado2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Secheep";
			this.Load += new System.EventHandler(this.Empleado2_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFocos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNroEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.CheckBox checkCamioneta;
        private System.Windows.Forms.CheckBox checkAuto;
        private System.Windows.Forms.CheckBox checkGrua;
        private System.Windows.Forms.CheckBox checkEscalera;
        private System.Windows.Forms.CheckBox checkCajaHerramientas;
        private System.Windows.Forms.CheckBox checkTransformador;
        private System.Windows.Forms.CheckBox checkFocos;
        private System.Windows.Forms.CheckBox checkPoste;
        private System.Windows.Forms.CheckBox checkLlaves;
        private System.Windows.Forms.TextBox txtEscalera;
        private System.Windows.Forms.CheckBox checkPersonal;
        private System.Windows.Forms.ComboBox comboBoxPersonalExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtLlaves;
        private System.Windows.Forms.TextBox txtPoste;
        private System.Windows.Forms.TextBox txtTransformador;
        private System.Windows.Forms.TextBox txtCajaHerramientas;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtOtros;
        private System.Windows.Forms.CheckBox checkOtros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblVerificar;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuadrilla;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgv1;
    }
}