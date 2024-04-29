using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
namespace lingua
{
	public class Test
	{
		// Cadena de conexión a la base de datos
		string connectionString = "Data Source=LEONIDAS-MV\\SQLEXPRESS;Initial Catalog=lingua;Integrated Security=True";

		// Ruta del archivo SQL
		string scriptFilePath = @"C:\Ruta\del\archivo\script.sql";

		public Test()
		{
			// Cadena de conexión a la base de datos

			try
			{
				// Leer el contenido del archivo SQL
				//string script = File.ReadAllText(scriptFilePath);

				// Establecer la conexión a la base de datos
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					// Abrir la conexión
					connection.Open();

					// Ejecutar el script SQL
					SqlCommand command = new SqlCommand("SELECT * FROM [user]", connection);
					command.ExecuteNonQuery();

					Console.WriteLine("Script ejecutado correctamente.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error al ejecutar el script SQL: " + ex.Message);
			}

			Console.ReadLine();
		}
	}
}
