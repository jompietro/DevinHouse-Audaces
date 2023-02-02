class Funcionario {
  constructor(cpf, nomeCompleto, salario) {
    if (!this.validarCPF(cpf)) {
      console.log('CPF inválido');
      return;
    }
    this.cpf = cpf;
    this.nomeCompleto = nomeCompleto;
    this.salario = salario;
  }

  validarCPF(cpf) {
    if (cpf.length !== 11) return false;
    for (let i = 0; i < 11; i++) {
      if (cpf[i] !== cpf[0]) return true;
    }
    return false;
  }

  promover(percentual) {
    this.salario += this.salario * (percentual / 100);
  }
}
