function createPerson(fname, lname, age) {
	return {
		fname: fname,
		lname: lname,
		age: age,
		toString: function() {
			return this.fname + ' ' + this.lname;
		}
	};
}


var gosho = createPerson('Gosho', 'Petrov', 32);
var bay = createPerson('Bay', 'Ivan', 81);
var pesho = createPerson('Pesho', 'Peshev', 15);
var peopleArr = [gosho, bay, pesho];

function compare(a, b) {
	return a.age - b.age;
}

peopleArr.sort(compare);

console.log(peopleArr[0].toString());