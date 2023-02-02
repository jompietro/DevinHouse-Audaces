//exercicio 2

export default class Fatura {
  id;
  descricao;
  quantia;
  preco;

  constructor(id, descricao, quantia, preco) {
    this.id = id;
    this.descricao = descricao;
    this.quantia = quantia;
    this.preco = preco;
  }
  obterValorTotal() {
    return this.quantia * this.preco;
  }
  get ValorTotal() {
    return this.obterValorTotal();
  }
}
