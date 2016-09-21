using System;

namespace Actividad2U3
{
	class estudiante
	{
		public string ObtenerNombreCompleto(string nombre, string apellidos)
		{
			string nombreCompleto = string.Empty;
			nombreCompleto = nombre + " " + aspellidos;
		}

		public void CalcularEdad(DateTime fechaNacimiento)
		{
			int edadEstudiante = DateTime.Now.Year - fechaNacimiento.Year;
			int edadCalculada = DateTime.Now < fechaNacimiento.AddYears(edadEstudiante) ? edadEstudiante - 1 : edadEstudiante;
			Console.WriteLine("La edad del estudiante es: " + edad + " años");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			estudiante alumno = new estudiante();
			string nombre;
			double apellidos;
			DateTime fechaNac;

			Console.WriteLine("Capture el nombre del alumno: ");
			nombre = Console.ReadLine();
			Console.WriteLine("Capture los apellidos del alumno: ");
			apellidos = Console.ReadLine();

			Console.WriteLine(alumno.ObtenerNombreCompleto());

			Console.WriteLine("Indique la fecha de nacimiento (dd/mm/aaaa) :");
			fechaNac = Convert.ToDouble(Console.ReadLine());

			CalcularEdad(fechaNac);
			Console.ReadKey();
		}
	}

}

