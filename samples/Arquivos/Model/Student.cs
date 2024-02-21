namespace Arquivos.Model;

public class Student
{
   public int Id { get; set; }
   public string FirstName { get; set; }   
   public double Score { get; set; }
   public string University { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, FirstName: {FirstName}, Score:{Score}, University: {University}";
    }
}
