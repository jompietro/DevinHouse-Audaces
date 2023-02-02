console.log('aula3');

class Retangulo {
  base;
  #altura;

  constructor(b, a) {
    this.base = b;
    this.#altura = a;
  }

  calculaArea() {
    return this.base * this.#altura;
  }

  get altura() {
    return this.#altura;
  }

  set altura(novoValor) {
    this.#altura - novoValor;
  }
}

const quad = new Retangulo(4, 111111);
//quad.altura = 44444;
quad.definirAltura = 77777777777;
console.log(quad.altura);
console.log(quad.blah);

//console.log(quad);
console.log(quad.calculaArea());

// EXEMPLO de Getter em Objeto Comum
const objetoComum = {
  valorInterno: 42,
  get valor() {
    return this.valorInterno;
  },
  set valor(novoValor) {
    this.valorInterno = novoValor;
  },
};
//console.log(objetoComum.valorInterno);
//console.log(objetoComum.valor);

//-------------------------------------------
//exercicio 2
import Fatura from './fatura.js';

const melao = new Fatura(123, 'Melão', 2, 3);

const valor = melao.obterValorTotal();

console.log(valor); // 6
//-------------------------------------------
