console.log('e04-s03-m1');

// Resolução:
/*
function mesclaObjetos(objA, objB) {
  return {...objA, ...objB};
};
*/

// para retornar objetos é necessário utilizar parentesis
const mesclaObjetos = (objA, objB) => ({ ...objA, ...objB });

const objUm = { a: 1, b: 2 };
const objDois = { c: 3, d: 4 };

const novoObjeto = mesclaObjetos(objUm, objDois);

console.log(novoObjeto);
// { a: 1, b: 2, c: 3, d: 4 }
