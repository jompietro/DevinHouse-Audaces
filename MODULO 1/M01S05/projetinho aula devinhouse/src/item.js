export default class Item {
  static #lastId = 0;
  #id;
  label;

  constructor(label) {
    this.#id = ++Item.#lastId;
    this.label = label;
  }

  get id() {
    return this.#id;
  }
}
