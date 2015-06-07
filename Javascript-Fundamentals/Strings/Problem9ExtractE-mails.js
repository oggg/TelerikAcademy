(function () {
		var text = 'This is a text containing mails: test1@mail.com, test2@mail.com and the last one test3@mail.com. Test4@mail.com: my email.';

		function extractMais(text) {
			var splitted = text.split(/[\s,!?:]+/),
			index;

			for (index = 0; index < splitted.length; index++) {
				if (splitted[index][splitted[index].length - 1] === '.') {
					splitted[index] = splitted[index].slice(0, -1);
				}
			}

			splitted = splitted.filter(function(word) {
					if (word.indexOf('@') > 0) {
					return word;
				}
			});

			return splitted;
		}

		console.log(extractMais(text));
})();