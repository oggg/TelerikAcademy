(function () {
	
function generatePerson(fname, lname, age) {
	return {
		firstname : fname,
		lastname : lname,
		age : age,
	};
}


function group(array, property) {
	var grouped = [];
	var i;
	for (i in array) {
		if (!grouped[array[i][property]]) {
			grouped[array[i][property]] = [];
		}
		grouped[array[i][property]].push(array[i]);
	}
	return grouped;
}
		

var gosho2 = generatePerson('Gosho', 'Ivanov', 15);
var stamat = generatePerson('Stamat', 'Peshev', 55);
var gosho1 = generatePerson('Gosho', 'Petrov', 32);
var pesho = generatePerson('Pesho', 'Peshev', 15);


var peopleArr = [pesho, gosho1, stamat, gosho2];

var groupedByAge = group(peopleArr, 'lastname');
console.log(groupedByAge);

}

)();
