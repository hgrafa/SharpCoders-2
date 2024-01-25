namespace IntroPOO.Model;

public class Song
{
  // atributos
   public string? nome;
   public int duracaoEmMinutos;
   public string? artista;
   private int _anoDeLancamento;
   public string DataDeCriacao { get; private set; } // autoproperty

  // construtor this (pronome pocessivo)= desse
  // this = referencia ao objeto que chamou ou a propria classe
  // this = resolver ambiguidade
  public Song(string nome, int duracaoEmMinutos, string artista, int anoDeLancamento, string dataDeCriacao) {
    this.nome = nome;
    this.duracaoEmMinutos = duracaoEmMinutos;
    this.artista = artista;
    _anoDeLancamento = anoDeLancamento;
    DataDeCriacao = dataDeCriacao;
  }

  // metodos

  // setter => isola a logica de alterar a variavel
  public void SetAnoDeLancamento(int anoDeLancamento) {
    if(anoDeLancamento <= 0)
      return;

    _anoDeLancamento = anoDeLancamento;
  }

  // getter => isola a logica de acessar a variavel
  // public string GetDataDeCriacao() {
  //   return _dataDeCriacao;
  // }

  public int GetAnoDeLancamento() {
    return _anoDeLancamento;
  }
}
