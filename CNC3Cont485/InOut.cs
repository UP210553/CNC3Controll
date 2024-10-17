using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNC3Cont485
{
	public class InOut
	{
		public SerialPort picPort = new SerialPort();
		private string respuesta = "";
		public bool AbrirConexion(string portName)
		{
			picPort.BaudRate = 9600;
			picPort.DataBits = 8;
			picPort.Parity = Parity.None;
			picPort.DtrEnable = true;
			picPort.ReadBufferSize = 4096;
			picPort.WriteBufferSize = 2048;
			picPort.StopBits = StopBits.Two;
			picPort.ReadTimeout = 1000;

			try
			{
				picPort.PortName = portName;
				picPort.Open();
				picPort.DiscardInBuffer();
				MessageBox.Show($"Puerto {portName} abierto correctamente", "Conexión 485", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return false;

			}
		}

		private bool ExecIO(string comando)
		{

			bool result;
			string respuestaEsperada = "";
			string comandoOk = "";
			string mensaje = "";
			respuesta = "";
			DateTime startTime = DateTime.Now;
			TimeSpan timeout = TimeSpan.FromSeconds(6);
			if (comando.Contains("M66") && !comando.Contains("M66P5"))
			{
				if (comando.Length > 7)
				{
					comando = comando.Substring(0, 7);
				}
				if (comando.Contains("P3L3"))
				{
					respuestaEsperada = "B2presi";
					comandoOk = "OK___B2";
					mensaje = "Presione botón 2";
				}
				else if (comando.Contains("P3L4"))
				{
					respuestaEsperada = "B2liber";
					comandoOk = "OK___B2";
					mensaje = "Presione botón 2";
				}
				else if (comando.Contains("P4L3"))
				{
					respuestaEsperada = "B1presi";
					comandoOk = "OK___B1";
					mensaje = "Presione botón 1";
				}
				else if (comando.Contains("P4L4"))
				{
					respuestaEsperada = "B1liber";
					comandoOk = "OK___B1";
					mensaje = "Presione botón 1";
				}

				picPort.Write(comando);
				Console.WriteLine(comando);
				MessageBox.Show(mensaje, "Acción de operario", MessageBoxButtons.OK, MessageBoxIcon.Information);
				while (respuesta == "")
				{
				}
				while (respuesta != respuestaEsperada)
				{

					if (respuesta == "")
					{
						comando = comando.Replace("M66", "M70");
						Console.WriteLine("Comando error:" + comando);
						picPort.Write(comando);
						Thread.Sleep(500);
					}
					else if ((DateTime.Now - startTime) > timeout)
					{
						Console.WriteLine("Se ha superado el tiempo de espera.");
						return false;
					}
					else if (respuesta != "" && respuesta != respuestaEsperada)
					{
						Console.WriteLine("Error: " + respuesta);
						respuesta = "";
					}
				}
				Thread.Sleep(500);
				picPort.Write(comandoOk);
				Thread.Sleep(200);
				Console.WriteLine(comandoOk);

			}
			else if ((comando.Contains("M65") || comando.Contains("M64")))
			{
				if (comando.Length > 5)
				{
					comando = comando.Substring(0, 5);
				}

				if (comando.Contains("5P4"))
				{
					respuestaEsperada = "CLMp_OF";
				}
				else if (comando.Contains("5P3"))
				{
					respuestaEsperada = "CHUK_OF";
				}
				else if (comando.Contains("4P3"))
				{
					respuestaEsperada = "CHUK_ON";
				}
				else if (comando.Contains("4P4"))
				{
					respuestaEsperada = "CLMp_ON";
				}
				Thread.Sleep(200);
				picPort.Write(comando + "__");
				Console.WriteLine(comando + "__");
				while (true)
				{
					if (respuesta != "")
					{
						break;
					}
					else if ((DateTime.Now - startTime) > timeout)
					{
						Console.WriteLine("Se ha superado el tiempo de espera.");
						break;
					}
				}


			}
			else
			{
				Console.Error.WriteLine($"{comando} no cumple las caracteristicas de una entrada o salida");
				MessageBox.Show($"{comando} no cumple las caracteristicas de una entrada o salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			result = (respuesta == respuestaEsperada);


			//Console.WriteLine(respuesta);
			return result;
		}
	}
}
