function parsingFLOAT(userInput) {
	if (!isNaN(userInput) && userInput !== "") {
		var result = parseFloat(userInput);
	}
	else {
		result = null;
	}
	return result;
}

function parsingINT(userInput) {
	if (!isNaN(userInput) && userInput !== "") {
		var result = parseFloat(userInput);
	}
	else {
		result = null;
	}
	return result;
}
 //-------------------------------------------------------------

function problem1() {
	var input = document.getElementById("problem1").value;
	var output = '';

	if (parsingINT(input) !== null) {
		input = parseInt(input);
		for (var i = 0; i < input; i += 1) {
			output += i.toString() + ' ';
		}
	document.getElementById("p1result").innerHTML = output;
	}
	else {
		document.getElementById("p1result").innerHTML = 'Try with a number next time!';
	}
}

// ---------------------------------------------------------------

function problem2() {
	var input = document.getElementById("problem2").value;
	var output = '';
	input = parseInt(input);
	if (parsingINT(input) !== null) {
		for (var i = 1; i < input; i++) {
			var byThree = i % 3;
			var bySeven = i % 7;
			if ((byThree !== 0) || (bySeven !== 0)) {
				output += i.toString() + ' ';
			}
		}
		document.getElementById("p2result").innerHTML = output;
	}
	else {
		document.getElementById("p2result").innerHTML = 'Try with a number next time!';
	}
}

// ---------------------------------------------------------------



function problem3() {
	var input = document.getElementById("problem3").value;
	var arr = input.split(',');
	var min;
	var max;

	for (var i = 0; i < arr.length; i++) {
		if (parsingINT(arr[i]) !== null) {
			arr[i] = parseInt(arr[i]);
		}	
		else {
			document.getElementById("p3result").innerHTML = 'Input fields require number as input';
			break;
			return;
		}
	}
	min = arr[0];
	max = arr[0];
	for (var i = 0; i < arr.length; i++) {
		if (arr[i] < min) {
			min = arr[i];
		}
		if (arr[i] > max) {
			max = arr[i];
		}
	}
	
	document.getElementById("p3result").innerHTML = 'min: ' + min + ', max: ' + max;
}

// ---------------------------------------------------------------

function problem4() {
	var min = "domain";
	var max = "domain";		
	var attribute;
	
	for (attribute in document) {
		if (min > attribute) {
			min = attribute;
		}
		if (max < attribute) {
			max = attribute;
		}
	}

	for (attribute in window) {
		if (min > attribute) {
			min = attribute;
		}
		if (max < attribute) {
			max = attribute;
		}	
	}

	for (attribute in navigator) {
		if (min > attribute) {
			min = attribute;
		}
		if (max < attribute) {
			max = attribute;
		}	
	}

	document.getElementById("p4result").innerHTML = 'min: ' + min + ', max: ' + max;
}