using Arquivos.Model;

namespace Arquivos.Repository;

public class StudentRepository
{
  private readonly string filepath = @"arquivos/students.csv";

  public List<Student> FindAll()
  {
    List<Student> students = new();

    if (!File.Exists(filepath))
      return students;

    string[] lines = File.ReadAllLines(filepath);

    foreach (string line in lines)
    {
      students.Add(Student.FromCsv(line));
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
      Student currentStudent = Student.FromCsv(line);

      if (currentStudent.Id == id)
        return currentStudent;
    }

    return null;
  }

  public bool Save(Student student)
  {

    if (!File.Exists(filepath))
      return false;

    using StreamWriter writer = File.AppendText(filepath);
    writer.WriteLine(student.ToCsv());
    return true;
  }
}
