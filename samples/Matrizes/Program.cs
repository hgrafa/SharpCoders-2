namespace Matrizes;

public class Program
{

  public static void ImprimeMatrizTransposta(int[,] matriz)
  {
    int totalLinhas = matriz.GetLength(0); // 1 dimensao = numero de linhas
    int totalColunas = matriz.GetLength(1); // 2 dimensao = numero de colunas

    for (int lin = 0; lin < totalLinhas; lin++)
    {
      for (int col = 0; col < totalColunas; col++)
      {
        Console.Write($"{matriz[col, lin]} ");
      }

      Console.WriteLine();
    }
  }

  public static void ImprimeMatriz(int[,] matriz)
  {
    int totalLinhas = matriz.GetLength(0); // 1 dimensao = numero de linhas
    int totalColunas = matriz.GetLength(1); // 2 dimensao = numero de colunas

    // n x n => n * n operacoes => n^2
    for (int lin = 0; lin < totalLinhas; lin++)
    {
      for (int col = 0; col < totalColunas; col++)
      {
        Console.Write($"{matriz[lin, col]} ");
      }

      Console.WriteLine();
    }
  }

  public static void ImprimeDiagonalPrincipal(int[,] matriz)
  {
    int totalLinhas = matriz.GetLength(0);
    int totalColunas = matriz.GetLength(1);

    if(totalLinhas != totalColunas) {
      Console.WriteLine("A matriz deve ser quadrada");
      return;
    }

    Console.Write("Diagonal Principal: ");
    for (int i = 0; i < totalLinhas; i++)
    {
      Console.Write($"{matriz[i, i]},  ");
    }

    Console.WriteLine();
  }

  public static void Main(string[] args)
  {

    int[,] matriz = { {1, 2, 3},
                      {4, 5, 6},
                      {7, 8, 9},
                      {1, 0, 2} };

    int[,] matrizQuadrada = { {1, 2, 3},
                              {4, 5, 6},
                              {7, 8, 9} };

    // [2, 1]
    Console.WriteLine(matriz[2, 1]);

    ImprimeMatriz(matrizQuadrada);
    ImprimeDiagonalPrincipal(matrizQuadrada);

    // para debugar
    // for(int lin = 0; lin < 3; lin++) {
    //   for(int col = 0; col < 3; col++) {
    //     Console.Write($"[{lin}, {col}] ");
    //   }
    //   Console.WriteLine();
    // }


    // transposta = troca linha e coluna
    // ImprimeMatriz(matriz);


  }
}
