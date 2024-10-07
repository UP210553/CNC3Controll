using System.Data;
using System.Windows.Forms;

namespace CNC3Cont485
{
	public partial class Form1 : Form
	{
		private List<Movimiento> rutina = [];
		private int rowCountEarly = 0;
		private bool cambioContenidoCeldas = false;
		private bool jogEnable = false;
		Conexion485 conexion = new();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//ConfigurarTabla();
			dgvMovimientos.Columns[1].Width = 100;
			dgvMovimientos.Columns[2].Width = 100;
			dgvMovimientos.Columns[3].Width = 100;
			dgvMovimientos.Columns[4].Width = 100;
			dgvMovimientos.Columns[5].Width = 100;
			dgvMovimientos.Columns[6].Width = 100;
			conexion.AbrirConexion("com5");

			//CrearListaMovimientos();
		}

		private void btnStartCycle_Click(object sender, EventArgs e)
		{
			CrearListaMovimientos();
		}

		private void CrearListaMovimientos()
		{
			string? tipo = string.Empty;
			double x;
			double y;
			double z;
			double a;
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
							a = fila.Cells[4].Value != null ? Convert.ToDouble(fila.Cells[4].Value) : double.NaN;
							espera = Convert.ToInt16(fila.Cells[5].Value);
							rpm = Convert.ToInt16(fila.Cells[6].Value);
							salida = fila.Cells[7].FormattedValue.ToString();
							entrada = fila.Cells[8].FormattedValue.ToString();

							rutina.Add(new(tipo!, x, y, z, a, espera, rpm, salida!, entrada!));
						}



					}
					cambioContenidoCeldas = false;
				}
			}

		}

		private void dgvMovimientos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			cambioContenidoCeldas = true;
		}
		
		private void btnCalcularY_Click(object sender, EventArgs e)
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

		private async void JogXPMov()
		{
			await Task.Run(() =>
			{
				while (jogEnable)
				{
					JOG.JogXPlus(conexion, "200");
					// Agregar una pausa corta para evitar sobrecargar el procesador
					Thread.Sleep(100);
				}
			});
		}
		private async void JogXMMov()
		{
			await Task.Run(() =>
			{
				while (jogEnable)
				{
					JOG.JogXMinus(conexion, "200");
					// Agregar una pausa corta para evitar sobrecargar el procesador
					Thread.Sleep(100);
				}
			});
		}

		private void btnJogXPlus_MouseDown(object sender, MouseEventArgs e)
		{
			jogEnable = true;
			JogXPMov();
		}

		private void btnJogXPlus_MouseUp(object sender, MouseEventArgs e)
		{
			jogEnable = false;
		}

		private void btnXMinus_MouseDown(object sender, MouseEventArgs e)
		{
			jogEnable = true;
			JogXMMov();
		}

		private void btnXMinus_MouseUp(object sender, MouseEventArgs e)
		{
			jogEnable = false;
		}
	}
}
