console.log('e07-s03-m1');

// Resolução:

const ada = {
  nome: 'Ada',
  idade: 36,
  profissao: 'matemática',
};

/*
function montaMensagem(pessoa) {
  const { nome, idade, profissao } = pessoa;
  return `Esta é ${nome}, tem ${idade} anos e é ${profissao}.`;
}
*/

/*
function montaMensagem({ nome, idade, profissao }) {
  return `Esta é ${nome}, tem ${idade} anos e é ${profissao}.`;
}
*/

const montaMensagem = ({ nome, idade, profissao }) => `Esta é ${nome}, tem ${idade} anos e é ${profissao}.`;

const mensagem = montaMensagem(ada);

console.log(mensagem);
