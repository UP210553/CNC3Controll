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

		public static void JogXPlus(Conexion485 con, string velocidadJog)
		{
            try
			{
				con.RetryUntilSuccess(() => con.EscribirServo("120", "1", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("121", "500", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("128", velocidadJog, "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("117", "0", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("118", "0", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("69", "3840", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("117", "1", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("71", "2047", "1"));
				Thread.Sleep(150);
				con.RetryUntilSuccess(() => con.EscribirServo("71", "3071", "1"));
			}
			catch (Exception)
			{

			}
			
		}
		public static void JogXMinus(Conexion485 con, string velocidadJog)
		{
			try
			{
				con.RetryUntilSuccess(() => con.EscribirServo("120", "-1", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("121", "-500", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("128", velocidadJog, "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("117", "0", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("118", "0", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("69", "3840", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("117", "1", "1"));
				con.RetryUntilSuccess(() => con.EscribirServo("71", "2047", "1"));
				Thread.Sleep(150);
				con.RetryUntilSuccess(() => con.EscribirServo("71", "3071", "1"));
			}
			catch (Exception)
			{

			}

		}
	}
}
