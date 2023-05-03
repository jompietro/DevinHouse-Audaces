Crie uma classe "Banco" que tenha um atributo "saldo" (privado) e métodos públicos "Depositar" e "Sacar", cada um que recebem um parâmetro double e atualizam o atributo "saldo" com o valor depositado ou sacado. Adicione um método "ToString" que exibe o valor atual do saldo.
Crie uma classe "ContaBancaria" com atributos "numero" (privado) e "cliente" (privado) do tipo "Cliente", que deve ser criado como uma classe separada com os atributos "nome" (privado) e "cpf" (privado). Adicionamos um método construtor que recebe o número da conta e o cliente como parâmetros e inicializa os atributos correspondentes. Adicionamos um método público "ExibirDados" que exibe o número da conta, o nome do cliente e o cpf do cliente. Também adicionamos métodos "Depositar" e "Sacar", que redirecionam as operações para o objeto da classe "Banco". Por fim, adicionamos um método "ToString" que retorna uma string formatada com o número da conta, o nome do cliente, o cpf do cliente e o saldo da conta.
Em seguida, criamos uma classe "Cliente" com atributos "nome" (privado) e "cpf" (privado). Adicionamos um método construtor que recebe o nome e o cpf como parâmetros e inicializa os atributos correspondentes. Adicionamos também um método "ToString" que retorna uma string formatada com o nome e o cpf do cliente.
‌

No programa principal, criamos um objeto "Cliente" e um objeto "ContaBancaria" e exibimos os dados da conta. Em seguida, realizamos um depósito, um saque e exibimos novamente os dados da conta.

O resultado final do programa deve ser:

Dados da conta:

Conta: 1234

Nome: João Silva, CPF: 123.456.789-00

Depósito de R$1000.00

Conta: 1234, Nome: João Silva, CPF: 123.456.789-00, Saldo: 1000

Saque de R$500.00

Conta: 1234, Nome: João Silva, CPF: 123.456.789-00, Saldo: 500