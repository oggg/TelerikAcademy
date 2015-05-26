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
	var a = document.getElementById("problem1a").value;
	var b = document.getElementById("problem1b").value;
	var output = a + " " + b;

	if (parsingFLOAT(a) !== null && parsingFLOAT(b) !== null) {
		if (a > b) {
			output = b + " " + a;
		}
	
	document.getElementById("p1result").innerHTML = output;
	}
	else {
		document.getElementById("p1result").innerHTML = 'Try with a number next time!';
	}
}

// ---------------------------------------------------------------

function problem2() {
	var a = document.getElementById("problem2a").value;
	var b = document.getElementById("problem2b").value;
	var c = document.getElementById("problem2c").value;
	var output;

	if (parsingFLOAT(a) !== null && parsingFLOAT(b) !== null && parsingFLOAT(c) !== null) {
		if (a * b * c > 0) {
			output = '+';
		}
		if (a * b * c < 0) {
			output = '-';
		}
		if (a * b * c == 0) {
			output = 0;
		}
	document.getElementById("p2result").innerHTML = output;
	}
	else {
		document.getElementById("p2result").innerHTML = 'Try with a number next time!';
	}
}

// ---------------------------------------------------------------



function problem3() {
	var a = document.getElementById("problem3a").value;
	var b = document.getElementById("problem3b").value;
	var c = document.getElementById("problem3c").value;
	var biggest = 0;
	
	if (parsingFLOAT(a) !== null && parsingFLOAT(b) !== null && parsingFLOAT(c) !== null) {
		
		if (a > b && a > c) {
			biggest = a;
		}
		if (b > a && b > c) {
			biggest = b;
		}
		if (c > a && c > b) {
			biggest = c;
		}

		document.getElementById("p3result").innerHTML = biggest;
		}
	else {
		document.getElementById("p3result").innerHTML = 'Input fields require number as input';
	}
}

// ---------------------------------------------------------------

function problem4() {
	var a = document.getElementById("problem4a").value;
	var b = document.getElementById("problem4b").value;
	var c = document.getElementById("problem4c").value;
	var biggest;
	
	if (parsingFLOAT(a) !== null && parsingFLOAT(b) !== null && parsingFLOAT(c) !== null) {
		
		if (a == b == c) {
			biggest = a + ' ' + b + ' ' + c;
		}

		if (a > b && a > c) {
			if (b > c) {
				biggest = a + ' ' + b + ' ' + c;
			}
			else {
				biggest = a + ' ' + c + ' ' + b;
			}
		}

		if (b > a && b > c) {
			if (a > c) {
				biggest = b + ' ' + a + ' ' + c;
			}
			else {
				biggest = b + ' ' + c + ' ' + a;
			}
		}

		if (c > a && c > b) {
			if (a > b) {
					biggest = c + ' ' + a + ' ' + b;
			}
			else {
				biggest = c + ' ' + b + ' ' + a;
			}
		}

		document.getElementById("p4result").innerHTML = biggest;
		}
	else {
		document.getElementById("p4result").innerHTML = 'Input fields require number as input';
	}
}
// ---------------------------------------------------------------

function problem5() {
	var input = document.getElementById("problem5").value;
	var output;
	if (parsingFLOAT(input) !== null) {
		input = parsingFLOAT(input);
		switch(input) {
			case 0: output = "zero"; break;
			case 1: output = "one"; break;
			case 2: output = "two"; break;
			case 3: output = "three"; break;
			case 4: output = "four"; break;
			case 5: output = "five"; break;
			case 6: output = "six"; break;
			case 7: output = "seven"; break;
			case 8: output = "eight"; break;
			case 9: output = "nine"; break;
			default: output = "not a digit";
		}
		
		
		document.getElementById("p5result").innerHTML = output;
	}
	else {
		document.getElementById("p5result").innerHTML = 'not a digit';
	}
}

// ---------------------------------------------------------------



function problem6() {
	var a = document.getElementById("problem6a").value;
	var b = document.getElementById("problem6b").value;
	var c = document.getElementById("problem6c").value;

	var D;
	var x1;
	var x2;
	var output;

	if (parsingFLOAT(a) !== null && parsingFLOAT(b) !== null && parsingFLOAT(c) !== null) {
		D = (b * b) - (4 * a *c);
		
		if (D > 0) {
			x1 = (-b - Math.sqrt(D)) / (2 * a);
			x2 = (-b + Math.sqrt(D)) / (2 * a);
			output = 'x1: ' + x1 + ', x2: ' + x2;
 		}
		else if (D === 0) {
			x1 = x2 = -b / (2 * a);
			output = 'x1 = x2 = ' + x1;
		}
		else {
			output = 'no real roots';
		}

		document.getElementById("p6result").innerHTML = output;

		}
	else {
		document.getElementById("p6result").innerHTML = 'Input fields require number as input';
	}
}

// ---------------------------------------------------------------

function problem7() {
	var input1 = document.getElementById("problem71").value;
	var input2 = document.getElementById("problem72").value;
	var input3 = document.getElementById("problem73").value;
	var input4 = document.getElementById("problem74").value;
	var input5 = document.getElementById("problem75").value;
	var max;
	if (parsingFLOAT(input1) !== null && parsingFLOAT(input2) !== null && parsingFLOAT(input3) !== null
		&& parsingFLOAT(input4) !== null && parsingFLOAT(input5) !== null) {
		input1 = parseFloat(input1);
		input2 = parseFloat(input2);
		input3 = parseFloat(input3);
		input4 = parseFloat(input4);
		input5 = parseFloat(input5);
		max = input1;
		if (input2 > max) {
			max = input2;
		}
		if (input3 > max) {
			max = input3;
		}
		if (input4 > max) {
			max = input4;
		}
		if (input5 > max) {
			max = input5;
		}
			document.getElementById("p7result").innerHTML = max;
		}
		else {
			document.getElementById("p7result").innerHTML = 'Input fields require number as input';
		}
}

// ---------------------------------------------------------------

function problem8() {
	var input = document.getElementById("problem8").value;
	var hundreds;
	var tenths;
	var numbers;
	var output;

	if (input < 20) {
		switch (input) {
			case 0: numbers = 'Zero'; break;
			case 1: numbers = 'One'; break;
			case 2: numbers = 'Two'; break;
			case 3: numbers = 'Three'; break;
			case 4: numbers = 'Four'; break;
			case 5: numbers = 'Five'; break;
			case 6: numbers = 'Six'; break;
			case 7: numbers = 'Seven'; break;
			case 8: numbers = 'Eight'; break;
			case 9: numbers = 'Nine'; break;
			case 10: numbers = 'Ten'; break;
			case 11: numbers = 'Eleven'; break;
			case 12: numbers = 'Twelve'; break;
			case 13: numbers = 'Thirteen'; break;
			case 14: numbers = 'Fourteen'; break;
			case 15: numbers = 'Fifteen'; break;
			case 16: numbers = 'Sixteen'; break;
			case 17: numbers = 'Seventeen'; break;
			case 18: numbers = 'Eighteen'; break;
			case 19: numbers = 'Nineteen'; break;
		}
		output = numbers;
	}

	if (input > 19 && input < 100) {
		switch ((input / 10) | 0) {
			case 2: tenths = 'Twenty'; break;
			case 3: tenths = 'Thirty'; break;
			case 4: tenths = 'Foutry'; break;
			case 5: tenths = 'Fifty'; break;
			case 6: tenths = 'Sixty'; break;
			case 7: tenths = 'Seventy'; break;
			case 8: tenths = 'Eighty'; break;
			case 9: tenths = 'Ninety'; break;
		}

		if (input % 10 !== 0) {
		
		input %= 10;

		switch (input % 10) {
			case 1: numbers = 'one'; break;
			case 2: numbers = 'two'; break;
			case 3: numbers = 'three'; break;
			case 4: numbers = 'four'; break;
			case 5: numbers = 'five'; break;
			case 6: numbers = 'six'; break;
			case 7: numbers = 'seven'; break;
			case 8: numbers = 'eight'; break;
			case 9: numbers = 'nine'; break;
		}
		output = tenths + ' ' + numbers;
		}
		else {
			output = tenths;
		}
	}

	if (input >= 100) {
		switch ((input / 100) | 0) {
			case 1: hundreds = 'One hundred'; break;
			case 2: hundreds = 'Two hundred'; break;
			case 3: hundreds = 'Three hundred'; break;
			case 4: hundreds = 'Four hundred'; break;
			case 5: hundreds = 'Five hundred'; break;
			case 6: hundreds = 'Six hundred'; break;
			case 7: hundreds = 'Seven hundred'; break;
			case 8: hundreds = 'Eight hundred'; break;
			case 9: hundreds = 'Nine hundred'; break;
		}

	if (input % 100 !== 0) {

		switch (((input / 10) | 0) % 10 ) {
			case 2: tenths = 'twenty'; break;
			case 3: tenths = 'thirty'; break;
			case 4: tenths = 'foutry'; break;
			case 5: tenths = 'fifty'; break;
			case 6: tenths = 'sixty'; break;
			case 7: tenths = 'seventy'; break;
			case 8: tenths = 'eighty'; break;
			case 9: tenths = 'ninety'; break;
		}

		if (input % 100 > 19) {
			input = (input % 100) % 10;
		}
		else {
			input %= 100;
		}

		switch (input) {			
			case 1: numbers = 'one'; break;
			case 2: numbers = 'two'; break;
			case 3: numbers = 'three'; break;
			case 4: numbers = 'four'; break;
			case 5: numbers = 'five'; break;
			case 6: numbers = 'six'; break;
			case 7: numbers = 'seven'; break;
			case 8: numbers = 'eight'; break;
			case 9: numbers = 'nine'; break;
			case 10: numbers = 'ten'; break;
			case 11: numbers = 'eleven'; break;
			case 12: numbers = 'twelve'; break;
			case 13: numbers = 'thirteen'; break;
			case 14: numbers = 'fourteen'; break;
			case 15: numbers = 'fifteen'; break;
			case 16: numbers = 'sixteen'; break;
			case 17: numbers = 'seventeen'; break;
			case 18: numbers = 'eighteen'; break;
			case 19: numbers = 'nineteen'; break;
		}
		if (tenths === undefined) {
			output = hundreds + ' and ' + numbers;	
		}
		else {
		output = hundreds + ' and ' + tenths + ' ' + numbers;
		}
	}
	else {
		output = hundreds;
	}	
	}
	document.getElementById("p8result").innerHTML = output;
}
