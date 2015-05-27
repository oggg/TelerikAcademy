var arr = [4, 1, 1, 4, 1, 3, 4, 4, 1, 2, 4, 9, 3];
var counter = 1;
var maxCounter = counter;

function compareFunction(a, b) {
	return a - b;
}

arr.sort(compareFunction);

for (var i = 1; i < arr.length; i+=1) {
	if (arr[i] === arr[i - 1]) {
		counter+= 1;
		if (counter > maxCounter) {
			maxCounter = counter;
			lastOccurance = i;
		}
	}
	else {
		counter = 1;
	}
}

console.log('The number ' + arr[lastOccurance] + ' appears ' + maxCounter + ' times.');