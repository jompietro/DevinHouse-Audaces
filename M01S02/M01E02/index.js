// Utilizando estrutura condicional exiba a descrição da classificação da idade da pessoa de acordo com os dados abaixo:

// Jovens - Indivíduos de até 15 anos;
// Adultos - Indivíduos com idade entre 16 até 64 anos;
// Idosos - Indivíduos de 65 anos em diante.

// Utilize prompt para solicitar a idade e alert para exibir a classificação.

// Realize o commit do exercício resolvido.

var idade = parseInt(prompt('Digite a idade'));

if (idade >= 0 && idade <= 15) {
  alert('jovem');
} else if (idade >= 15 && idade <= 64) {
  alert('Adulto');
} else if (idade >= 65) {
  alert('Idoso');
}
