var arr = [1, 2, 3, 5, 8, 9, 6, 4, 3, 2, 2];

function searchDigit(arr, digit) {

	var counter = 0;
	if (Array.isArray(arr) && +digit) {
		for (var i = 0; i < arr.length; i++) {
			if (arr[i] === digit) {
				counter += 1;
			}
		}
		console.log(counter);
	}
	else {
		console.log('You should use array and number to search for');
	}
}

searchDigit(arr, 9);

function test(arr) {
	for (var i = 0; i < 10; i++) {
		searchDigit(arr, i);	
	}
}

test(arr);