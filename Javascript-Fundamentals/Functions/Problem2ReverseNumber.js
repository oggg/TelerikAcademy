function processingReverse (number) {

	var reversed = '';

	while (number > 0) {
		reversed += (number % 10).toString();
		number = (number / 10) | 0;
	}

	return +reversed;
}


function reverseNumber (theDigit) {

	var arr;
	var reversed;

	if (+theDigit) {

		var asInt = theDigit - (theDigit | 0) === 0;

		if (asInt) {
		reversed = processingReverse(theDigit);
		}

		else {
			arr = theDigit.toString().split('.');
			for (var num in arr) {
				arr[num] = processingReverse(arr[num]);
			}
			var temp;
			temp = arr[0];
			arr[0] = arr[1];
			arr[1] = temp;
			reversed = +arr.join('.');
		}
		console.log(reversed);
	}

	else {processingReverse(theDigit);
		console.log('Try wit a number next time');
	}
}

reverseNumber(23.0);