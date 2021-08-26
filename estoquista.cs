using System;

public class Estoquista : Funcionario
{
  private int idSecao;

  public Estoquista(string nome, int id, string telefone, string dataNascimento, int idSecao)
  {
    this.nome = nome;
    this.id = id;
    this.telefone = telefone;
    this.dataNascimento = dataNascimento;
    this.idSecao = idSecao;
  }

  public void receberProduto(string id, string descricao)
  {
    Console.WriteLine("Produto com o id {0} e descrição {1} foi recebido!", id, descricao);
  }

}



 