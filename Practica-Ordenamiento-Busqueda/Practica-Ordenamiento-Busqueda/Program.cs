using System;

namespace Practica_Ordenamiento_Busqueda
{
  class Program
  {	
	static void Main(string[] args)
	{
	  Persona nPersona = new Persona();
	  string nombre;
	  int edad;
	  Console.WriteLine("Cuantos nombres desea ingresar?");	  
	  int tam = int.Parse(Console.ReadLine());	  
	  int[] ve = new int[tam];
	  string[] vn = new string[tam];
	  
	  for (int i=0; i<tam;i++)
	  {
		try
		{
		  Console.WriteLine("Ingresando " + (i + 1) + "º nombre");
		  nombre = Console.ReadLine();
		  vn[i] = nombre;
		  Console.WriteLine("Ingresando " + (i + 1) + "º edad");
		  edad = int.Parse(Console.ReadLine());
		  ve[i] = edad;
		}
		catch (Exception x)
		{
		  Console.WriteLine(x);
		}
		finally
		{
		  nPersona.vn = vn;
		  nPersona.vector = ve;
		}
	  }	  
	  nPersona.Menor(tam);	  
	  nPersona.Nombre(tam);	  
	  nPersona.Edad(tam);
	  Console.WriteLine("");
	  Console.WriteLine("Ordenamiento");	  
	  Random nRandom = new Random();	  
	  int[] vector = new int[10];
	  //Rellenado numeros random
	  for (int i = 0;i < 10;i++)
	  {
		vector[i] = nRandom.Next(0,9);
	  }
	  Burbuja(vector);
	}

	static void Burbuja(int[] vector)
	{
	  int aux = 0;
	  Console.WriteLine("Impresion del vector");
	  //Impresion vector
	  for (int i = 0;i < 10;i++)
	  {
		Console.Write(vector[i] + ";");
	  }
	  Console.WriteLine("");
	  //Metodo Burbuja
	  for (int i = 10 - 1;i > 0;i--)
	  {
		for (int j = 0;j < i;j++)
		{
		  if (vector[j] > vector[j + 1])
		  {
			aux = vector[j];
			vector[j] = vector[j + 1];
			vector[j + 1] = aux;
		  }
		}
	  }
	  //Vector Ordenado
	  Console.WriteLine("Vector Ordenado");
	  for (int i = 0;i < 10;i++)
	  {
		Console.Write(vector[i] + ";");
	  }
	}

  }
}
