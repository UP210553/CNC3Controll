using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNC3Cont485
{
	public class Conexion485
	{
		public SerialPort servoport = new SerialPort();

		public bool AbrirConexion(string portName)
		{
			servoport.BaudRate = 9600;
			servoport.DataBits = 8;
			servoport.Parity = Parity.None;
			servoport.DtrEnable = true;
			servoport.ReadBufferSize = 4096;
			servoport.WriteBufferSize = 2048;
			servoport.StopBits = StopBits.Two;
			servoport.ReadTimeout = 1000;

			try
			{
				servoport.PortName = portName;
				servoport.Open();
				servoport.DiscardInBuffer();
				//MessageBox.Show($"Puerto {portName} abierto correctamente", "Conexión 485", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			catch (Exception ex)
			{
				//MessageBox.Show($"Error: {ex.Message}");
				return false;

			}
		}

		/// <summary>
		/// Escribe un dato ingresado por el usuario en la dirección deseada de un servomotor
		/// </summary>
		/// <param name="dir">Cadena de caracteres que representa la dirección del parametro a modificar en el servo.</param>
		/// <param name="dat">Cadena de caracteres que representa el dato que se escribirá en el parametro seleccionado.</param>
		/// <param name="idServo">Cadena de caracteres que representa el id de esclavo del servomotor en la red 485.</param>
		/// <returns><c>true</c> si el valor se escribe de forma correcta en el servomotor; <c>false</c> si hubo algún error</returns>
		public bool EscribirServo(string dir, string dat, string idServo)
		{
			Int16 direccion = Convert.ToInt16(dir);
			Int16 dato = Convert.ToInt16(dat);
			uint servoId;
			switch (idServo)
			{
				case "X":
					servoId = 1;
					break;
				case "Y":
					servoId = 2;
					break;
				case "Z":
					servoId = 3;
					break;
				case "A":
					servoId = 4;
					break;
				default:
					MessageBox.Show($"Error: Dirección de servo desconocida o inexistente");
					return false;
			}

			//bool correcto = Write_servo(direccion, dato, idServo);
			bool correcto = WriteServoRTU(direccion, dato, servoId);
			if (correcto)
			{
				//MessageBox.Show($"Se escribió {dato} en la dirección {direccion} del servo {idServo}");
				return true;
			}
			else
			{
				//MessageBox.Show($"No se escribió correctamente");
				return false;
			}
		}

		public bool LeerServo(string dir, string idServo)
		{

			Int16 direccion = Convert.ToInt16(dir);
			uint servoId;
			switch (idServo)
			{
				case "X":
					servoId = 1;
					break;
				case "Y":
					servoId = 2;
					break;
				case "Z":
					servoId = 3;
					break;
				case "A":
					servoId = 4;
					break;
				default:
					MessageBox.Show($"Error: Dirección de servo desconocida o inexistente");
					return false;
			}
			//Int16? dato = Read_servo(direccion, idServo);
			Int16? dato = ReadServoRTU(direccion, servoId);

			if (dato != null)
			{
				MessageBox.Show($"El valor en la dirección {direccion} de servo {idServo} es {dato}");
				return true;
			}
			else
			{
				MessageBox.Show($"No se leyó el valor correctamente");
				return false;
			}
		}

		public bool ComprobarConexionServo(string idServo)
		{

			uint servoId;
			switch (idServo)
			{
				case "X":
					servoId = 1;
					break;
				case "Y":
					servoId = 2;
					break;
				case "Z":
					servoId = 3;
					break;
				case "A":
					servoId = 4;
					break;
				default:
					MessageBox.Show($"Error: Dirección de servo desconocida o inexistente");
					return false;
			}
			//Int16? dato = Read_servo(direccion, idServo);
			bool correcto = WriteServoRTU(3,0,servoId);

			return correcto;
		}

		public static bool RetryUntilSuccess(Func<bool> operation)
		{
			bool result;
			do
			{
				result = operation();
			} while (!result);
			return result;
		}

		public void CerrarConexion()
		{
			try
			{
				servoport.Close();
				MessageBox.Show($"Puerto {servoport.PortName} cerrado correctamente", "Conexión 485", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
			}

		}


		private bool WriteServoASCII(Int16 direccion, Int16 datos, string servoId)
		{
			try
			{
				byte[] writeservo = { 0x3a, 0x30, 0x31, 0x30, 0x36, 0x30, 0x30, 0x30, 0x38, 0x30, 0x30, 0x31, 0x30, 0x45, 0x31, 13, 10 }; //A = 41h  F = 46h
				byte[] recived = { 0x3a, 0x30, 0x31, 0x30, 0x36, 0x30, 0x30, 0x30, 0x38, 0x30, 0x30, 0x31, 0x30, 0x45, 0x31, 13, 10 }; //A = 41h  F = 46h
				int suma = 6;
				char dato;
				string strdir = direccion.ToString("X4");
				string strdatos = datos.ToString("X4");

				switch (servoId)
				{
					case "1":
						writeservo[2] = 0x31;
						suma = 6;
						break;
					case "2":
						writeservo[2] = 0x32;
						suma = 7;
						break;
					case "3":
						writeservo[2] = 0x33;
						suma = 8;
						break;
					case "4":
						writeservo[2] = 0x34;
						suma = 9;
						break;
					default:
						MessageBox.Show($"Error: Dirección de servo desconocida o inexistente");
						return false;
				}

				suma = suma + ((direccion >> 8) & 0XFF) + (direccion & 0xFF) + ((datos >> 8) & 0XFF) + (datos & 0xFF);
				suma = (~suma) & 0xFF;

				for (int i = 0; i <= 3; i++)
				{
					dato = Convert.ToChar(strdir.Substring(i, 1));
					writeservo[i + 5] = Convert.ToByte(dato);
				}
				for (int i = 0; i <= 3; i++)
				{
					dato = Convert.ToChar(strdatos.Substring(i, 1));
					writeservo[i + 9] = Convert.ToByte(dato);
				}
				strdir = suma.ToString("X2");
				dato = Convert.ToChar(strdir.Substring(0, 1));
				writeservo[13] = Convert.ToByte(dato);
				dato = Convert.ToChar(strdir.Substring(1, 1));
				writeservo[14] = Convert.ToByte(dato);
				servoport.Write(writeservo, 0, 17);
				Thread.Sleep(100);
				servoport.Read(recived, 0, 17);
				if ((writeservo[9] == recived[9]) & (writeservo[10] == recived[10]) & (writeservo[11] == recived[11]) & (writeservo[12] == recived[12]))
					return true;
				else
					return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return false;

			}



		}

		private Int16 ReadServoASCII(Int16 direccion, string servoId)    //Int16
		{
			try
			{
				byte[] leerservo = { 0x3a, 0x30, 0x31, 0x30, 0x33, 0x30, 0x30, 0x30, 0x38, 0x30, 0x30, 0x30, 0x31, 0x46, 0x33, 13, 10 }; //A = 41h  F = 46h
				Int16 txdato = 0;
				int suma = 4;
				int i;
				char dato;
				string strdir = direccion.ToString("X4");

				switch (servoId)
				{
					case "1":
						leerservo[2] = 0x31;
						suma = 4;
						break;
					case "2":
						leerservo[2] = 0x32;
						suma = 5;
						break;
					case "3":
						leerservo[2] = 0x33;
						suma = 6;
						break;
					case "4":
						leerservo[2] = 0x34;
						suma = 7;
						break;
					default:
						MessageBox.Show($"Error: Dirección de servo desconocida o inexistente");
						return -1;
				}

				suma = suma + ((direccion >> 8) & 0XFF) + (direccion & 0xFF);
				suma = (~suma) & 0xFF;

				for (i = 0; i <= 3; i++)
				{
					dato = Convert.ToChar(strdir.Substring(i, 1));
					leerservo[i + 5] = Convert.ToByte(dato);
				}

				strdir = suma.ToString("X2");
				dato = Convert.ToChar(strdir.Substring(0, 1));
				leerservo[13] = Convert.ToByte(dato);
				dato = Convert.ToChar(strdir.Substring(1, 1));
				leerservo[14] = Convert.ToByte(dato);
				servoport.Write(leerservo, 0, 17);
				//Thread.Sleep(100);
				i = servoport.BytesToRead;
				servoport.DiscardInBuffer();

				byte[] respuestaServo = new byte[17];
				for (int j = 0; j < leerservo.Length; j++)
				{
					respuestaServo[j] = leerservo[j];

				}
				Thread.Sleep(500);
				servoport.Read(respuestaServo, 0, 17);

				if ((respuestaServo[6] & 0xf) == 2)
				{
					dato = Convert.ToChar(respuestaServo[7]);
					strdir = Convert.ToString(dato);
					dato = Convert.ToChar(respuestaServo[8]);
					strdir += Convert.ToString(dato);
					dato = Convert.ToChar(respuestaServo[9]);
					strdir += Convert.ToString(dato);
					dato = Convert.ToChar(respuestaServo[10]);
					strdir += Convert.ToString(dato);
					txdato = Convert.ToInt16(strdir, 16);
				}
				else
				{
					txdato = 0;
				}
				return txdato;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return -1;

			}


		}

		private static byte[] DividirValores(Int16 valor)
		{

			// Obtener el byte bajo (low byte)
			byte low = (byte)(valor & 0xFF);

			// Obtener el byte alto (high byte)
			byte high = (byte)((valor >> 8) & 0xFF);
			byte[] result = { high, low };
			return result;
		}

		/// <summary>
		/// Realiza la comunicación con un servoamplificador mediante el método RTU para la escritura de parametros en el servo.
		/// </summary>
		/// <param name="direccion">Short que representa la dirección del parametro a modificar en el servo.</param>
		/// <param name="dato">Short que representa el dato que se escribirá en el parametro seleccionado.</param>
		/// <param name="servoId">Short que representa el id de esclavo del servomotor en la red 485.</param>
		/// <returns><c>true</c> si el valor se escribe de forma correcta en el servomotor; <c>false</c> si hubo algún error</returns>
		private bool WriteServoRTU(Int16 direccion, Int16 dato, uint servoId)
		{
			try
			{
				byte servoHex = (byte)servoId;
				byte[] direccionHex = DividirValores(direccion); //Valor [0] = high && Valor [1] = low
				byte[] datoHex = DividirValores(dato); //Valor [0] = high && Valor [1] = low



				byte[] escribirSinCrc = { servoHex, 0x06, direccionHex[0], direccionHex[1], datoHex[0], datoHex[1] };

				uint crcResult = CrcChk(escribirSinCrc);
				uint crcLow = crcResult & 0xFF; //Low Byte
				uint crcHigh = (crcResult >> 8) & 0xFF; //HighByte

				byte[] escribirConCRC = { servoHex, 0x06, direccionHex[0], direccionHex[1], datoHex[0], datoHex[1], (byte)crcLow, (byte)crcHigh };
				
				servoport.Write(escribirConCRC, 0, 8);
				servoport.DiscardInBuffer();
				Thread.Sleep(100);
				servoport.Read(escribirConCRC, 0, 8);
				if ((escribirConCRC[4] == datoHex[0]) && (escribirConCRC[5] == datoHex[1]))
					return true;
				else
					return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return false;
			}


		}

		private Int16 ReadServoRTU(Int16 direccion, uint servoId)
		{
			try
			{
				byte[] direccionHex = DividirValores(direccion); //Valor [0] = high && Valor [1] = low
				byte[] leerSinCrc = { (byte)servoId, 0x03, direccionHex[0], direccionHex[1], 0x00, 0x01 };
				uint crcResult = CrcChk(leerSinCrc);
				uint crcLow = crcResult & 0xFF; //Low Byte
				uint crcHigh = (crcResult >> 8) & 0xFF; //HighByte

				byte[] leerConCrc = { (byte)servoId, 0x03, direccionHex[0], direccionHex[1], 0x00, 0x01, (byte)crcLow, (byte)crcHigh };
				servoport.Write(leerConCrc, 0, 8);
				servoport.DiscardInBuffer();
				Thread.Sleep(500);
				servoport.Read(leerConCrc, 0, 7);
				byte[] dato = { 0x00, 0x00 };
				if ((leerConCrc[2] & 0xf) == 2)
				{
					dato[0] = leerConCrc[3]; // Corresponde al valor high del dato 
					dato[1] = leerConCrc[4]; // Corresponde al valor low del dato

					Int16 combinedValue = (Int16)((dato[0] << 8) | dato[1]); // Combinar los bytes high y low en un solo valor de 16 bits
					return combinedValue;
				}
				else
				{
					return 0;
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return -1;
			}
		}

		private static ushort CrcChk(byte[] data)
		{
			ushort crcReg = 0xFFFF; // Paso 1: Iniciar el registro CRC con 0xFFFF

			for (int i = 0; i < data.Length; i++)
			{
				crcReg ^= data[i]; // Paso 2: XOR del byte de datos con el byte bajo del registro CRC

				for (int j = 0; j < 8; j++) // Paso 3: Procesar cada bit del byte
				{
					if ((crcReg & 0x0001) != 0) // Si el LSB es 1
					{
						crcReg = (ushort)((crcReg >> 1) ^ 0xA001); // Desplazar a la derecha y XOR con el polinomio 0xA001
					}
					else // Si el LSB es 0
					{
						crcReg >>= 1; // Solo desplazar a la derecha
					}
				}
			}

			return crcReg;
		}

		public static string[] GetAvailablePorts()
		{
			string[] puertosSeriales = SerialPort.GetPortNames();
			string[] puertosDisponibles = puertosSeriales;
			if (puertosDisponibles == null)
			{
				MessageBox.Show("No hay puertos disponibles verifique las conexiones y presione: \n\"Buscar puertos disponibles\"", "Error al traer puertos", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
			else
			{
				return puertosDisponibles;
			}


		}
	}
}
