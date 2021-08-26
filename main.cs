using System;

class Program {
  public static void Main (string[] args) {
    Produto produto1 = new Produto(5, "higiene", "Papel Higiênico", "20/02/2050", "123456");

    Produto produto2 = new Produto(10, "higiene", "Algodão", "01/03/2051", "156458");

    Produto[] produtos = new Produto[2];  
    produtos[0] = produto1;  
    produtos[1] = produto2;

    int qtdeProdutos = produto1.listarProdutos(produtos);
    Console.WriteLine(qtdeProdutos);

    Entregador entregador = new Entregador("Marcos Silva", 25462, "2795646595", "02/08/1991", "MPF2321");

    entregador.realizarEntrega(produto1.getDescricao());
    entregador.buscarMaterial(produto2.getDescricao());
    entregador.recolherAssinaturaNf();

    Estoquista estoquista = new Estoquista("Marcos Silva", 25462, "2795646595", "02/08/1991", 10);

    estoquista.receberProduto(produto1.getId(), produto2.getDescricao());
  }
}