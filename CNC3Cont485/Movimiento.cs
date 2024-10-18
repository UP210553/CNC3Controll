using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Con485 = CNC3Cont485.Conexion485;

namespace CNC3Cont485
{
	public class Movimiento(string tipo, double x, double y, double z, int espera, int rpm, string salida, string entrada)
	{
		public string Tipo { get; set; } = tipo;
		public double X { get; set; } = x;
		public double Y { get; set; } = y;
		public double Z { get; set; } = z;
		//public double A { get; set; } = a;
		public int Espera { get; set; } = espera;
		public int RPM { get; set; } = rpm;
		public int IdSalida { get; set; }
		public int IdEntrada { get; set; }
		public string Salida { get; set; } = salida;
		public string Entrada { get; set; } = entrada;

		public static double CalcularYParaDoblado(double variableArrastre, double x)
		{
			double result = x * variableArrastre;
			result = Math.Round(result, 3);
			return result;
		}
		public bool EjecutarMovimiento()
		{
			bool result = false;
			int velocidad = (RPM > 0) ? RPM : 200;

			if (Espera > 0)
			{
				Thread.Sleep(Espera);
			}
			if (Tipo == "Incremental")
			{
				if (!double.IsNaN(X))
				{
					double pulsos = X * 1388.8889;
					MoverServoIncremental(pulsos, velocidad, "X");
				}
				if (!double.IsNaN(Y)) 
				{
					double pulsos = Y * 1000;
					MoverServoIncremental(pulsos, velocidad, "Y");
				}
				if (!double.IsNaN(Z)) 
				{
					double pulsos = Z * 588.2353;
					MoverServoIncremental(pulsos, velocidad, "Z");
				} 
			}
			else if (Tipo == "Absoluto")
			{

			}
			else if (Tipo == "Doblado")
			{


			}
			else
			{

			}
			return result;
		}
		private static void MoverServoIncremental(double posicion, int velocidad, string servo)
		{
			Con485 con = new();
			int highPos = 0;
			int lowPos = 0;
			if (posicion > 9999)
            {
				highPos = (int)Math.Floor(posicion/10000);
				lowPos = (int)Math.Floor(posicion % 10000);
			}
            else
            {
				lowPos = (int)Math.Floor(posicion);
            }
			if (servo == "Y")
			{
				con = Form1.conexion2;
			}
			else
			{
				con = Form1.conexion;
			}

			Con485.RetryUntilSuccess(() => con.EscribirServo($"{120}", $"{highPos}", servo));
			Con485.RetryUntilSuccess(() => con.EscribirServo($"{121}", $"{lowPos}", servo));
			Con485.RetryUntilSuccess(() => con.EscribirServo($"{128}", $"{velocidad}", servo));
			Con485.RetryUntilSuccess(() => con.EscribirServo("117", "0", servo));
			Con485.RetryUntilSuccess(() => con.EscribirServo("118", "0", servo));
			Con485.RetryUntilSuccess(() => con.EscribirServo("69", "3840", servo));
			Con485.RetryUntilSuccess(() => con.EscribirServo("117", "1", servo));
			Con485.RetryUntilSuccess(() => con.EscribirServo("71", "2047", servo));
			Thread.Sleep(150);
			Con485.RetryUntilSuccess(() => con.EscribirServo("71", "3071", servo));

		}

		private static void RealizarDoblado()
		{

		}
		private static int ConvertirDecimalAEntero(double pos, int highVal)
		{
			double decimalPart = pos - highVal;  // Parte decimal

			// Convertir la parte decimal a string para contar las cifras
			string decimalString = decimalPart.ToString("0.####"); // Hasta 4 cifras decimales
			var lowValStr = decimalString.Split('.')[1];
			int lowVal = 0;
			if (lowValStr.Length == 1)
			{
				lowVal = Convert.ToInt32(lowValStr) * 1000;
			}
			else if (lowValStr.Length == 2)
			{
				lowVal = Convert.ToInt32(lowValStr) * 100;
			}
			else if (lowValStr.Length == 3)
			{
				lowVal = Convert.ToInt32(lowValStr) * 10;
			}
			return lowVal;
		}


	}
}
