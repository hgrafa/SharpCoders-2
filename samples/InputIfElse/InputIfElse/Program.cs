namespace InputIfElse;

public class Program
{
    public static void Main()
    {
        
        string nome = Console.ReadLine();
        int idade = int.Parse(Console.ReadLine());
        double nota = double.Parse(Console.ReadLine());

        // if braceless - sem as chaves
        // so vale se tiver apenas uma linha dentro
        if(idade >= 18) 
            Console.WriteLine("Pode dirigir");
        else 
            Console.WriteLine("Nao pode dirigir");
        
        // >= 7 aprovado
        // >= 4 e < 7 recuperacao
        // < 4 reprovado

        if(nota >= 7)
            Console.WriteLine("Aprovado");
        else if(nota >= 4)
            Console.WriteLine("Recuperacao");
        else
            Console.WriteLine("Reprovado");
        

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {nota}");
    }
}