using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CON = CNC3Cont485.Form1;

namespace CNC3Cont485
{
	public static class InOut
	{
		public static bool WritePIC(Int16 inOutID, bool estado)
		{
			try
			{
				byte estadoHex = (byte)(estado ? 0x01 : 0x00);
				byte servoHex = 0x50;
				byte[] escribir = [servoHex, 0x04, 0x00, (byte)inOutID, estadoHex, 0x00, 0xFF, 0xFF];


				CON.conexionArd.servoport.Write(escribir, 0, 8);
				CON.conexionArd.servoport.DiscardInBuffer();
				Thread.Sleep(100);
				CON.conexionArd.servoport.Read(escribir, 0, 8);
				if ((escribir[3] == (byte)inOutID) && (escribir[4] == estadoHex) && (escribir[6] == 0x4F) && (escribir[7] == 0x4B))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return false;
			}


		}
		public static bool ReadPIC(Int16 inOutID)
		{
			try
			{
				bool estado = false;
				byte servoHex = 0x50;
				byte[] leer = [servoHex, 0x07, 0x00, (byte)inOutID, 0x00, 0x00, 0xFF, 0xFF];

				CON.conexionArd.servoport.Write(leer, 0, 8);
				CON.conexionArd.servoport.DiscardInBuffer();
				Thread.Sleep(100);
				CON.conexionArd.servoport.Read(leer, 0, 8);
				if ((leer[3] == (byte)inOutID) && (leer[6] == 0x4F) && (leer[7] == 0x4B))
				{
					estado = Convert.ToBoolean(leer[5]);
					return estado;
				}
				else
				{
					throw new Exception("Problema de comunicación: Respuesta de PIC incorrecta");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}");
				return false;
			}


		}
	}
}
