(function() {
	function correctBrackets(input) {
		
		var correct = true,
			countOpening = 0,
			i;

			function checkBracket(bracket) {
			if (bracket === '(') {
				countOpening++;
			}
			if (bracket === ')') {
				countOpening--;
				}
			return countOpening;
		}

		for (i = 0; i < input.length; i++) {
			if (checkBracket(input[i]) < 0) {
				correct = false;
				break;
			}
		}
		return correct;
	}

	var test = '(a+b))';
	console.log(correctBrackets(test));
	})();