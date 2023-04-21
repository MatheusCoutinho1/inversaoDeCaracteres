using System;

class Program
{
    static void Main(string[] args)
    {
        string texto = "Exemplo de texto para inverter";

        char[] caracteres = texto.ToCharArray();
        int tamanho = caracteres.Length;

        for (int i = 0; i < tamanho / 2; i++)
        {
            char temp = caracteres[i];
            caracteres[i] = caracteres[tamanho - i - 1];
            caracteres[tamanho - i - 1] = temp;
        }

        texto = new string(caracteres);

        Console.WriteLine(texto);
    }
}
