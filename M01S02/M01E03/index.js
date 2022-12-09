function getTable(getNumber) {
  let table = [];
  for (var i = 0; i < 11; i++) {
    table.push(`${getNumber} x ${i} = ${getNumber * i}`);
  }
  return table;
}

function getNumber() {
  let setNumber = Number(prompt(`Insert a number`));
  if (isNaN(setNumber) || !isFinite(setNumber)) {
    alert(`Please, insert a correct number`);
    getNumber();
  } else {
    let table = getTable(setNumber);
    alert(table.join(`\n`));
  }
}

getNumber();
