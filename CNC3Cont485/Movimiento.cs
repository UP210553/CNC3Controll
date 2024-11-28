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
		public short IdSalida { get; set; }
		public short IdEntrada { get; set; }
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
            if (Entrada != "" && Entrada != null)
            {
				
				MessageBox.Show("Esperando entrada");
            }
			if (Salida != "" && Salida != null)
			{
				bool estado = SacarIdDeSalida(Salida);
				InOut.WritePIC(IdSalida, estado);
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
			else if (Tipo == "Doblado" && X > 0 && X < 200 )
			{
				double pulsosX = X * 1388.8889;
				double pulsosY = Y * 1000;
				EjecutarDoblado(pulsosX, pulsosY, velocidad);

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
		private static void EjecutarDoblado(double pulsosX, double pulsosY, int velocidad)
		{
			Con485 con = new();
			int highPosX = 0;
			int lowPosX = 0;
			int highPosY = 0;
			int lowPosY = 0;
			short[] velocidades = CalcularVelocidadInterpolado(pulsosX, pulsosY, (short)velocidad);

			if (pulsosX > 9999)
			{
				highPosX = (int)Math.Floor(pulsosX / 10000);
				lowPosX = (int)Math.Floor(pulsosX % 10000);
			}
			else
			{
				lowPosX = (int)Math.Floor(pulsosX);
			}

			if (pulsosY > 9999)
			{
				highPosY = (int)Math.Floor(pulsosY / 10000);
				lowPosY = (int)Math.Floor(pulsosY % 10000);
			}
			else
			{
				lowPosY = (int)Math.Floor(pulsosY);
			}
			string servo = "X";
			int posH = 0;
			int posL = 0;
            for (int i = 0; i < 2; i++)
            {
				if (i == 0)
				{
					con = Form1.conexion;
					servo = "X";
					posH = highPosX;
					posL = lowPosX;
				}
				else 
				{
					con = Form1.conexion2;
					servo = "Y";
					posH = highPosY;
					posL = lowPosY;
				}
      
				Con485.RetryUntilSuccess(() => con.EscribirServo($"{120}", $"{posH}", servo));
				Con485.RetryUntilSuccess(() => con.EscribirServo($"{121}", $"{posL}", servo));
				Con485.RetryUntilSuccess(() => con.EscribirServo($"{128}", $"{velocidades[i]}", servo));
				Con485.RetryUntilSuccess(() => con.EscribirServo("117", "0", servo));
				Con485.RetryUntilSuccess(() => con.EscribirServo("118", "0", servo));
				Con485.RetryUntilSuccess(() => con.EscribirServo("69", "3840", servo));
				Con485.RetryUntilSuccess(() => con.EscribirServo("117", "1", servo));
				Con485.RetryUntilSuccess(() => con.EscribirServo("71", "2047", servo));
			}
			Thread.Sleep(500);
			Barrier barrier = new Barrier(2); // 2 hilos
			Task hilo1 = Task.Run(() =>
			{
				// Realiza alguna operación de preparación
				//Console.WriteLine("Preparando hilo 1");
				barrier.SignalAndWait();  // Espera hasta que el otro hilo llegue
				Con485.RetryUntilSuccess(() => Form1.conexion.ArrancarMovServo("X")); // Ahora comienza el movimiento del servo
			});

			Task hilo2 = Task.Run(() =>
			{
				// Realiza alguna operación de preparación
				//Console.WriteLine("Preparando hilo 2");
				barrier.SignalAndWait();  // Espera hasta que el otro hilo llegue
				Con485.RetryUntilSuccess(() => Form1.conexion2.ArrancarMovServo("Y")); // Ahora comienza el movimiento del servo
			});

			Task.WaitAll(hilo1, hilo2);
		}
		private void SacarIdDeEntrada(string entrada)
		{

			IdEntrada = 2;
		}
		private bool SacarIdDeSalida(string salida)
		{
			switch (salida)
			{
				case "Clamp ON":
					IdSalida = 1;
					return true;

				case "Clamp OFF":
					IdSalida = 1;
					return false;

				case "Chuck ON":
					IdSalida = 2;
					return true;

				case "Chuck OFF":
					IdSalida = 2;
					return false;

				default:
					return false;
			}
		}
		private static short[] CalcularVelocidadInterpolado(double pos1, double pos2, short velocidad)
		{
			short[] velocidades = new short[2];
			pos1 = Math.Abs(pos1);
			pos2 = Math.Abs(pos2);
			if (pos1 > pos2)
			{
				velocidades[0] = velocidad;
				velocidades[1] = (short)(velocidad * (pos2 / pos1));
			}
			else if (pos1 < pos2)
			{
				velocidades[0] = (short)(velocidad * (pos1 / pos2));
				velocidades[1] = velocidad;
			}
			else
			{
				velocidades[0] = velocidad;
				velocidades[1] = velocidad;
			}
			return velocidades;

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
