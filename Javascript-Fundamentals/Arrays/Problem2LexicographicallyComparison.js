var firstArr = ['b', 'k', 'p', 't'];
var secondArr = ['b', 'k', 'z', 't'];
var result;

if (firstArr.length === secondArr.length) {
	for (var i = 0; i < firstArr.length; i++) {
		if (firstArr[i] > secondArr[i]) {
			result = 1;
			break;
		}
		else if (firstArr[i] < secondArr[i]) {
			result = -1;
			break;
		}
		else {
			result = 0;
			
		}
 }
	switch (result) {
		case -1: console.log('The first array is before the second'); break;
		case 0: console.log('Arrays are equal'); break;
		case 1: console.log('The first array is after the second'); break;
	}
}
else {
	console.log('Arrays are of different length');
}

	
