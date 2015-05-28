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
	var finalOutput;
	var forTheNumbers = input % 10;
	var forTheTenths = ((input / 10) | 0) % 10;
	var forTheHundreds = (input / 100) | 0;
	var digits = digitHundreds(forTheNumbers);
	var tenth;
	var hundred = digitHundreds(forTheHundreds) + ' hundred';
	var and = ' and ';


	if (forTheTenths === 1) {
		tenth = teens(input % 100);
	}
	else {
		tenth = tenths(forTheTenths);
	}

	function digitHundreds(number) {
		
		var result;

		switch (number) {
			case 0: result = "zero"; break;
			case 1: result = "one"; break;
			case 2: result = "two"; break;
			case 3: result = "three"; break;
			case 4: result = "four"; break;
			case 5: result = "five"; break;
			case 6: result = "six"; break;
			case 7: result = "seven"; break;
			case 8: result = "eight"; break;
			case 9: result = "nine"; break;
			default: ""; break;
		}

		return result;
	}

	function tenths(number) {
		
		var result;

		switch (number) {
			case 2: result = "twenty"; break;
			case 3: result = "thirty"; break;
			case 4: result = "fourty"; break;
			case 5: result = "fifty"; break;
			case 6: result = "sixty"; break;
			case 7: result = "seventy"; break;
			case 8: result = "eighty"; break;
			case 9: result = "ninety"; break;
			default: ""; break;
		}

		return result;
	}

	function teens(number) {

		var result;

		switch (number) {
			case 10: result = "ten"; break;
			case 11: result = "eleven"; break;
			case 12: result = "twelve"; break;
			case 13: result = "thirteen"; break;
			case 14: result = "fourteen"; break;
			case 15: result = "fifteen"; break;
			case 16: result = "sixteen"; break;
			case 17: result = "seventeen"; break;
			case 18: result = "eighteen"; break;
			case 19: result = "nineteen"; break;
			default: ""; break;
		}

		return result;
	}

	function capitalize(output) {
		return output.charAt(0).toUpperCase() + output.slice(1);
	}


	if (input < 10) { finalOutput = capitalize(digits); }

	if (input >= 10 && input < 20) { finalOutput = capitalize(tenth); }

	if (input >= 20 && input <= 99) {
		if (!forTheNumbers) {
			finalOutput = capitalize(tenth);
		}
		else {
			finalOutput = capitalize(tenth) + ' ' + digits;
		}
	}

	if (input > 99) {
		if (input % 100 === 0) {
			finalOutput = capitalize(hundred);
		}
		else if (forTheNumbers && forTheTenths === 0) {
			finalOutput = capitalize(hundred) + and + digits;
		}

		else if (forTheTenths === 1) {
			finalOutput = capitalize(hundred) + and + tenth;
		}
		else if (forTheTenths > 1) {
			if (forTheNumbers !== 0) {
			finalOutput = capitalize(hundred) + and + tenth + ' ' + digits;
			}
			else {
				finalOutput = capitalize(hundred) + and + tenth;
			}
		}
	}
	
	document.getElementById("p8result").innerHTML = finalOutput;
}