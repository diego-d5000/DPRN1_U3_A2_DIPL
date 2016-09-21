using System;
using System.Globalization;

namespace Actividad2U3
{
	class estudiante
	{
		public string ObtenerNombreCompleto(string nombre, string apellidos)
		{
			string nombreCompleto = string.Empty;
			nombreCompleto = nombre + " " + apellidos;
			return nombreCompleto;
		}

		public void CalcularEdad(DateTime fechaNacimiento)
		{
			int edadEstudiante = DateTime.Now.Year - fechaNacimiento.Year;
			int edadCalculada = DateTime.Now < fechaNacimiento.AddYears(edadEstudiante) ? edadEstudiante - 1 : edadEstudiante;
			Console.WriteLine("La edad del estudiante es: " + edadCalculada + " años");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			estudiante alumno = new estudiante();
			string nombre;
			string apellidos;
			DateTime fechaNac;

			Console.WriteLine("Capture el nombre del alumno: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Capture los apellidos del alumno: ");
			apellidos = Console.ReadLine();

			Console.WriteLine(alumno.ObtenerNombreCompleto(nombre, apellidos));

			Console.WriteLine("Indique la fecha de nacimiento (dd/mm/aaaa) :");
			fechaNac = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("es-MX"));

			alumno.CalcularEdad(fechaNac);
			Console.ReadKey();
		}
	}

}