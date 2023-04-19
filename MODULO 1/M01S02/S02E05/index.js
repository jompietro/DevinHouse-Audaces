var numero = parseInt(prompt('Digite um número'));

if (isNaN(numero)) {
  alert('Número Inválido');
} else {
  var pares = 0;
  var impares = 0;
  for (var i = 0; i <= numero; i++) {
    if (i % 2 === 0) {
      pares += 1;
    } else {
      impares += 1;
    }
  }

  alert('Existem ' + pares + ' números pares e ' + impares + ' números impares');
}
