namespace Arquivos.Model;

public class Student
{
   public int Id { get; set; }
   public string FirstName { get; set; }   
   public double Score { get; set; }
   public string University { get; set; }

   public Student() {
   }

   public static Student FromCsv(string csvLine) {
      string[] studentData = csvLine.Split(',');

      return new Student() {
        Id = int.Parse(studentData[0]),
        FirstName = studentData[1],
        Score = double.Parse(studentData[2]),
        University = studentData[3]
      };
   }

   public string ToCsv() {
    return $"{Id},{FirstName},{Score},{University}";
   }

    public override string ToString()
    {
        return $"Id: {Id}, FirstName: {FirstName}, Score:{Score}, University: {University}";
    }
}
