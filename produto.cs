using System;

public class Produto {
  private int qtdproduto;
  private string categoriaProduto;
  private string descricao;
  private string validade;
  private string id;

  public Produto(int qtdproduto, string categoriaProduto, string descricao, string validade, string id)
  {
      this.qtdproduto = qtdproduto;
      this.categoriaProduto = categoriaProduto;
      this.descricao = descricao;
      this.validade = validade;
      this.id = id;
  }

  public string getId()
  {
    return this.id;
  }

  public string getDescricao()
  {
    return this.descricao;
  }

  public int listarProdutos(Produto[] produtos){
    int count = 0;
    foreach (Produto i in produtos)
    {
      count++;
    }
    return count;
  }

}