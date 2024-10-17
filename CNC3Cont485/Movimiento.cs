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
				if (!double.IsNaN(X)) MoverServoIncremental(X, velocidad, "X");
				if (!double.IsNaN(Y)) MoverServoIncremental(Y, velocidad, "Y");
				if (!double.IsNaN(Z)) MoverServoIncremental(Z, velocidad, "Z");
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
			int highPos = (int)Math.Floor(posicion);
			int lowPos = (highPos == posicion) ? 0 : ConvertirDecimalAEntero(posicion, highPos);
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo($"{120}", $"{highPos}", servo));
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo($"{121}", $"{lowPos}", servo));
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo($"{128}", $"{velocidad}", servo));

			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("117", "0", servo));
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("118", "0", servo));
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("69", "3840", servo));
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("117", "1", servo));
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("71", "2047", servo));
			Thread.Sleep(150);
			Con485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("71", "3071", servo));

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
