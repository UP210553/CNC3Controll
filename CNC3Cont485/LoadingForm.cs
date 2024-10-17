using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC3Cont485
{
	public partial class LoadingForm : Form
	{
		public LoadingForm()
		{
			InitializeComponent();
		}

		private void LoadingForm_Shown(object sender, EventArgs e)
		{
			this.Refresh();
			CargarConexiones();
            
			
		}
		public void CargarConexiones()
		{
			bool seLogro = false;
			//Thread.Sleep(6000);
			for (int i = 0; i < 3; i++)
			{
				this.Refresh();
				bool conexionX = false;
				bool conexionY = false;
				bool conexionZ = false;
				lblLoading.Text = "Intentando abrir conexión 1...";
				this.Refresh();
				Thread.Sleep(250);
				bool abrioCon1 = Form1.conexion.AbrirConexion("com5");
				lblLoading.Text = "Intentando abrir conexión 2...";
				this.Refresh();
				Thread.Sleep(250);
				bool abrioCon2 = Form1.conexion2.AbrirConexion("com7");
				if (abrioCon1 && abrioCon2)
				{
					lblLoading.Text = "Comprobando conexión X";
					this.Refresh();
					conexionX = Form1.conexion.ComprobarConexionServo("X");
					//Thread.Sleep(250);
					Thread.Sleep(1000);
					lblLoading.Text = "Comprobando conexión Y";
					this.Refresh();
					conexionY = Form1.conexion2.ComprobarConexionServo("Y");
					//Thread.Sleep(250);
					Thread.Sleep(1000);
					lblLoading.Text = "Comprobando conexión Z";
					this.Refresh();
					conexionZ = Form1.conexion.ComprobarConexionServo("Z");
					//Thread.Sleep(250);
					Thread.Sleep(1000);
				}
				if (conexionX && prgsbrCargaSistema.Value == 0)
				{
					lblLoading.Text = "Conexión X comprobada";
					prgsbrCargaSistema.Value++;
					//Thread.Sleep(100);
					Thread.Sleep(1000);
				}
				if (conexionY && prgsbrCargaSistema.Value == 1)
				{
					lblLoading.Text = "Conexión Y comprobada";
					prgsbrCargaSistema.Value++;
					//Thread.Sleep(100);
					Thread.Sleep(1000);
				}
				if (conexionZ && prgsbrCargaSistema.Value == 2)
				{
					lblLoading.Text = "Conexión Z comprobada";
					prgsbrCargaSistema.Value++;
					//Thread.Sleep(100);
					Thread.Sleep(1000);
				}
				if (prgsbrCargaSistema.Value == 3)
				{
					lblLoading.Text = "Conexión completa";
					//Thread.Sleep(100);
					seLogro = true;
					Thread.Sleep(1000);
					break;
				}
			}
			if (seLogro)
			{
				lblLoading.Text = "Conexión exitosa iniciando programa";
				Thread.Sleep(250);
			}
			else
			{
				lblLoading.Text = "Conexión fallida cerrando sistema";
				Thread.Sleep(250);
			}
			this.Close();
		}
	}
}
