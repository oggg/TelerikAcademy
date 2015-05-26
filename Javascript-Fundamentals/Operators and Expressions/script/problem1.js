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
	var odd = true;

	if (!isNaN(input) && input !== "") {
		var parsing = parseInt(input);
		if (parsing % 2 == 0) {
			odd = false;
		}
		
		document.getElementById("p1result").innerHTML = odd;
	}
	else {
		document.getElementById("p1result").innerHTML = 'Try with a number next time!';
	}
}

// ---------------------------------------------------------------

function problem2() {
	var input = document.getElementById("problem2").value;
	var divisible = false;
	
	if (!isNaN(input) && input !== "") {
		var parsing = parseInt(input);
		if (parsing % 7 == 0 && parsing % 5 == 0) {
			divisible = true;
		}
		
		document.getElementById("p2result").innerHTML = divisible;
	}
	else {
		document.getElementById("p2result").innerHTML = 'Try with a number next time!';
	}
}

// ---------------------------------------------------------------



function problem3() {
	var width = document.getElementById("problem3width").value;
	var height = document.getElementById("problem3height").value;
	var output = 0;
	
	if ((parsingFLOAT(width) != null) && parsingFLOAT(height) != null){
		output = width * height;
		document.getElementById("p3result").innerHTML = output;
		}
	else {
		document.getElementById("p3result").innerHTML = 'Input vields require number as input';
	}
}

// ---------------------------------------------------------------

function problem4() {
	var input = document.getElementById("problem4").value;
	var output = false;
	
	if (parsingINT(input) != null) {
		input = (input / 100) % 10 | 0;
		if (input == 7) {
			output = true;
		}
		document.getElementById("p4result").innerHTML = output;
		}
	else {
		document.getElementById("p4result").innerHTML = 'Input vields require number as input';
	}
}

// ---------------------------------------------------------------

function problem5() {
	var input = document.getElementById("problem5").value;
	var arr = [];
	var output = 0;
	
	if (parsingINT(input) != null) {
		arr = Number(input).toString(2).split('');
		if (arr.length > 3) {
			output = arr[arr.length - 4];
		}
		
		document.getElementById("p5result").innerHTML = output;
	}
	else {
		document.getElementById("p5result").innerHTML = 'Input vields require number as input';
	}
}

// ---------------------------------------------------------------

function coordinates(x, y) {
	return  {
		x: x,
		y: y
	};
}



function problem6() {
	var x = document.getElementById("problem6X").value;
	var y = document.getElementById("problem6Y").value;
	
	var circleCentre = coordinates(0, 0);
	var circleRadius = 5;
	var output = false;
	
	if ((parsingFLOAT(x) != null) && parsingFLOAT(y) != null){
		
		var point = coordinates(x, y);
		var d = (point.x - circleCentre.x) * (point.x - circleCentre.x) + (point.y - circleCentre.y) * (point.y - circleCentre.y);
		if (d <= circleRadius * circleRadius) {
			output = true;
		};

		document.getElementById("p6result").innerHTML = output;
		}
	else {
		document.getElementById("p6result").innerHTML = 'Input vields require number as input';
	}
}

// ---------------------------------------------------------------

function problem7() {
	var input = document.getElementById("problem7").value;
	var output = true;
	
	if (parsingINT(input) != null) {
		if (input >= 0) {
		if (input == 1 || input == 0) {
			output = false;
		}
		else {
			for (var i = 2; i <= Math.sqrt(input); i+=1) {
				if (input % i == 0) {
					output = false;
				};
			};
		};
		}
		else {
			output = false;
		}

		document.getElementById("p7result").innerHTML = output;
	}
	else {
		document.getElementById("p7result").innerHTML = 'Input vields require number as input';
	}
}

// ---------------------------------------------------------------

function problem8() {
	var a = document.getElementById("problem8a").value;
	var b = document.getElementById("problem8b").value;
	var height = document.getElementById("problem8height").value;

	var output = 0;
	
	if ((parsingFLOAT(a) != null) && parsingFLOAT(b) != null && parsingFLOAT(height)){
		// output = 0.5 * (a + b) * height;
		a = parsingFLOAT(a);
		b = parsingFLOAT(b);
		height = parsingFLOAT(height);
		output = 0.5 * (a + b) * height;

		document.getElementById("p8result").innerHTML = output;
		}
	else {
		document.getElementById("p8result").innerHTML = 'Input vields require number as input';
	}
}

// ---------------------------------------------------------------

function problem9() {
	var x = document.getElementById("problem9X").value;
	var y = document.getElementById("problem9Y").value;
	
	var circleCentre = coordinates(1, 1);
	var circleRadius = 3;
	var rectXlow = -1;
	var rectXHigh = 5;
	var rectYLow = -1;
	var rectYHigh = 1;
	var inCircle = false;
	var outRect = false;
	var result = 'no';

	if ((parsingFLOAT(x) != null) && parsingFLOAT(y) != null){
		
		var point = coordinates(x, y);
		var d = (point.x - circleCentre.x) * (point.x - circleCentre.x) + (point.y - circleCentre.y) * (point.y - circleCentre.y);
		if (d <= circleRadius * circleRadius) {
			inCircle = true;
		};
		if (point.x < rectXlow || point.x > rectXHigh || point.y < rectYLow || point.y > rectYHigh) {
			outRect = true;
		};

		if (inCircle == true && outRect == true) {
			result = 'yes';
		};
		document.getElementById("p9result").innerHTML = result;
		}
	else {
		document.getElementById("p9result").innerHTML = 'Input vields require number as input';
	}
}