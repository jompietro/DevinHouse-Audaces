class Funcionario {
  constructor(cpf, nome, salario) {
    this.cpf = cpf;
    this.nome = nome;
    this.salario = salario;
  }

  promover(percentual) {
    //this.salario = this.salario * (percentual / 100 + 1);
    this.salario *= percentual / 100 + 1;
  }
}

export default Funcionario;
