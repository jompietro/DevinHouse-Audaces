console.log('e03-s03-m1');

// Resolução:
/*
function concatena(arrayA, arrayB) {
  return [...arrayA, ...arrayB];
};
*/

const concatena = (arrayA, arrayB) => [...arrayA, ...arrayB];

const novoArray = concatena([1, 2, 3], [4, 5, 6]);

console.log(novoArray);
// novo array deve ser [1, 2, 3, 4, 5, 6]
