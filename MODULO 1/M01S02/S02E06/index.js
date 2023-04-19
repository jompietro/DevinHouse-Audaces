var operacao = prompt('Operação (+,-,*,/)');
var num1 = parseFloat(prompt('num 1'));
var num1 = parseFloat(prompt('num 2'));

switch (operacao) {
  case '+':
    alert(num1 + num2);
    break;
  case '-':
    alert(num1 - num2);
    break;
  case '*':
    alert(num1 * num2);
    break;
  case '/':
    alert(num1 / num2);
    break;
  default:
    alert('Operação Inválida');
}
