using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CON = CNC3Cont485.Form1;

namespace CNC3Cont485
{
	public class InOut
	{
		private bool WriteServoRTU(Int16 direccion, Int16 dato, uint servoId)
		{
			try
			{
				byte servoHex = (byte)servoId;
				



				byte[] escribir = { servoHex, 0x06, 0x00, 0x00, 0x00, 0x00 };

				CON.conexion.servoport.Write(escribir, 0, 8);
				CON.conexion.servoport.DiscardInBuffer();
				Thread.Sleep(100);
				CON.conexion.servoport.Read(escribir, 0, 8);
				//if ((escribir[4] == datoHex[0]) && (escribirConCRC[5] == datoHex[1]))
				return true;
				//else
				//	return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return false;
			}


		}
		public static bool ExecIO(string comando)
		{

			return true;
		}
	}
}
