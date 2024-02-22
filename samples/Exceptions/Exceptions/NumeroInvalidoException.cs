namespace Exceptions.Exceptions;

public class NumeroInvalidoException : Exception
{
  public NumeroInvalidoException() : base()
  {
    
  }
  
   public NumeroInvalidoException(string msg) : base(msg) {

   }
}
