import { Cachorro, Gato } from './Animal.js';

console.log('m1-s05-e04');

const snoopy = new Cachorro('snoopy', 10);

console.log(snoopy.som); // "latido"

const frajola = new Gato('frajola', 8);

console.log(frajola.som); // "miado"
