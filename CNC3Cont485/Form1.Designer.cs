namespace CNC3Cont485
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			menuStrip1 = new MenuStrip();
			configuraciónToolStripMenuItem = new ToolStripMenuItem();
			tbMacros = new TabPage();
			lblTituloComandos = new Label();
			lblTituloNombre = new Label();
			lblTituloCodigoG = new Label();
			lblTituloCodigoPieza = new Label();
			lbxInstrucciones = new ListBox();
			txtNombreComando = new TextBox();
			rtxtCodigoComando = new RichTextBox();
			rtxtCodigoPieza = new RichTextBox();
			btnGuardar = new Button();
			btnAgregarComando = new Button();
			btnCargarAPieza = new Button();
			btnCancelar = new Button();
			btnCorrerCodigo = new Button();
			btnGuardarCodigoG = new Button();
			rbtnAgregarNuevoComando = new RadioButton();
			btnCorrerComandoUnitario = new Button();
			btnStopComandos = new Button();
			btnResetComandos = new Button();
			chbxOrdenarLbxComandos = new CheckBox();
			btnEliminarComando = new Button();
			btnGuardarMacros = new Button();
			btnAbrirArchivoMacros = new Button();
			pictureBox2 = new PictureBox();
			btnCambiarArchivoMacros = new Button();
			btnCrearNuevoArchivoDeMacros = new Button();
			lblCrearNuevoMacro = new Label();
			txtNombreArchivoMacros = new TextBox();
			btnCrearArchivoMacros = new Button();
			lblXMovMacro = new Label();
			lblYMovMacro = new Label();
			lblZMovMacro = new Label();
			cbTipoDeComando = new ComboBox();
			lblFMovMacro = new Label();
			txtValor1MovMacro = new TextBox();
			txtValor2MovMacro = new TextBox();
			txtValor3MovMacro = new TextBox();
			txtValor4MovMacro = new TextBox();
			btnAgregarMovMacro = new Button();
			label1 = new Label();
			textBox5 = new TextBox();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			pictureBox5 = new PictureBox();
			pictureBox4 = new PictureBox();
			pictureBox3 = new PictureBox();
			tbInicio = new TabPage();
			txtZ = new TextBox();
			txtY = new TextBox();
			txtX = new TextBox();
			lblZ = new Label();
			grpJog = new GroupBox();
			btnXMinus = new Button();
			btnJogXPlus = new Button();
			btnYMinus = new Button();
			btnYPlus = new Button();
			btnZMinus = new Button();
			btnHome = new Button();
			btnZplus = new Button();
			lblJogVelocityTitulo = new Label();
			tbVelocidad = new TrackBar();
			lblMostrarVelocidad = new Label();
			txtMostrarVelocidad = new TextBox();
			button3 = new Button();
			button4 = new Button();
			lblY = new Label();
			lblX = new Label();
			pictureBox1 = new PictureBox();
			pbXHome = new PictureBox();
			pbYHome = new PictureBox();
			pbZHome = new PictureBox();
			dataGridView1 = new DataGridView();
			entradaId = new DataGridViewComboBoxColumn();
			salidasId = new DataGridViewComboBoxColumn();
			zCoord = new DataGridViewTextBoxColumn();
			yCoord = new DataGridViewTextBoxColumn();
			xCoord = new DataGridViewTextBoxColumn();
			tipoMov = new DataGridViewComboBoxColumn();
			btnGuardarEjemplo = new Button();
			button5 = new Button();
			button6 = new Button();
			tbcntrlMenus = new TabControl();
			menuStrip1.SuspendLayout();
			tbMacros.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			tbInicio.SuspendLayout();
			grpJog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbVelocidad).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbXHome).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbYHome).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbZHome).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			tbcntrlMenus.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { configuraciónToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Padding = new Padding(7, 2, 0, 2);
			menuStrip1.Size = new Size(1774, 33);
			menuStrip1.TabIndex = 35;
			menuStrip1.Text = "menuStrip1";
			// 
			// configuraciónToolStripMenuItem
			// 
			configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
			configuraciónToolStripMenuItem.Size = new Size(139, 29);
			configuraciónToolStripMenuItem.Text = "Configuración";
			// 
			// tbMacros
			// 
			tbMacros.BackColor = SystemColors.Control;
			tbMacros.Controls.Add(pictureBox3);
			tbMacros.Controls.Add(pictureBox4);
			tbMacros.Controls.Add(pictureBox5);
			tbMacros.Controls.Add(label2);
			tbMacros.Controls.Add(label3);
			tbMacros.Controls.Add(label4);
			tbMacros.Controls.Add(textBox3);
			tbMacros.Controls.Add(textBox4);
			tbMacros.Controls.Add(textBox5);
			tbMacros.Controls.Add(txtValor4MovMacro);
			tbMacros.Controls.Add(txtValor3MovMacro);
			tbMacros.Controls.Add(txtValor2MovMacro);
			tbMacros.Controls.Add(txtValor1MovMacro);
			tbMacros.Controls.Add(txtNombreArchivoMacros);
			tbMacros.Controls.Add(rtxtCodigoPieza);
			tbMacros.Controls.Add(rtxtCodigoComando);
			tbMacros.Controls.Add(txtNombreComando);
			tbMacros.Controls.Add(label1);
			tbMacros.Controls.Add(btnAgregarMovMacro);
			tbMacros.Controls.Add(lblFMovMacro);
			tbMacros.Controls.Add(cbTipoDeComando);
			tbMacros.Controls.Add(lblZMovMacro);
			tbMacros.Controls.Add(lblYMovMacro);
			tbMacros.Controls.Add(lblXMovMacro);
			tbMacros.Controls.Add(btnCrearArchivoMacros);
			tbMacros.Controls.Add(lblCrearNuevoMacro);
			tbMacros.Controls.Add(btnCrearNuevoArchivoDeMacros);
			tbMacros.Controls.Add(btnCambiarArchivoMacros);
			tbMacros.Controls.Add(pictureBox2);
			tbMacros.Controls.Add(btnAbrirArchivoMacros);
			tbMacros.Controls.Add(btnGuardarMacros);
			tbMacros.Controls.Add(btnEliminarComando);
			tbMacros.Controls.Add(chbxOrdenarLbxComandos);
			tbMacros.Controls.Add(btnResetComandos);
			tbMacros.Controls.Add(btnStopComandos);
			tbMacros.Controls.Add(btnCorrerComandoUnitario);
			tbMacros.Controls.Add(rbtnAgregarNuevoComando);
			tbMacros.Controls.Add(btnGuardarCodigoG);
			tbMacros.Controls.Add(btnCorrerCodigo);
			tbMacros.Controls.Add(btnCancelar);
			tbMacros.Controls.Add(btnCargarAPieza);
			tbMacros.Controls.Add(btnAgregarComando);
			tbMacros.Controls.Add(btnGuardar);
			tbMacros.Controls.Add(lbxInstrucciones);
			tbMacros.Controls.Add(lblTituloCodigoPieza);
			tbMacros.Controls.Add(lblTituloCodigoG);
			tbMacros.Controls.Add(lblTituloNombre);
			tbMacros.Controls.Add(lblTituloComandos);
			tbMacros.Font = new Font("Segoe UI", 9F);
			tbMacros.Location = new Point(4, 34);
			tbMacros.Margin = new Padding(3, 4, 3, 4);
			tbMacros.Name = "tbMacros";
			tbMacros.Size = new Size(1706, 837);
			tbMacros.TabIndex = 2;
			tbMacros.Text = "Comandos";
			// 
			// lblTituloComandos
			// 
			lblTituloComandos.AutoSize = true;
			lblTituloComandos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			lblTituloComandos.Location = new Point(73, 207);
			lblTituloComandos.Name = "lblTituloComandos";
			lblTituloComandos.Size = new Size(110, 28);
			lblTituloComandos.TabIndex = 0;
			lblTituloComandos.Text = "Comandos";
			// 
			// lblTituloNombre
			// 
			lblTituloNombre.AutoSize = true;
			lblTituloNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			lblTituloNombre.Location = new Point(459, 201);
			lblTituloNombre.Name = "lblTituloNombre";
			lblTituloNombre.Size = new Size(182, 28);
			lblTituloNombre.TabIndex = 1;
			lblTituloNombre.Text = "Nombre comando";
			// 
			// lblTituloCodigoG
			// 
			lblTituloCodigoG.AutoSize = true;
			lblTituloCodigoG.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			lblTituloCodigoG.Location = new Point(458, 275);
			lblTituloCodigoG.Name = "lblTituloCodigoG";
			lblTituloCodigoG.Size = new Size(98, 28);
			lblTituloCodigoG.TabIndex = 2;
			lblTituloCodigoG.Text = "Código G";
			// 
			// lblTituloCodigoPieza
			// 
			lblTituloCodigoPieza.AutoSize = true;
			lblTituloCodigoPieza.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			lblTituloCodigoPieza.Location = new Point(1040, 45);
			lblTituloCodigoPieza.Name = "lblTituloCodigoPieza";
			lblTituloCodigoPieza.Size = new Size(134, 28);
			lblTituloCodigoPieza.TabIndex = 3;
			lblTituloCodigoPieza.Text = "Código Pieza";
			// 
			// lbxInstrucciones
			// 
			lbxInstrucciones.FormattingEnabled = true;
			lbxInstrucciones.ItemHeight = 25;
			lbxInstrucciones.Location = new Point(79, 245);
			lbxInstrucciones.Margin = new Padding(3, 4, 3, 4);
			lbxInstrucciones.Name = "lbxInstrucciones";
			lbxInstrucciones.Size = new Size(266, 354);
			lbxInstrucciones.TabIndex = 4;
			// 
			// txtNombreComando
			// 
			txtNombreComando.Location = new Point(459, 235);
			txtNombreComando.Margin = new Padding(3, 4, 3, 4);
			txtNombreComando.Name = "txtNombreComando";
			txtNombreComando.Size = new Size(228, 31);
			txtNombreComando.TabIndex = 5;
			// 
			// rtxtCodigoComando
			// 
			rtxtCodigoComando.Location = new Point(458, 307);
			rtxtCodigoComando.Margin = new Padding(3, 4, 3, 4);
			rtxtCodigoComando.Name = "rtxtCodigoComando";
			rtxtCodigoComando.Size = new Size(337, 279);
			rtxtCodigoComando.TabIndex = 6;
			rtxtCodigoComando.Text = "";
			// 
			// rtxtCodigoPieza
			// 
			rtxtCodigoPieza.Location = new Point(1044, 84);
			rtxtCodigoPieza.Margin = new Padding(3, 4, 3, 4);
			rtxtCodigoPieza.Name = "rtxtCodigoPieza";
			rtxtCodigoPieza.Size = new Size(352, 518);
			rtxtCodigoPieza.TabIndex = 7;
			rtxtCodigoPieza.Text = "";
			// 
			// btnGuardar
			// 
			btnGuardar.Font = new Font("Segoe UI", 9F);
			btnGuardar.Location = new Point(806, 451);
			btnGuardar.Margin = new Padding(3, 4, 3, 4);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(112, 45);
			btnGuardar.TabIndex = 8;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnAgregarComando
			// 
			btnAgregarComando.Font = new Font("Segoe UI", 9F);
			btnAgregarComando.Location = new Point(806, 515);
			btnAgregarComando.Margin = new Padding(3, 4, 3, 4);
			btnAgregarComando.Name = "btnAgregarComando";
			btnAgregarComando.Size = new Size(112, 71);
			btnAgregarComando.TabIndex = 9;
			btnAgregarComando.Text = "Agregar comando";
			btnAgregarComando.UseVisualStyleBackColor = true;
			btnAgregarComando.Visible = false;
			// 
			// btnCargarAPieza
			// 
			btnCargarAPieza.BackColor = SystemColors.ControlLightLight;
			btnCargarAPieza.BackgroundImage = (Image)resources.GetObject("btnCargarAPieza.BackgroundImage");
			btnCargarAPieza.BackgroundImageLayout = ImageLayout.Center;
			btnCargarAPieza.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnCargarAPieza.Location = new Point(703, 218);
			btnCargarAPieza.Margin = new Padding(3, 4, 3, 4);
			btnCargarAPieza.Name = "btnCargarAPieza";
			btnCargarAPieza.Size = new Size(76, 48);
			btnCargarAPieza.TabIndex = 10;
			btnCargarAPieza.Text = "\r\n";
			btnCargarAPieza.UseVisualStyleBackColor = false;
			// 
			// btnCancelar
			// 
			btnCancelar.Font = new Font("Segoe UI", 9F);
			btnCancelar.Location = new Point(806, 610);
			btnCancelar.Margin = new Padding(3, 4, 3, 4);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(112, 45);
			btnCancelar.TabIndex = 11;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Visible = false;
			// 
			// btnCorrerCodigo
			// 
			btnCorrerCodigo.Font = new Font("Segoe UI", 9F);
			btnCorrerCodigo.Location = new Point(1426, 396);
			btnCorrerCodigo.Margin = new Padding(3, 4, 3, 4);
			btnCorrerCodigo.Name = "btnCorrerCodigo";
			btnCorrerCodigo.Size = new Size(112, 45);
			btnCorrerCodigo.TabIndex = 12;
			btnCorrerCodigo.Text = "Run";
			btnCorrerCodigo.UseVisualStyleBackColor = true;
			// 
			// btnGuardarCodigoG
			// 
			btnGuardarCodigoG.Font = new Font("Segoe UI", 9F);
			btnGuardarCodigoG.Location = new Point(1426, 513);
			btnGuardarCodigoG.Margin = new Padding(3, 4, 3, 4);
			btnGuardarCodigoG.Name = "btnGuardarCodigoG";
			btnGuardarCodigoG.Size = new Size(124, 89);
			btnGuardarCodigoG.TabIndex = 13;
			btnGuardarCodigoG.Text = "Guardar código G";
			btnGuardarCodigoG.UseVisualStyleBackColor = true;
			// 
			// rbtnAgregarNuevoComando
			// 
			rbtnAgregarNuevoComando.AutoSize = true;
			rbtnAgregarNuevoComando.Location = new Point(458, 601);
			rbtnAgregarNuevoComando.Margin = new Padding(3, 4, 3, 4);
			rbtnAgregarNuevoComando.Name = "rbtnAgregarNuevoComando";
			rbtnAgregarNuevoComando.Size = new Size(158, 29);
			rbtnAgregarNuevoComando.TabIndex = 14;
			rbtnAgregarNuevoComando.TabStop = true;
			rbtnAgregarNuevoComando.Text = "Agregar Nuevo";
			rbtnAgregarNuevoComando.UseVisualStyleBackColor = true;
			// 
			// btnCorrerComandoUnitario
			// 
			btnCorrerComandoUnitario.Font = new Font("Segoe UI", 9F);
			btnCorrerComandoUnitario.Location = new Point(806, 356);
			btnCorrerComandoUnitario.Margin = new Padding(3, 4, 3, 4);
			btnCorrerComandoUnitario.Name = "btnCorrerComandoUnitario";
			btnCorrerComandoUnitario.Size = new Size(112, 45);
			btnCorrerComandoUnitario.TabIndex = 15;
			btnCorrerComandoUnitario.Text = "Run";
			btnCorrerComandoUnitario.UseVisualStyleBackColor = true;
			// 
			// btnStopComandos
			// 
			btnStopComandos.BackColor = Color.Red;
			btnStopComandos.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnStopComandos.Location = new Point(79, 607);
			btnStopComandos.Margin = new Padding(3, 4, 3, 4);
			btnStopComandos.Name = "btnStopComandos";
			btnStopComandos.Size = new Size(123, 86);
			btnStopComandos.TabIndex = 16;
			btnStopComandos.Text = "STOP";
			btnStopComandos.UseVisualStyleBackColor = false;
			// 
			// btnResetComandos
			// 
			btnResetComandos.BackColor = Color.Silver;
			btnResetComandos.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnResetComandos.ForeColor = SystemColors.ControlText;
			btnResetComandos.Location = new Point(222, 607);
			btnResetComandos.Margin = new Padding(3, 4, 3, 4);
			btnResetComandos.Name = "btnResetComandos";
			btnResetComandos.Size = new Size(123, 86);
			btnResetComandos.TabIndex = 17;
			btnResetComandos.Text = "Reset";
			btnResetComandos.UseVisualStyleBackColor = false;
			// 
			// chbxOrdenarLbxComandos
			// 
			chbxOrdenarLbxComandos.AutoSize = true;
			chbxOrdenarLbxComandos.Location = new Point(196, 209);
			chbxOrdenarLbxComandos.Margin = new Padding(3, 4, 3, 4);
			chbxOrdenarLbxComandos.Name = "chbxOrdenarLbxComandos";
			chbxOrdenarLbxComandos.Size = new Size(149, 29);
			chbxOrdenarLbxComandos.TabIndex = 19;
			chbxOrdenarLbxComandos.Text = "Ordenar A->Z";
			chbxOrdenarLbxComandos.UseVisualStyleBackColor = true;
			// 
			// btnEliminarComando
			// 
			btnEliminarComando.Location = new Point(623, 597);
			btnEliminarComando.Margin = new Padding(3, 4, 3, 4);
			btnEliminarComando.Name = "btnEliminarComando";
			btnEliminarComando.Size = new Size(172, 37);
			btnEliminarComando.TabIndex = 20;
			btnEliminarComando.Text = "Eliminar comando";
			btnEliminarComando.UseVisualStyleBackColor = true;
			// 
			// btnGuardarMacros
			// 
			btnGuardarMacros.Location = new Point(1270, 610);
			btnGuardarMacros.Margin = new Padding(3, 4, 3, 4);
			btnGuardarMacros.Name = "btnGuardarMacros";
			btnGuardarMacros.Size = new Size(126, 85);
			btnGuardarMacros.TabIndex = 21;
			btnGuardarMacros.Text = "Guardar programa";
			btnGuardarMacros.UseVisualStyleBackColor = true;
			// 
			// btnAbrirArchivoMacros
			// 
			btnAbrirArchivoMacros.Location = new Point(1138, 610);
			btnAbrirArchivoMacros.Margin = new Padding(3, 4, 3, 4);
			btnAbrirArchivoMacros.Name = "btnAbrirArchivoMacros";
			btnAbrirArchivoMacros.Size = new Size(126, 85);
			btnAbrirArchivoMacros.TabIndex = 22;
			btnAbrirArchivoMacros.Text = "Abrir programa";
			btnAbrirArchivoMacros.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(100, 35);
			pictureBox2.Margin = new Padding(4, 6, 4, 6);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(232, 140);
			pictureBox2.TabIndex = 25;
			pictureBox2.TabStop = false;
			// 
			// btnCambiarArchivoMacros
			// 
			btnCambiarArchivoMacros.Location = new Point(79, 701);
			btnCambiarArchivoMacros.Margin = new Padding(3, 4, 3, 4);
			btnCambiarArchivoMacros.Name = "btnCambiarArchivoMacros";
			btnCambiarArchivoMacros.Size = new Size(123, 86);
			btnCambiarArchivoMacros.TabIndex = 45;
			btnCambiarArchivoMacros.Text = "Cambiar de archivo de macros";
			btnCambiarArchivoMacros.UseVisualStyleBackColor = true;
			// 
			// btnCrearNuevoArchivoDeMacros
			// 
			btnCrearNuevoArchivoDeMacros.Location = new Point(222, 701);
			btnCrearNuevoArchivoDeMacros.Margin = new Padding(3, 4, 3, 4);
			btnCrearNuevoArchivoDeMacros.Name = "btnCrearNuevoArchivoDeMacros";
			btnCrearNuevoArchivoDeMacros.Size = new Size(123, 86);
			btnCrearNuevoArchivoDeMacros.TabIndex = 46;
			btnCrearNuevoArchivoDeMacros.Text = "Abrir nuevo archivo de macros";
			btnCrearNuevoArchivoDeMacros.UseVisualStyleBackColor = true;
			// 
			// lblCrearNuevoMacro
			// 
			lblCrearNuevoMacro.AutoSize = true;
			lblCrearNuevoMacro.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblCrearNuevoMacro.Location = new Point(998, 711);
			lblCrearNuevoMacro.Name = "lblCrearNuevoMacro";
			lblCrearNuevoMacro.Size = new Size(313, 60);
			lblCrearNuevoMacro.TabIndex = 47;
			lblCrearNuevoMacro.Text = "Agrega el nombre del nuevo \r\narchivo de macros.";
			lblCrearNuevoMacro.Visible = false;
			// 
			// txtNombreArchivoMacros
			// 
			txtNombreArchivoMacros.Location = new Point(998, 796);
			txtNombreArchivoMacros.Margin = new Padding(3, 4, 3, 4);
			txtNombreArchivoMacros.Name = "txtNombreArchivoMacros";
			txtNombreArchivoMacros.Size = new Size(374, 31);
			txtNombreArchivoMacros.TabIndex = 48;
			txtNombreArchivoMacros.Visible = false;
			// 
			// btnCrearArchivoMacros
			// 
			btnCrearArchivoMacros.Location = new Point(1426, 965);
			btnCrearArchivoMacros.Margin = new Padding(3, 4, 3, 4);
			btnCrearArchivoMacros.Name = "btnCrearArchivoMacros";
			btnCrearArchivoMacros.Size = new Size(83, 51);
			btnCrearArchivoMacros.TabIndex = 49;
			btnCrearArchivoMacros.Text = "Listo";
			btnCrearArchivoMacros.UseVisualStyleBackColor = true;
			btnCrearArchivoMacros.Visible = false;
			// 
			// lblXMovMacro
			// 
			lblXMovMacro.AutoSize = true;
			lblXMovMacro.Location = new Point(464, 698);
			lblXMovMacro.Name = "lblXMovMacro";
			lblXMovMacro.Size = new Size(23, 25);
			lblXMovMacro.TabIndex = 50;
			lblXMovMacro.Text = "X";
			lblXMovMacro.Visible = false;
			// 
			// lblYMovMacro
			// 
			lblYMovMacro.AutoSize = true;
			lblYMovMacro.Location = new Point(465, 738);
			lblYMovMacro.Name = "lblYMovMacro";
			lblYMovMacro.Size = new Size(22, 25);
			lblYMovMacro.TabIndex = 51;
			lblYMovMacro.Text = "Y";
			lblYMovMacro.Visible = false;
			// 
			// lblZMovMacro
			// 
			lblZMovMacro.AutoSize = true;
			lblZMovMacro.Location = new Point(465, 778);
			lblZMovMacro.Name = "lblZMovMacro";
			lblZMovMacro.Size = new Size(22, 25);
			lblZMovMacro.TabIndex = 52;
			lblZMovMacro.Text = "Z";
			lblZMovMacro.Visible = false;
			// 
			// cbTipoDeComando
			// 
			cbTipoDeComando.FormattingEnabled = true;
			cbTipoDeComando.Items.AddRange(new object[] { "Absoluto", "No absoluto", "Doblado" });
			cbTipoDeComando.Location = new Point(668, 798);
			cbTipoDeComando.Margin = new Padding(3, 4, 3, 4);
			cbTipoDeComando.Name = "cbTipoDeComando";
			cbTipoDeComando.Size = new Size(199, 33);
			cbTipoDeComando.TabIndex = 53;
			cbTipoDeComando.Text = "Tipo de movimiento";
			// 
			// lblFMovMacro
			// 
			lblFMovMacro.AutoSize = true;
			lblFMovMacro.Location = new Point(641, 701);
			lblFMovMacro.Name = "lblFMovMacro";
			lblFMovMacro.Size = new Size(21, 25);
			lblFMovMacro.TabIndex = 54;
			lblFMovMacro.Text = "F";
			lblFMovMacro.Visible = false;
			// 
			// txtValor1MovMacro
			// 
			txtValor1MovMacro.Location = new Point(497, 695);
			txtValor1MovMacro.Margin = new Padding(3, 4, 3, 4);
			txtValor1MovMacro.Name = "txtValor1MovMacro";
			txtValor1MovMacro.Size = new Size(100, 31);
			txtValor1MovMacro.TabIndex = 55;
			txtValor1MovMacro.Visible = false;
			// 
			// txtValor2MovMacro
			// 
			txtValor2MovMacro.Location = new Point(497, 735);
			txtValor2MovMacro.Margin = new Padding(3, 4, 3, 4);
			txtValor2MovMacro.Name = "txtValor2MovMacro";
			txtValor2MovMacro.Size = new Size(100, 31);
			txtValor2MovMacro.TabIndex = 56;
			txtValor2MovMacro.Visible = false;
			// 
			// txtValor3MovMacro
			// 
			txtValor3MovMacro.Location = new Point(497, 772);
			txtValor3MovMacro.Margin = new Padding(3, 4, 3, 4);
			txtValor3MovMacro.Name = "txtValor3MovMacro";
			txtValor3MovMacro.Size = new Size(100, 31);
			txtValor3MovMacro.TabIndex = 57;
			txtValor3MovMacro.Visible = false;
			// 
			// txtValor4MovMacro
			// 
			txtValor4MovMacro.Location = new Point(668, 698);
			txtValor4MovMacro.Margin = new Padding(3, 4, 3, 4);
			txtValor4MovMacro.Name = "txtValor4MovMacro";
			txtValor4MovMacro.Size = new Size(100, 31);
			txtValor4MovMacro.TabIndex = 58;
			txtValor4MovMacro.Visible = false;
			// 
			// btnAgregarMovMacro
			// 
			btnAgregarMovMacro.Location = new Point(668, 737);
			btnAgregarMovMacro.Margin = new Padding(3, 4, 3, 4);
			btnAgregarMovMacro.Name = "btnAgregarMovMacro";
			btnAgregarMovMacro.Size = new Size(122, 59);
			btnAgregarMovMacro.TabIndex = 59;
			btnAgregarMovMacro.Text = "Agregar Movimiento";
			btnAgregarMovMacro.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
			label1.Location = new Point(462, 649);
			label1.Name = "label1";
			label1.Size = new Size(339, 28);
			label1.TabIndex = 60;
			label1.Text = "Agregar comandos de movimiento";
			// 
			// textBox5
			// 
			textBox5.BackColor = Color.Black;
			textBox5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox5.ForeColor = Color.Lime;
			textBox5.Location = new Point(592, 139);
			textBox5.Margin = new Padding(4, 6, 4, 6);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(266, 48);
			textBox5.TabIndex = 66;
			textBox5.TextAlign = HorizontalAlignment.Right;
			// 
			// textBox4
			// 
			textBox4.BackColor = Color.Black;
			textBox4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox4.ForeColor = Color.Lime;
			textBox4.Location = new Point(592, 84);
			textBox4.Margin = new Padding(4, 6, 4, 6);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(266, 48);
			textBox4.TabIndex = 65;
			textBox4.TextAlign = HorizontalAlignment.Right;
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.Black;
			textBox3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			textBox3.ForeColor = Color.Lime;
			textBox3.Location = new Point(592, 32);
			textBox3.Margin = new Padding(4, 6, 4, 6);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(266, 48);
			textBox3.TabIndex = 64;
			textBox3.TextAlign = HorizontalAlignment.Right;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.Location = new Point(535, 142);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(40, 40);
			label4.TabIndex = 63;
			label4.Text = "Z";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(534, 87);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(41, 40);
			label3.TabIndex = 62;
			label3.Text = "Y";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(532, 35);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(42, 40);
			label2.TabIndex = 61;
			label2.Text = "X";
			// 
			// pictureBox5
			// 
			pictureBox5.BackColor = Color.Red;
			pictureBox5.BorderStyle = BorderStyle.FixedSingle;
			pictureBox5.Location = new Point(458, 32);
			pictureBox5.Margin = new Padding(3, 4, 3, 4);
			pictureBox5.Name = "pictureBox5";
			pictureBox5.Size = new Size(48, 48);
			pictureBox5.TabIndex = 67;
			pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			pictureBox4.BackColor = Color.Red;
			pictureBox4.BorderStyle = BorderStyle.FixedSingle;
			pictureBox4.Location = new Point(458, 84);
			pictureBox4.Margin = new Padding(3, 4, 3, 4);
			pictureBox4.Name = "pictureBox4";
			pictureBox4.Size = new Size(48, 48);
			pictureBox4.TabIndex = 68;
			pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.BackColor = Color.Red;
			pictureBox3.BorderStyle = BorderStyle.FixedSingle;
			pictureBox3.Location = new Point(459, 139);
			pictureBox3.Margin = new Padding(3, 4, 3, 4);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(48, 48);
			pictureBox3.TabIndex = 69;
			pictureBox3.TabStop = false;
			// 
			// tbInicio
			// 
			tbInicio.BackColor = SystemColors.Control;
			tbInicio.Controls.Add(button6);
			tbInicio.Controls.Add(button5);
			tbInicio.Controls.Add(btnGuardarEjemplo);
			tbInicio.Controls.Add(dataGridView1);
			tbInicio.Controls.Add(pbZHome);
			tbInicio.Controls.Add(pbYHome);
			tbInicio.Controls.Add(pbXHome);
			tbInicio.Controls.Add(pictureBox1);
			tbInicio.Controls.Add(lblX);
			tbInicio.Controls.Add(lblY);
			tbInicio.Controls.Add(grpJog);
			tbInicio.Controls.Add(lblZ);
			tbInicio.Controls.Add(txtX);
			tbInicio.Controls.Add(txtY);
			tbInicio.Controls.Add(txtZ);
			tbInicio.Location = new Point(4, 34);
			tbInicio.Margin = new Padding(3, 4, 3, 4);
			tbInicio.Name = "tbInicio";
			tbInicio.Padding = new Padding(3, 4, 3, 4);
			tbInicio.Size = new Size(1706, 837);
			tbInicio.TabIndex = 0;
			tbInicio.Text = "Inicio";
			tbInicio.Click += tbInicio_Click;
			// 
			// txtZ
			// 
			txtZ.BackColor = Color.Black;
			txtZ.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtZ.ForeColor = Color.Lime;
			txtZ.Location = new Point(1254, 173);
			txtZ.Margin = new Padding(4, 6, 4, 6);
			txtZ.Name = "txtZ";
			txtZ.Size = new Size(266, 48);
			txtZ.TabIndex = 13;
			txtZ.TextAlign = HorizontalAlignment.Right;
			// 
			// txtY
			// 
			txtY.BackColor = Color.Black;
			txtY.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtY.ForeColor = Color.Lime;
			txtY.Location = new Point(1254, 98);
			txtY.Margin = new Padding(4, 6, 4, 6);
			txtY.Name = "txtY";
			txtY.Size = new Size(266, 48);
			txtY.TabIndex = 12;
			txtY.TextAlign = HorizontalAlignment.Right;
			// 
			// txtX
			// 
			txtX.BackColor = Color.Black;
			txtX.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtX.ForeColor = Color.Lime;
			txtX.Location = new Point(1254, 25);
			txtX.Margin = new Padding(4, 6, 4, 6);
			txtX.Name = "txtX";
			txtX.Size = new Size(266, 48);
			txtX.TabIndex = 11;
			txtX.TextAlign = HorizontalAlignment.Right;
			// 
			// lblZ
			// 
			lblZ.AutoSize = true;
			lblZ.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblZ.Location = new Point(1196, 173);
			lblZ.Margin = new Padding(4, 0, 4, 0);
			lblZ.Name = "lblZ";
			lblZ.Size = new Size(40, 40);
			lblZ.TabIndex = 10;
			lblZ.Text = "Z";
			// 
			// grpJog
			// 
			grpJog.Controls.Add(button4);
			grpJog.Controls.Add(button3);
			grpJog.Controls.Add(txtMostrarVelocidad);
			grpJog.Controls.Add(lblMostrarVelocidad);
			grpJog.Controls.Add(tbVelocidad);
			grpJog.Controls.Add(lblJogVelocityTitulo);
			grpJog.Controls.Add(btnZplus);
			grpJog.Controls.Add(btnHome);
			grpJog.Controls.Add(btnZMinus);
			grpJog.Controls.Add(btnYPlus);
			grpJog.Controls.Add(btnYMinus);
			grpJog.Controls.Add(btnJogXPlus);
			grpJog.Controls.Add(btnXMinus);
			grpJog.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			grpJog.Location = new Point(1103, 233);
			grpJog.Margin = new Padding(4, 6, 4, 6);
			grpJog.Name = "grpJog";
			grpJog.Padding = new Padding(4, 6, 4, 6);
			grpJog.Size = new Size(548, 517);
			grpJog.TabIndex = 6;
			grpJog.TabStop = false;
			grpJog.Text = "Jog";
			// 
			// btnXMinus
			// 
			btnXMinus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnXMinus.Location = new Point(17, 222);
			btnXMinus.Margin = new Padding(4, 6, 4, 6);
			btnXMinus.Name = "btnXMinus";
			btnXMinus.Size = new Size(136, 54);
			btnXMinus.TabIndex = 3;
			btnXMinus.Text = "X--";
			btnXMinus.UseVisualStyleBackColor = true;
			// 
			// btnJogXPlus
			// 
			btnJogXPlus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnJogXPlus.Location = new Point(215, 222);
			btnJogXPlus.Margin = new Padding(4, 6, 4, 6);
			btnJogXPlus.Name = "btnJogXPlus";
			btnJogXPlus.Size = new Size(136, 54);
			btnJogXPlus.TabIndex = 2;
			btnJogXPlus.Text = "X++";
			btnJogXPlus.UseVisualStyleBackColor = true;
			// 
			// btnYMinus
			// 
			btnYMinus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnYMinus.Location = new Point(114, 289);
			btnYMinus.Margin = new Padding(4, 6, 4, 6);
			btnYMinus.Name = "btnYMinus";
			btnYMinus.Size = new Size(136, 54);
			btnYMinus.TabIndex = 5;
			btnYMinus.Text = "Y--";
			btnYMinus.UseVisualStyleBackColor = true;
			// 
			// btnYPlus
			// 
			btnYPlus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnYPlus.Location = new Point(114, 152);
			btnYPlus.Margin = new Padding(4, 6, 4, 6);
			btnYPlus.Name = "btnYPlus";
			btnYPlus.Size = new Size(136, 54);
			btnYPlus.TabIndex = 4;
			btnYPlus.Text = "Y++";
			btnYPlus.UseVisualStyleBackColor = true;
			// 
			// btnZMinus
			// 
			btnZMinus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnZMinus.Location = new Point(360, 289);
			btnZMinus.Margin = new Padding(4, 6, 4, 6);
			btnZMinus.Name = "btnZMinus";
			btnZMinus.Size = new Size(136, 54);
			btnZMinus.TabIndex = 7;
			btnZMinus.Text = "Z--";
			btnZMinus.UseVisualStyleBackColor = true;
			// 
			// btnHome
			// 
			btnHome.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnHome.Location = new Point(411, 44);
			btnHome.Margin = new Padding(3, 4, 3, 4);
			btnHome.Name = "btnHome";
			btnHome.Size = new Size(130, 88);
			btnHome.TabIndex = 32;
			btnHome.Text = "HOME";
			btnHome.UseVisualStyleBackColor = true;
			// 
			// btnZplus
			// 
			btnZplus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnZplus.Location = new Point(360, 152);
			btnZplus.Margin = new Padding(4, 6, 4, 6);
			btnZplus.Name = "btnZplus";
			btnZplus.Size = new Size(136, 54);
			btnZplus.TabIndex = 6;
			btnZplus.Text = "Z++";
			btnZplus.UseVisualStyleBackColor = true;
			// 
			// lblJogVelocityTitulo
			// 
			lblJogVelocityTitulo.AutoSize = true;
			lblJogVelocityTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblJogVelocityTitulo.Location = new Point(17, 376);
			lblJogVelocityTitulo.Name = "lblJogVelocityTitulo";
			lblJogVelocityTitulo.Size = new Size(260, 32);
			lblJogVelocityTitulo.TabIndex = 33;
			lblJogVelocityTitulo.Text = "Velocidad de Jogging";
			// 
			// tbVelocidad
			// 
			tbVelocidad.LargeChange = 100;
			tbVelocidad.Location = new Point(17, 424);
			tbVelocidad.Margin = new Padding(3, 4, 3, 4);
			tbVelocidad.Maximum = 10000;
			tbVelocidad.Minimum = 1;
			tbVelocidad.Name = "tbVelocidad";
			tbVelocidad.Size = new Size(284, 69);
			tbVelocidad.SmallChange = 100;
			tbVelocidad.TabIndex = 41;
			tbVelocidad.TickFrequency = 100;
			tbVelocidad.TickStyle = TickStyle.Both;
			tbVelocidad.Value = 1;
			// 
			// lblMostrarVelocidad
			// 
			lblMostrarVelocidad.AutoSize = true;
			lblMostrarVelocidad.BackColor = Color.Gainsboro;
			lblMostrarVelocidad.BorderStyle = BorderStyle.FixedSingle;
			lblMostrarVelocidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lblMostrarVelocidad.Location = new Point(307, 424);
			lblMostrarVelocidad.Name = "lblMostrarVelocidad";
			lblMostrarVelocidad.Size = new Size(65, 27);
			lblMostrarVelocidad.TabIndex = 39;
			lblMostrarVelocidad.Text = "label4";
			lblMostrarVelocidad.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtMostrarVelocidad
			// 
			txtMostrarVelocidad.Location = new Point(378, 420);
			txtMostrarVelocidad.Margin = new Padding(3, 4, 3, 4);
			txtMostrarVelocidad.Name = "txtMostrarVelocidad";
			txtMostrarVelocidad.Size = new Size(75, 31);
			txtMostrarVelocidad.TabIndex = 40;
			txtMostrarVelocidad.Visible = false;
			// 
			// button3
			// 
			button3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.Location = new Point(17, 44);
			button3.Margin = new Padding(3, 4, 3, 4);
			button3.Name = "button3";
			button3.Size = new Size(130, 88);
			button3.TabIndex = 42;
			button3.Text = "START";
			button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			button4.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold);
			button4.Location = new Point(221, 44);
			button4.Margin = new Padding(3, 4, 3, 4);
			button4.Name = "button4";
			button4.Size = new Size(130, 88);
			button4.TabIndex = 43;
			button4.Text = "STOP";
			button4.UseVisualStyleBackColor = true;
			// 
			// lblY
			// 
			lblY.AutoSize = true;
			lblY.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblY.Location = new Point(1196, 101);
			lblY.Margin = new Padding(4, 0, 4, 0);
			lblY.Name = "lblY";
			lblY.Size = new Size(41, 40);
			lblY.TabIndex = 9;
			lblY.Text = "Y";
			// 
			// lblX
			// 
			lblX.AutoSize = true;
			lblX.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblX.Location = new Point(1195, 28);
			lblX.Margin = new Padding(4, 0, 4, 0);
			lblX.Name = "lblX";
			lblX.Size = new Size(42, 40);
			lblX.TabIndex = 8;
			lblX.Text = "X";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(57, 6);
			pictureBox1.Margin = new Padding(4, 6, 4, 6);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(232, 140);
			pictureBox1.TabIndex = 24;
			pictureBox1.TabStop = false;
			// 
			// pbXHome
			// 
			pbXHome.BackColor = Color.Red;
			pbXHome.BorderStyle = BorderStyle.FixedSingle;
			pbXHome.Location = new Point(1134, 25);
			pbXHome.Margin = new Padding(3, 4, 3, 4);
			pbXHome.Name = "pbXHome";
			pbXHome.Size = new Size(48, 48);
			pbXHome.TabIndex = 33;
			pbXHome.TabStop = false;
			// 
			// pbYHome
			// 
			pbYHome.BackColor = Color.Red;
			pbYHome.BorderStyle = BorderStyle.FixedSingle;
			pbYHome.Location = new Point(1134, 98);
			pbYHome.Margin = new Padding(3, 4, 3, 4);
			pbYHome.Name = "pbYHome";
			pbYHome.Size = new Size(48, 48);
			pbYHome.TabIndex = 34;
			pbYHome.TabStop = false;
			// 
			// pbZHome
			// 
			pbZHome.BackColor = Color.Red;
			pbZHome.BorderStyle = BorderStyle.FixedSingle;
			pbZHome.Location = new Point(1134, 173);
			pbZHome.Margin = new Padding(3, 4, 3, 4);
			pbZHome.Name = "pbZHome";
			pbZHome.Size = new Size(48, 48);
			pbZHome.TabIndex = 35;
			pbZHome.TabStop = false;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.Control;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tipoMov, xCoord, yCoord, zCoord, salidasId, entradaId });
			dataGridView1.Location = new Point(57, 155);
			dataGridView1.MultiSelect = false;
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 62;
			dataGridView1.Size = new Size(966, 569);
			dataGridView1.TabIndex = 36;
			// 
			// entradaId
			// 
			entradaId.HeaderText = "Entrada";
			entradaId.Items.AddRange(new object[] { "Botón 1", "Botón 2" });
			entradaId.MinimumWidth = 8;
			entradaId.Name = "entradaId";
			entradaId.Width = 150;
			// 
			// salidasId
			// 
			salidasId.HeaderText = "Salida";
			salidasId.Items.AddRange(new object[] { "Clamp ON", "Clamp OFF", "Chuck ON", "Chuck OFF" });
			salidasId.MinimumWidth = 8;
			salidasId.Name = "salidasId";
			salidasId.Width = 150;
			// 
			// zCoord
			// 
			zCoord.HeaderText = "Z";
			zCoord.MinimumWidth = 8;
			zCoord.Name = "zCoord";
			zCoord.Width = 150;
			// 
			// yCoord
			// 
			yCoord.HeaderText = "Y";
			yCoord.MinimumWidth = 8;
			yCoord.Name = "yCoord";
			yCoord.Width = 150;
			// 
			// xCoord
			// 
			xCoord.HeaderText = "X";
			xCoord.MinimumWidth = 8;
			xCoord.Name = "xCoord";
			xCoord.Resizable = DataGridViewTriState.True;
			xCoord.SortMode = DataGridViewColumnSortMode.NotSortable;
			xCoord.Width = 150;
			// 
			// tipoMov
			// 
			tipoMov.HeaderText = "Tipo de Movimiento";
			tipoMov.Items.AddRange(new object[] { "Doblado", "Absoluto", "Incremental", "Libre" });
			tipoMov.MinimumWidth = 8;
			tipoMov.Name = "tipoMov";
			tipoMov.Width = 150;
			// 
			// btnGuardarEjemplo
			// 
			btnGuardarEjemplo.Location = new Point(314, 37);
			btnGuardarEjemplo.Name = "btnGuardarEjemplo";
			btnGuardarEjemplo.Size = new Size(120, 82);
			btnGuardarEjemplo.TabIndex = 37;
			btnGuardarEjemplo.Text = "Guardar rutina";
			btnGuardarEjemplo.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(452, 37);
			button5.Name = "button5";
			button5.Size = new Size(120, 82);
			button5.TabIndex = 38;
			button5.Text = "Abrir rutina";
			button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			button6.Location = new Point(588, 37);
			button6.Name = "button6";
			button6.Size = new Size(120, 82);
			button6.TabIndex = 39;
			button6.Text = "Abrir nuevo";
			button6.UseVisualStyleBackColor = true;
			// 
			// tbcntrlMenus
			// 
			tbcntrlMenus.Controls.Add(tbInicio);
			tbcntrlMenus.Controls.Add(tbMacros);
			tbcntrlMenus.Location = new Point(12, 37);
			tbcntrlMenus.Margin = new Padding(3, 4, 3, 4);
			tbcntrlMenus.Name = "tbcntrlMenus";
			tbcntrlMenus.SelectedIndex = 0;
			tbcntrlMenus.Size = new Size(1714, 875);
			tbcntrlMenus.TabIndex = 36;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1774, 1050);
			Controls.Add(tbcntrlMenus);
			Controls.Add(menuStrip1);
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			tbMacros.ResumeLayout(false);
			tbMacros.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			tbInicio.ResumeLayout(false);
			tbInicio.PerformLayout();
			grpJog.ResumeLayout(false);
			grpJog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tbVelocidad).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbXHome).EndInit();
			((System.ComponentModel.ISupportInitialize)pbYHome).EndInit();
			((System.ComponentModel.ISupportInitialize)pbZHome).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			tbcntrlMenus.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem configuraciónToolStripMenuItem;
		private TabPage tbMacros;
		private PictureBox pictureBox3;
		private PictureBox pictureBox4;
		private PictureBox pictureBox5;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox txtValor4MovMacro;
		private TextBox txtValor3MovMacro;
		private TextBox txtValor2MovMacro;
		private TextBox txtValor1MovMacro;
		private TextBox txtNombreArchivoMacros;
		private RichTextBox rtxtCodigoPieza;
		private RichTextBox rtxtCodigoComando;
		private TextBox txtNombreComando;
		private Label label1;
		private Button btnAgregarMovMacro;
		private Label lblFMovMacro;
		private ComboBox cbTipoDeComando;
		private Label lblZMovMacro;
		private Label lblYMovMacro;
		private Label lblXMovMacro;
		private Button btnCrearArchivoMacros;
		private Label lblCrearNuevoMacro;
		private Button btnCrearNuevoArchivoDeMacros;
		private Button btnCambiarArchivoMacros;
		private PictureBox pictureBox2;
		private Button btnAbrirArchivoMacros;
		private Button btnGuardarMacros;
		private Button btnEliminarComando;
		private CheckBox chbxOrdenarLbxComandos;
		private Button btnResetComandos;
		private Button btnStopComandos;
		private Button btnCorrerComandoUnitario;
		private RadioButton rbtnAgregarNuevoComando;
		private Button btnGuardarCodigoG;
		private Button btnCorrerCodigo;
		private Button btnCancelar;
		private Button btnCargarAPieza;
		private Button btnAgregarComando;
		private Button btnGuardar;
		private ListBox lbxInstrucciones;
		private Label lblTituloCodigoPieza;
		private Label lblTituloCodigoG;
		private Label lblTituloNombre;
		private Label lblTituloComandos;
		private TabPage tbInicio;
		private Button button6;
		private Button button5;
		private Button btnGuardarEjemplo;
		private DataGridView dataGridView1;
		private DataGridViewComboBoxColumn tipoMov;
		private DataGridViewTextBoxColumn xCoord;
		private DataGridViewTextBoxColumn yCoord;
		private DataGridViewTextBoxColumn zCoord;
		private DataGridViewComboBoxColumn salidasId;
		private DataGridViewComboBoxColumn entradaId;
		private PictureBox pbZHome;
		private PictureBox pbYHome;
		private PictureBox pbXHome;
		private PictureBox pictureBox1;
		private Label lblX;
		private Label lblY;
		private GroupBox grpJog;
		private Button button4;
		private Button button3;
		private TextBox txtMostrarVelocidad;
		private Label lblMostrarVelocidad;
		private TrackBar tbVelocidad;
		private Label lblJogVelocityTitulo;
		private Button btnZplus;
		private Button btnHome;
		private Button btnZMinus;
		private Button btnYPlus;
		private Button btnYMinus;
		private Button btnJogXPlus;
		private Button btnXMinus;
		private Label lblZ;
		private TextBox txtX;
		private TextBox txtY;
		private TextBox txtZ;
		private TabControl tbcntrlMenus;
	}
}
