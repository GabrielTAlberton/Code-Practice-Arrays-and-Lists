using System.Collections.ObjectModel;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        // Arrays(ou listas) seguem este modelo de instancia:
        //tipo-variavel[] nome-da-array = new tipo-variavel[tamanho fixo da array]
        int[] minhaArray = new int[4];
        int[] minhaArray2 = new int[]{42, 75, 74, 21};
        string[] Meses = {"Jan", "Fev"};

        Console.WriteLine(Meses[0]); // vai printar "Jan"
        Console.WriteLine(minhaArray2[2]); // vai printar "74"
        

        // Para iterar sobre cada item da lista, podemos utilizar for loop, com o contador como indexador:

        for (int contador = 0; contador < minhaArray2.Length; contador++)
        {
            Console.WriteLine($"Posicao nº{contador}: {minhaArray2[contador]}");
        }

        // Ou podemos utilizar o for each:

        foreach (int valor in minhaArray2)
        {
            Console.WriteLine(valor);
        }

        string[] MeuNome = {"G", "A", "B", "R", "I", "E", "L"};
        foreach (string letra in MeuNome)
        {
            Console.WriteLine(letra);
        }

        string FullName = "";
        foreach (string letra in MeuNome)
        {
            FullName += letra;
        }
        Console.WriteLine(FullName);

        // Como podemos aumentar o tamanho de uma array? Já que temos que passar uma capacidade máxima quando instanciamos ele:
        int[] Numeros = new int[3];
        Numeros[0] = 1;
        Numeros[1] = 2;
        Numeros[2] = 3;
        Array.Resize (ref Numeros, 4);


        // Redimensionar o array para o tamanho 5
        Array.Resize(ref Numeros, 5);
        Console.WriteLine("Array redimensionado:");
        foreach (var num in Numeros)
        {
            Console.WriteLine(num);
        }

        // Inicializar os novos elementos
        Numeros[3] = 40;
        Numeros[4] = 50;
        Console.WriteLine("Array após inicializar novos elementos:");
        foreach (var num in Numeros)
        {
            Console.WriteLine(num);
        }

        List<string> estadosDoBrasil = new List<string>();

        estadosDoBrasil.Add("SP");
        estadosDoBrasil.Add("BA");
        estadosDoBrasil.Add("MG");

        foreach (string estadosDoBrasilItem in estadosDoBrasil)
        {
            Console.WriteLine(estadosDoBrasilItem);
        }




    }
}