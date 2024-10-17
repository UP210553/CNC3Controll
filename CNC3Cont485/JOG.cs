using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNC3Cont485
{
	static class JOG
	{

		public static void JogXPlus(string velocidadJog)
		{
            try
			{
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("120", "1", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("121", "0", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("128", velocidadJog, "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("117", "0", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("118", "0", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("69", "3840", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("117", "1", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("71", "2047", "X"));
				Thread.Sleep(150);
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("71", "3071", "X"));
			}
			catch (Exception)
			{

			}
			
		}
		public static void JogXMinus(string velocidadJog)
		{
			try
			{
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("120", "-1", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("121", "-500", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("128", velocidadJog, "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("117", "0", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("118", "0", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("69", "3840", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("117", "1", "X"));
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("71", "2047", "X"));
				Thread.Sleep(150);
				Conexion485.RetryUntilSuccess(() => Form1.conexion.EscribirServo("71", "3071", "X"));
			}
			catch (Exception)
			{

			}

		}
	}
}
