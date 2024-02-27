using System.Globalization;

DateOnly date = new DateOnly(2024, 2, 26);

DateTime momento = DateTime.Now;

Console.WriteLine(date);
Console.WriteLine(momento.ToString("dd/MM/yyyy HH:mm"));

Console.WriteLine(momento.ToUniversalTime());

try {
  DateTime entrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

  Console.WriteLine(entrada);

  TimeSpan duracao = entrada.Subtract(DateTime.Now);

  Console.WriteLine(duracao.Hours);
  Console.WriteLine(duracao.TotalHours);

} catch(FormatException formatException) {
  Console.WriteLine(formatException.Message);
}
