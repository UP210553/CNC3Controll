using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNC3Cont485
{
	public class Movimiento
	{
		public string Tipo { get; set; }
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }
		public double A { get; set; }
		public int Espera { get; set; }
		public int RPM { get; set; }
		public int IdSalida { get; set; }
		public int IdEntrada { get; set; }
		public string Salida { get; set; }
		public string Entrada { get; set; }

		public Movimiento(string tipo, double x, double y, double z, double a, int espera, int rpm, string salida, string entrada)
		{
			Tipo = tipo;
			X = x;
			Y = y;
			Z = z;
			A = a;
			Espera = espera;
			RPM = rpm;
			Salida = salida;
			Entrada = entrada;
		}
		public static double CalcularYParaDoblado(double variableArrastre, double x)
		{
			double result = x * variableArrastre;
			result = Math.Round(result, 3);
			return result;
		}
	}
}
