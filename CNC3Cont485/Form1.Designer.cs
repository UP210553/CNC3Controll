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
			tbInicio = new TabPage();
			button6 = new Button();
			button5 = new Button();
			btnGuardarEjemplo = new Button();
			dgvMovimientos = new DataGridView();
			tipoMov = new DataGridViewComboBoxColumn();
			xCoord = new DataGridViewTextBoxColumn();
			yCoord = new DataGridViewTextBoxColumn();
			zCoord = new DataGridViewTextBoxColumn();
			aCoord = new DataGridViewTextBoxColumn();
			delayTime = new DataGridViewTextBoxColumn();
			velocidad = new DataGridViewTextBoxColumn();
			salidasId = new DataGridViewComboBoxColumn();
			entradaId = new DataGridViewComboBoxColumn();
			pbZHome = new PictureBox();
			pbYHome = new PictureBox();
			pbXHome = new PictureBox();
			pictureBox1 = new PictureBox();
			lblX = new Label();
			lblY = new Label();
			grpJog = new GroupBox();
			btnStop = new Button();
			btnStartCycle = new Button();
			txtMostrarVelocidad = new TextBox();
			lblMostrarVelocidad = new Label();
			tbVelocidad = new TrackBar();
			lblJogVelocityTitulo = new Label();
			btnZplus = new Button();
			btnHome = new Button();
			btnZMinus = new Button();
			btnYPlus = new Button();
			btnYMinus = new Button();
			btnJogXPlus = new Button();
			btnXMinus = new Button();
			lblZ = new Label();
			txtX = new TextBox();
			txtY = new TextBox();
			txtZ = new TextBox();
			tbcntrlMenus = new TabControl();
			tbInicio.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbZHome).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbYHome).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbXHome).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			grpJog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)tbVelocidad).BeginInit();
			tbcntrlMenus.SuspendLayout();
			SuspendLayout();
			// 
			// tbInicio
			// 
			tbInicio.BackColor = SystemColors.Control;
			tbInicio.Controls.Add(button6);
			tbInicio.Controls.Add(button5);
			tbInicio.Controls.Add(btnGuardarEjemplo);
			tbInicio.Controls.Add(dgvMovimientos);
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
			tbInicio.Size = new Size(1762, 872);
			tbInicio.TabIndex = 0;
			tbInicio.Text = "Inicio";
			// 
			// button6
			// 
			button6.Location = new Point(661, 37);
			button6.Name = "button6";
			button6.Size = new Size(120, 82);
			button6.TabIndex = 39;
			button6.Text = "Abrir nuevo";
			button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(525, 37);
			button5.Name = "button5";
			button5.Size = new Size(120, 82);
			button5.TabIndex = 38;
			button5.Text = "Abrir rutina";
			button5.UseVisualStyleBackColor = true;
			// 
			// btnGuardarEjemplo
			// 
			btnGuardarEjemplo.Location = new Point(387, 37);
			btnGuardarEjemplo.Name = "btnGuardarEjemplo";
			btnGuardarEjemplo.Size = new Size(120, 82);
			btnGuardarEjemplo.TabIndex = 37;
			btnGuardarEjemplo.Text = "Guardar rutina";
			btnGuardarEjemplo.UseVisualStyleBackColor = true;
			// 
			// dgvMovimientos
			// 
			dgvMovimientos.AllowUserToResizeColumns = false;
			dgvMovimientos.AllowUserToResizeRows = false;
			dgvMovimientos.BackgroundColor = SystemColors.Control;
			dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { tipoMov, xCoord, yCoord, zCoord, aCoord, delayTime, velocidad, salidasId, entradaId });
			dgvMovimientos.Location = new Point(10, 233);
			dgvMovimientos.MultiSelect = false;
			dgvMovimientos.Name = "dgvMovimientos";
			dgvMovimientos.RowHeadersWidth = 62;
			dgvMovimientos.Size = new Size(1114, 569);
			dgvMovimientos.TabIndex = 36;
			dgvMovimientos.CellValueChanged += dgvMovimientos_CellValueChanged;
			// 
			// tipoMov
			// 
			tipoMov.Frozen = true;
			tipoMov.HeaderText = "Tipo de Movimiento";
			tipoMov.Items.AddRange(new object[] { "Incremental", "Absoluto", "Doblado" });
			tipoMov.MinimumWidth = 8;
			tipoMov.Name = "tipoMov";
			tipoMov.Width = 150;
			// 
			// xCoord
			// 
			xCoord.Frozen = true;
			xCoord.HeaderText = "X";
			xCoord.MinimumWidth = 8;
			xCoord.Name = "xCoord";
			xCoord.Resizable = DataGridViewTriState.False;
			xCoord.SortMode = DataGridViewColumnSortMode.NotSortable;
			xCoord.Width = 150;
			// 
			// yCoord
			// 
			yCoord.Frozen = true;
			yCoord.HeaderText = "Y";
			yCoord.MinimumWidth = 8;
			yCoord.Name = "yCoord";
			yCoord.Width = 150;
			// 
			// zCoord
			// 
			zCoord.Frozen = true;
			zCoord.HeaderText = "Z";
			zCoord.MinimumWidth = 8;
			zCoord.Name = "zCoord";
			zCoord.Width = 150;
			// 
			// aCoord
			// 
			aCoord.Frozen = true;
			aCoord.HeaderText = "A";
			aCoord.MinimumWidth = 8;
			aCoord.Name = "aCoord";
			aCoord.Visible = false;
			aCoord.Width = 150;
			// 
			// delayTime
			// 
			delayTime.HeaderText = "Delay (s)";
			delayTime.MinimumWidth = 8;
			delayTime.Name = "delayTime";
			delayTime.Width = 150;
			// 
			// velocidad
			// 
			velocidad.HeaderText = "RPM";
			velocidad.MinimumWidth = 8;
			velocidad.Name = "velocidad";
			velocidad.Width = 150;
			// 
			// salidasId
			// 
			salidasId.HeaderText = "Salida";
			salidasId.Items.AddRange(new object[] { "Clamp ON", "Clamp OFF", "Chuck ON", "Chuck OFF" });
			salidasId.MinimumWidth = 8;
			salidasId.Name = "salidasId";
			salidasId.Width = 150;
			// 
			// entradaId
			// 
			entradaId.HeaderText = "Entrada";
			entradaId.Items.AddRange(new object[] { "Botón 1", "Botón 2" });
			entradaId.MinimumWidth = 8;
			entradaId.Name = "entradaId";
			entradaId.Width = 150;
			// 
			// pbZHome
			// 
			pbZHome.BackColor = Color.Red;
			pbZHome.BorderStyle = BorderStyle.FixedSingle;
			pbZHome.Location = new Point(1181, 172);
			pbZHome.Margin = new Padding(3, 4, 3, 4);
			pbZHome.Name = "pbZHome";
			pbZHome.Size = new Size(48, 48);
			pbZHome.TabIndex = 35;
			pbZHome.TabStop = false;
			// 
			// pbYHome
			// 
			pbYHome.BackColor = Color.Red;
			pbYHome.BorderStyle = BorderStyle.FixedSingle;
			pbYHome.Location = new Point(1181, 97);
			pbYHome.Margin = new Padding(3, 4, 3, 4);
			pbYHome.Name = "pbYHome";
			pbYHome.Size = new Size(48, 48);
			pbYHome.TabIndex = 34;
			pbYHome.TabStop = false;
			// 
			// pbXHome
			// 
			pbXHome.BackColor = Color.Red;
			pbXHome.BorderStyle = BorderStyle.FixedSingle;
			pbXHome.Location = new Point(1181, 24);
			pbXHome.Margin = new Padding(3, 4, 3, 4);
			pbXHome.Name = "pbXHome";
			pbXHome.Size = new Size(48, 48);
			pbXHome.TabIndex = 33;
			pbXHome.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.logo_web_tech_pequeno;
			pictureBox1.Location = new Point(10, 37);
			pictureBox1.Margin = new Padding(4, 6, 4, 6);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Padding = new Padding(10);
			pictureBox1.Size = new Size(282, 82);
			pictureBox1.TabIndex = 24;
			pictureBox1.TabStop = false;
			// 
			// lblX
			// 
			lblX.AutoSize = true;
			lblX.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblX.Location = new Point(1242, 27);
			lblX.Margin = new Padding(4, 0, 4, 0);
			lblX.Name = "lblX";
			lblX.Size = new Size(42, 40);
			lblX.TabIndex = 8;
			lblX.Text = "X";
			// 
			// lblY
			// 
			lblY.AutoSize = true;
			lblY.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblY.Location = new Point(1243, 100);
			lblY.Margin = new Padding(4, 0, 4, 0);
			lblY.Name = "lblY";
			lblY.Size = new Size(41, 40);
			lblY.TabIndex = 9;
			lblY.Text = "Y";
			// 
			// grpJog
			// 
			grpJog.Controls.Add(btnStop);
			grpJog.Controls.Add(btnStartCycle);
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
			grpJog.Location = new Point(1150, 232);
			grpJog.Margin = new Padding(4, 6, 4, 6);
			grpJog.Name = "grpJog";
			grpJog.Padding = new Padding(4, 6, 4, 6);
			grpJog.Size = new Size(548, 517);
			grpJog.TabIndex = 6;
			grpJog.TabStop = false;
			grpJog.Text = "Jog";
			// 
			// btnStop
			// 
			btnStop.BackColor = Color.Red;
			btnStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnStop.Location = new Point(221, 44);
			btnStop.Margin = new Padding(3, 4, 3, 4);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(130, 88);
			btnStop.TabIndex = 43;
			btnStop.Text = "STOP";
			btnStop.UseVisualStyleBackColor = false;
			btnStop.Click += btnStop_Click;
			// 
			// btnStartCycle
			// 
			btnStartCycle.BackColor = Color.Lime;
			btnStartCycle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			btnStartCycle.Location = new Point(17, 44);
			btnStartCycle.Margin = new Padding(3, 4, 3, 4);
			btnStartCycle.Name = "btnStartCycle";
			btnStartCycle.Size = new Size(130, 88);
			btnStartCycle.TabIndex = 42;
			btnStartCycle.Text = "START";
			btnStartCycle.UseVisualStyleBackColor = false;
			btnStartCycle.Click += btnStartCycle_Click;
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
			btnJogXPlus.MouseDown += btnJogXPlus_MouseDown;
			btnJogXPlus.MouseUp += btnJogXPlus_MouseUp;
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
			btnXMinus.MouseDown += btnXMinus_MouseDown;
			btnXMinus.MouseUp += btnXMinus_MouseUp;
			// 
			// lblZ
			// 
			lblZ.AutoSize = true;
			lblZ.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblZ.Location = new Point(1243, 172);
			lblZ.Margin = new Padding(4, 0, 4, 0);
			lblZ.Name = "lblZ";
			lblZ.Size = new Size(40, 40);
			lblZ.TabIndex = 10;
			lblZ.Text = "Z";
			// 
			// txtX
			// 
			txtX.BackColor = Color.Black;
			txtX.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtX.ForeColor = Color.Lime;
			txtX.Location = new Point(1301, 24);
			txtX.Margin = new Padding(4, 6, 4, 6);
			txtX.Name = "txtX";
			txtX.Size = new Size(266, 48);
			txtX.TabIndex = 11;
			txtX.TextAlign = HorizontalAlignment.Right;
			// 
			// txtY
			// 
			txtY.BackColor = Color.Black;
			txtY.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtY.ForeColor = Color.Lime;
			txtY.Location = new Point(1301, 97);
			txtY.Margin = new Padding(4, 6, 4, 6);
			txtY.Name = "txtY";
			txtY.Size = new Size(266, 48);
			txtY.TabIndex = 12;
			txtY.TextAlign = HorizontalAlignment.Right;
			// 
			// txtZ
			// 
			txtZ.BackColor = Color.Black;
			txtZ.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtZ.ForeColor = Color.Lime;
			txtZ.Location = new Point(1301, 172);
			txtZ.Margin = new Padding(4, 6, 4, 6);
			txtZ.Name = "txtZ";
			txtZ.Size = new Size(266, 48);
			txtZ.TabIndex = 13;
			txtZ.TextAlign = HorizontalAlignment.Right;
			// 
			// tbcntrlMenus
			// 
			tbcntrlMenus.Controls.Add(tbInicio);
			tbcntrlMenus.Location = new Point(3, 2);
			tbcntrlMenus.Margin = new Padding(3, 4, 3, 4);
			tbcntrlMenus.Name = "tbcntrlMenus";
			tbcntrlMenus.SelectedIndex = 0;
			tbcntrlMenus.Size = new Size(1770, 910);
			tbcntrlMenus.TabIndex = 36;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1774, 1050);
			Controls.Add(tbcntrlMenus);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "MAINDSTEEL Control CNC";
			Load += Form1_Load;
			tbInicio.ResumeLayout(false);
			tbInicio.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
			((System.ComponentModel.ISupportInitialize)pbZHome).EndInit();
			((System.ComponentModel.ISupportInitialize)pbYHome).EndInit();
			((System.ComponentModel.ISupportInitialize)pbXHome).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			grpJog.ResumeLayout(false);
			grpJog.PerformLayout();
			((System.ComponentModel.ISupportInitialize)tbVelocidad).EndInit();
			tbcntrlMenus.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private TabPage tbInicio;
		private Button button6;
		private Button button5;
		private Button btnGuardarEjemplo;
		private DataGridView dgvMovimientos;
		private PictureBox pbZHome;
		private PictureBox pbYHome;
		private PictureBox pbXHome;
		private PictureBox pictureBox1;
		private Label lblX;
		private Label lblY;
		private GroupBox grpJog;
		private Button btnStop;
		private Button btnStartCycle;
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
		private DataGridViewComboBoxColumn tipoMov;
		private DataGridViewTextBoxColumn xCoord;
		private DataGridViewTextBoxColumn yCoord;
		private DataGridViewTextBoxColumn zCoord;
		private DataGridViewTextBoxColumn aCoord;
		private DataGridViewTextBoxColumn delayTime;
		private DataGridViewTextBoxColumn velocidad;
		private DataGridViewComboBoxColumn salidasId;
		private DataGridViewComboBoxColumn entradaId;
	}
}
