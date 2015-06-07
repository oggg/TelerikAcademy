(function () {
	
	var palindromeString = 'Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".';

	function findPalindrome(text) {
		var splitted = text.split(/[\s,!?.":]+/), 
		i,
		pal;
		splitted = splitted.filter(function(word) {

			for (i = 0; i < word.length / 2; i++) {
				pal = true;
				if (word[i] !== word[word.length - 1 - i]) {
					pal = false;
					break;
				}
			}
			if (pal && word.length > 1) {
				return word;
			}
		}
	);

		return splitted;
	}

	var result = findPalindrome(palindromeString);
	console.log(result);
	})();