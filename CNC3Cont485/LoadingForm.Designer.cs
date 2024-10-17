namespace CNC3Cont485
{
	partial class LoadingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
			prgsbrCargaSistema = new ProgressBar();
			lblLoading = new Label();
			ptrBoxMaind = new PictureBox();
			((System.ComponentModel.ISupportInitialize)ptrBoxMaind).BeginInit();
			SuspendLayout();
			// 
			// prgsbrCargaSistema
			// 
			prgsbrCargaSistema.Location = new Point(239, 243);
			prgsbrCargaSistema.Maximum = 3;
			prgsbrCargaSistema.Name = "prgsbrCargaSistema";
			prgsbrCargaSistema.Size = new Size(282, 34);
			prgsbrCargaSistema.TabIndex = 0;
			// 
			// lblLoading
			// 
			lblLoading.AutoSize = true;
			lblLoading.Location = new Point(239, 203);
			lblLoading.Name = "lblLoading";
			lblLoading.Size = new Size(102, 25);
			lblLoading.TabIndex = 1;
			lblLoading.Text = "Cargando...";
			// 
			// ptrBoxMaind
			// 
			ptrBoxMaind.Image = Properties.Resources.logo_web_tech_pequeno;
			ptrBoxMaind.Location = new Point(239, 101);
			ptrBoxMaind.Margin = new Padding(4, 6, 4, 6);
			ptrBoxMaind.Name = "ptrBoxMaind";
			ptrBoxMaind.Padding = new Padding(10);
			ptrBoxMaind.Size = new Size(282, 82);
			ptrBoxMaind.TabIndex = 25;
			ptrBoxMaind.TabStop = false;
			// 
			// LoadingForm
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(ptrBoxMaind);
			Controls.Add(lblLoading);
			Controls.Add(prgsbrCargaSistema);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "LoadingForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Cargando";
			Shown += LoadingForm_Shown;
			((System.ComponentModel.ISupportInitialize)ptrBoxMaind).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ProgressBar prgsbrCargaSistema;
		private Label lblLoading;
		private PictureBox ptrBoxMaind;
	}
}