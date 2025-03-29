using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{

	public abstract class Figura //clase ads
	{
		public abstract double CalcularArea();
		public abstract double CalcularPerimetro();
		public abstract void MostrarInformacion();
	}

	
	public class Circulo : Figura // clase y herencia que es figura
	{
		public double Radio { get; set; }// encapsulacion

		public Circulo(double radio)
		{
			Radio = radio;
		}

		public override double CalcularArea()// encapsulacion
		{
			return Math.PI * Radio * Radio;
		}

		public override double CalcularPerimetro()// encapsulacion
		{
			return 2 * Math.PI * Radio;
		}

		public override void MostrarInformacion() // polimorfismo
		{
			Console.WriteLine($"Círculo - Radio: {Radio}, Área: {CalcularArea()}, Perímetro: {CalcularPerimetro()}");
		}
	}

	
	public class Rectangulo : Figura // clse y herencia que es figura
	{
		public double Base { get; set; } // encapsulacion
		public double Altura { get; set; } // encapsulacion

		public Rectangulo(double baseRect, double altura) 
		{
			Base = baseRect;
			Altura = altura;
		}

		public override double CalcularArea()// encapsulacion
		{
			return Base * Altura;
		}

		public override double CalcularPerimetro()// encapsulacion
		{
			return 2 * (Base + Altura);
		}

		public override void MostrarInformacion() // polimorfismo
		{
			Console.WriteLine($"Rectángulo - Base: {Base}, Altura: {Altura}, Área: {CalcularArea()}, Perímetro: {CalcularPerimetro()}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Figura> figuras = new List<Figura>();

			figuras.Add(new Circulo(5));
			figuras.Add(new Rectangulo(4, 6));

			foreach (var figura in figuras)
			{
				figura.MostrarInformacion();
			}

			Console.ReadKey();
		}
	}
}

