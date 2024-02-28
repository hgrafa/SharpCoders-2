using Delivery.Domain.Model;

namespace Delivery.Infra.Repository;

public class ProductRepository : IRepository<Product>
{

  private readonly string _databasePath = @"db/products.csv";

  private Product _parseProduct(string line)
  {
    string[] productsData = line.Split(';');

    return new Product()
    {
      Id = int.Parse(productsData[0]),
      Name = productsData[1],
      Price = double.Parse(productsData[2]),
      Description = productsData[3]
    };
  }

  private string _productToCsv(Product product)
  {
    return $"{product.Id};{product.Name};{product.Price};{product.Description}";
  }

  public List<Product> GetAll()
  {
    List<Product> products = new();

    try
    {
      string[] lines = File.ReadAllLines(_databasePath);

      for (int lineNumber = 1; lineNumber < lines.Length; lineNumber++)
      {
        string line = lines[lineNumber];
        products.Add(_parseProduct(line));
      }

    }
    catch (FileNotFoundException)
    {
      File.Create(_databasePath);
      using StreamWriter productsWriter = File.AppendText(_databasePath);
      productsWriter.WriteLine("id,name,price,description");
    }

    return products;
  }

  public Product? GetById(int id)
  {
    List<Product> products = GetAll();
    Product? productSearch = products.Find(product => product.Id == id);

    return productSearch;
  }

  public void Save(Product product)
  {
    string productCsv = _productToCsv(product);

    if (!File.Exists(_databasePath))
    {
      File.Create(_databasePath);
      using StreamWriter productsWriter = File.AppendText(_databasePath);
      productsWriter.WriteLine("id,name,price,description");
    }

    using StreamWriter productWriter = File.AppendText(_databasePath);
    productWriter.WriteLine(productCsv);
  }

}

