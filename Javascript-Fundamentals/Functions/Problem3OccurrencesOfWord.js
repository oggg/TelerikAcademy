var input = 'Lorem ipsum Ipsumsit iPsUmus';
var word = 'ipsum';


function findWord(str, word, isCaseSensitive) {
	
	function caseSensitive() {
		var toFind = new RegExp(word, 'g');
		var found = str.match(toFind);
		return found.length;
	}

	function caseInSensitive() {
		var toFind = new RegExp(word, 'ig');
		var found = str.match(toFind);
		return found.length;
	}
	
	switch (arguments.length) {
		case 2: return caseInSensitive();
		case 3: return isCaseSensitive ? caseSensitive() : caseInSensitive();
	}
}

console.log('Two paratemers (case insensitive): ' + findWord(input, word));
console.log('Three parameters (false -> case insensitive): ' + findWord(input, word, false));
console.log('Three parameters (true -> case sensitive): ' + findWord(input, word, true));