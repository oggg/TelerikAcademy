var arr = [2, 1, 1, 2, 3, 3, 3, 2, 2, 1];
var counter = 1;
var lastOccurance = 0;
var maxCounter = counter;

for (var i = 1; i < arr.length; i+=1) {
	if (arr[i] > arr[i - 1]) {
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

var result = arr.slice(lastOccurance - maxCounter + 1, lastOccurance + 1);
result = result.join(', ');
console.log('The longest sequence is: ' + result);