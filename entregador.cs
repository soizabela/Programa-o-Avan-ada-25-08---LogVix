using System;

public class Entregador : Funcionario {
  private string placa;

  public Entregador(string nome, int id, string telefone, string dataNascimento, string placa)
  {
    this.nome = nome;
    this.id = id;
    this.telefone = telefone;
    this.dataNascimento = dataNascimento;
    this.placa = placa;
  }

  public void realizarEntrega(string descricao)
  {
    Console.WriteLine ("Produto {0} entregue!", descricao);
  }
  public void buscarMaterial(string descricao)
  {
    Console.WriteLine ("Produto {0} em mãos!", descricao);
  }
  public void recolherAssinaturaNf()
  {
    Console.WriteLine ("NF Assinada!");
  }
}