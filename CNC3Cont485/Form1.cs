using System.Data;
using System.Windows.Forms;

namespace CNC3Cont485
{
	public partial class Form1 : Form
	{
		private List<Movimiento> rutina = [];
		private int rowCountEarly = 0;
		private bool cambioContenidoCeldas = false;
		//private bool jogEnable = false;
		public static Conexion485 conexion = new();
		public static Conexion485 conexion2 = new();
		public static Conexion485 conexionArd = new();
		private bool sysHomed = false;
		//private object dataGridView1;
		private bool programaDetenido = true;

		public Form1()
		{

			InitializeComponent();


		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadingForm loadingForm = new();
			loadingForm.ShowDialog();
			if (!conexion.servoport.IsOpen && !conexion2.servoport.IsOpen && !conexionArd.servoport.IsOpen)
			{
				this.Close();
			}
			else
			{
				//ConfigurarTabla();
				dgvMovimientos.Columns[1].Width = 120;
				dgvMovimientos.Columns[2].Width = 120;
				dgvMovimientos.Columns[3].Width = 120;
				//dgvMovimientos.Columns[4].Width = 100;
				dgvMovimientos.Columns[5].Width = 120;
				dgvMovimientos.Columns[6].Width = 120;

				//CrearListaMovimientos();
			}

		}

		private void btnStartCycle_Click(object sender, EventArgs e)
		{
			if (dgvMovimientos.Rows.Count >= 1)
			{
				CrearListaMovimientos();
				programaDetenido = false;
				CorrerRutina();

			}

		}
		private void CorrerRutina()
		{
			if (sysHomed)
			{
				while (!programaDetenido)
				{
					conexion.servoport.ReadTimeout = System.IO.Ports.SerialPort.InfiniteTimeout;
					lblAvisoBoton.Visible = true;
					bool resultbtn = InOut.ReadPIC(23);
					conexion.servoport.ReadTimeout = 500;
					if (resultbtn)
					{
						foreach (var movimiento in rutina)
						{
							//var resIn = MessageBox.Show("Espera que termine de moverse para dar ok", "Seguir", MessageBoxButtons.OKCancel);

							while (true)
							{
								if (InOut.ReadPIC(9))
								{
									programaDetenido = true;
									break;
								}
							}
							//                 if (resIn == DialogResult.Cancel)
							//                 {
							//programaDetenido = true;
							//break;
							//                 }
							if (!programaDetenido)
							{
								movimiento.EjecutarMovimiento();
							}
						}
						//var res = MessageBox.Show("Repetir ciclo?", "Seguir", MessageBoxButtons.OKCancel);

						//if (res == DialogResult.Cancel)
						//{
						//	programaDetenido = true;
						//	break;
						//}
					}

				}

			}
			else
			{
				MessageBox.Show("El sistema no est� referenciado, haga un homming antes de correr la rutina.");
			}
		}
		private void CrearListaMovimientos()
		{
			string? tipo;
			double x;
			double y;
			double z;
			//double a;
			int espera;
			int rpm;
			string? salida;
			string? entrada;
			if (dgvMovimientos.Rows.Count - 1 > 0)
			{
				if (rowCountEarly < dgvMovimientos.Rows.Count || cambioContenidoCeldas)
				{
					rutina.Clear();
					rowCountEarly = dgvMovimientos.Rows.Count;
					for (int i = 0; i < dgvMovimientos.Rows.Count - 1; i++)
					{
						DataGridViewRow fila = dgvMovimientos.Rows[i];
						if (fila.Cells[0].FormattedValue.ToString() != null)
						{
							tipo = fila.Cells[0].FormattedValue.ToString();
							x = fila.Cells[1].Value != null ? Convert.ToDouble(fila.Cells[1].Value) : double.NaN;
							y = fila.Cells[2].Value != null ? Convert.ToDouble(fila.Cells[2].Value) : double.NaN;
							z = fila.Cells[3].Value != null ? Convert.ToDouble(fila.Cells[3].Value) : double.NaN;
							//a = fila.Cells[4].Value != null ? Convert.ToDouble(fila.Cells[4].Value) : double.NaN;
							espera = Convert.ToInt16(fila.Cells[5].Value);
							rpm = Convert.ToInt16(fila.Cells[6].Value);
							salida = fila.Cells[7].FormattedValue.ToString();
							entrada = fila.Cells[8].FormattedValue.ToString();

							rutina.Add(new(tipo!, x, y, z, espera, rpm, salida!, entrada!));
						}



					}
					cambioContenidoCeldas = false;
				}
			}

		}
		private void dgvMovimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			cambioContenidoCeldas = true;
			if (e.ColumnIndex == 0 && e.RowIndex >= 0)
			{
				// Obtiene el valor seleccionado en "Tipo de Movimiento"
				var tipoMovimiento = dgvMovimientos.Rows[e.RowIndex].Cells[0].Value.ToString();

				// Si es "Doblado", establece la columna Y (columna 2) como ReadOnly
				if (tipoMovimiento == "Doblado")
				{
					dgvMovimientos.Rows[e.RowIndex].Cells[2].ReadOnly = true; // Columna Y
					dgvMovimientos.Rows[e.RowIndex].Cells[3].ReadOnly = true; // Columna Z
				}
				else
				{
					dgvMovimientos.Rows[e.RowIndex].Cells[2].ReadOnly = false; // Habilita Y si no es "Doblado"
					dgvMovimientos.Rows[e.RowIndex].Cells[3].ReadOnly = false; // Habilita Z si no es "Doblado"
				}
			}
			else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
			{
				// Obtiene el valor seleccionado en "Tipo de Movimiento"
				var tipoMovimiento = dgvMovimientos.Rows[e.RowIndex].Cells[0].Value.ToString();

				if (tipoMovimiento == "Doblado")
				{
					CalcularY();
				}

			}


		}
		private void CalcularY()
		{
			if (dgvMovimientos.SelectedCells.Count > 0)
			{
				var selectedCell = dgvMovimientos.SelectedCells[0];
				int colIndex = selectedCell.ColumnIndex;
				if (colIndex == 1)
				{
					int rowIndex = selectedCell.RowIndex;
					double x = Convert.ToDouble(selectedCell.Value.ToString());
					var row = dgvMovimientos.Rows[rowIndex];
					double result = Movimiento.CalcularYParaDoblado(0.3165, x);
					result = Math.Round(result, 3);
					row.Cells[2].Value = result;
				}
			}
		}

		private void btnJogXPlus_MouseDown(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(3, true);
		}
		private void btnJogXPlus_MouseUp(object sender, MouseEventArgs e)
		{
			//jogEnable = false;
			InOut.WritePIC(3, false);
		}
		private void btnYPlus_MouseDown(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(5, true);
		}
		private void btnYPlus_MouseUp(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(5, false);
		}
		private void btnZPlus_MouseDown(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(7, true);
		}
		private void btnZPlus_MouseUp(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(7, false);
		}
		private void btnXMinus_MouseDown(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(4, true);
		}
		private void btnXMinus_MouseUp(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(4, false);
		}
		private void btnYMinus_MouseDown(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(6, true);
		}
		private void btnYMinus_MouseUp(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(6, false);
		}
		private void btnZMinus_MouseDown(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(8, true);
		}
		private void btnZMinus_MouseUp(object sender, MouseEventArgs e)
		{
			InOut.WritePIC(8, false);
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			programaDetenido = true;
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			sysHomed = InOut.WritePIC(14, true);
			if (sysHomed)
			{
				MessageBox.Show("El sistema est� referenciado", "HOME");
			}
			else
			{
				MessageBox.Show("El sistema no logr� referenciarse intentelo nuevamente", "HOME");
			}
		}

		
	}
}
