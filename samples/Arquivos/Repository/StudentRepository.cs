using Arquivos.Model;

namespace Arquivos.Repository;

public class StudentRepository
{
  private readonly string filepath = @"arquivos/students.csv";

  private Student ParseStudentFromLine(string line)
  {
    // line = "2,Anya,2.85,Salve Regina University"
    // line.split = ["2" , "Anya", "2.85", "Salve Regina University"]
    string[] studentData = line.Split(',');

    return new()
    {
      Id = int.Parse(studentData[0]),
      FirstName = studentData[1],
      Score = double.Parse(studentData[2]),
      University = studentData[3]
    };
  }

  public List<Student> FindAll()
  {
    List<Student> students = new();

    if (!File.Exists(filepath))
      return students;

    string[] lines = File.ReadAllLines(filepath);

    foreach (string line in lines)
    {
      students.Add(ParseStudentFromLine(line));
    }

    return students;
  }

  public Student? FindById(int id)
  {
    if (!File.Exists(filepath))
      return null;

    string[] lines = File.ReadAllLines(filepath);

    foreach (string line in lines)
    {
      Student currentStudent = ParseStudentFromLine(line);

      if(currentStudent.Id == id)
        return currentStudent;
    }

    return null;
  }

  // public bool Save(Student student) {

  // }
}
