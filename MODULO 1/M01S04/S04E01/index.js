//Criar variar lista de contas
let contas = [
  {
    nome: 'Thais Bertoldo',
    cpf: '999.999.999.99',
    celular: '(99) 99999-9999',
    senha: '12',
    conta: 1,
    saldo: 0,
  },
];

// Obter o formulario para adicionar evento
const formulario = document.getElementById('form-cadastro');

// Criar funçao para ser executada no envio do formulario
const enviarFormulario = (event) => {
  event.preventDefault();
  const password = event.target.password.value;
  const confirmPassword = event.target.confirmPassword.value;

  if (password !== confirmPassword) {
    alert('Senhas não conferem');
    return;
  }

  const nome = event.target.name.value;
  const cpf = event.target.cpf.value;
  const celular = event.target.phone.value;
  const conta = new Date().getTime();
  const saldo = 0;

  const contaCriada = {
    conta,
    nome,
    cpf,
    celular,
    password,
    saldo,
  };

  contas.push(contaCriada);
  alert(`Conta Criada com sucesso. Número: ${conta}`);
};

formulario.addEventListener('submit', enviarFormulario);

//operacoes
//obter formular de operacoes
const formOperacao = document.getElementById('form-operacao');

// Funcao de saque
const sacar = (conta, valor) => {
  if (valor > 0) {
    if (conta.saldo >= valor) {
      const novoSaldo = conta.saldo - valor;
      conta.saldo = novoSaldo;

      alert(`Saque efetuado com sucesso! Novo saldo: ${novoSaldo}`);
      return;
    }

    alert('Saldo insuficiente');
    return;
  }

  alert('Não foi possível efetuar o saque.');
};
// Funcao de deposito
const depositar = (conta, valor) => {
  if (valor > 0) {
    const novoSaldo = conta.saldo + valor;
    conta.saldo = novoSaldo;

    alert(`Deposito efetuado! Novo Saldo: ${novoSaldo}`);
    return;
  }

  alert('Não foi possivel efetuar o deposito.');
};

// Funcao de consulta saldo
const consultarSaldo = (conta) => {
  alert(`Saldo atual: ${conta.saldo}`);
};

//Enviar formulario de operacao
const enviarFormularioOperacao = (event) => {
  event.preventDefault();

  //obter valores digitadaos no formulario
  const conta = parseInt(event.target.conta.value);
  const operacao = event.target.operacao.value;
  const valor = event.target.valor.value;
  const senha = event.target.senhaOperacao.value;

  //validar conta e senha
  const contaAtual = contas.find((c) => c.conta === conta);

  //valida se a senha existe
  if (!contaAtual) {
    alert('Conta Invalida');
    return;
  }

  //Valida se a senha esta correta
  if (contaAtual.senha !== senha) {
    alert('Senha Invalida');
    return;
  }

  // chamar a função correta de acordo com a operacao
  switch (operacao) {
    case 'saque':
      sacar(contaAtual.valor);
      break;
    case 'deposito':
      depositar(contaAtual, valor);
      break;
    case 'saldo':
      consultarSaldo(contaAtual);
      break;
    default:
      alert('Operacao invalida');
      break;
  }
};

formOperacao.addEventListener('submit', enviarFormularioOperacao);

// Desabilitar/Habilitar campo de valor

// Obter select para adicionar evento de onchange
const operacao = document.getElementById('operacao');
operacao.addEventListener('change', (event) => {
  //Obter o campo de valor do html
  const inputValor = document.getElementById('valor');

  // Verifica se o valor selecionado é saldo
  if (event.target.value === 'saldo') {
    // Desabilitar o campo
    inputValor.disabled = true;
    // Limpa o valor digitado
    inputValor.value = '';
    return;
  }

  // Habilita o campo quando a operação for diferente de saldo
  inputValor.disabled = false;
});
