using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_Ordenamiento_Busqueda
{
  class Persona
  {	
	public int[] vector = new int[0];
	public string[] vn = new string[0];

	public void Nombre(int n)
	{
	  n = n - 1;
	  for (int k = 0;k < n;k++)
	  {
		for (int f = 0;f < n - k;f++)
		{
		  if (vn[f].CompareTo(vn[f + 1]) > 0)
		  {
			string aux;
			int aux2 = 0;
			aux2 = vector[f];
			aux = vn[f];
			vn[f] = vn[f + 1];
			vn[f + 1] = aux;
			vector[f] = vector[f + 1];
			vector[f + 1] = aux2;
		  }
		}
	  }
	  //Arreglo ordenado por edad
	  Console.WriteLine("Vector Ordenado");
	  for (int i = 0;i < n+1;i++)
	  {
		Console.Write(i + " ");
		Console.Write(vn[i] + " ");
		Console.WriteLine(vector[i]);
	  }

	}

	public void Edad(int n)
	{
	  for (int i = n - 1;i > 0;i--)
	  {
		for (int j = 0;j < i;j++)
		{
		  if (vector[j] > vector[j + 1])
		  {
			string aux;
			int aux2 = 0;
			aux2 = vector[j];
			aux = vn[j];
			vn[j] = vn[j + 1];
			vn[j + 1] = aux;
			vector[j] = vector[j + 1];
			vector[j + 1] = aux2;
		  }
		}
	  }
	  //Arreglo ordenado por edad
	  Console.WriteLine("Vector Por edad");
	  for (int i = 0;i < n;i++)
	  {
		Console.Write(i + " ");
		Console.Write(vn[i] + " " );
		Console.WriteLine(vector[i]);
	  }
	}
	public void Menor(int n)
	{
	  int aux=0;
	  int menor=vector[0];
	  for (int i=0;i < n;i++)
	  {
		if (vector[i]< menor)
		{
		  menor = vector[i];
		  aux = i;
		}
	  }
	  Console.WriteLine("La persona con menor edad es");
	  Console.WriteLine(vn[aux] + " " + menor);
	}
  }
}
