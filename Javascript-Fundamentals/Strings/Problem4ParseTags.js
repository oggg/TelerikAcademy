(function() {

	var elements = document.body.getElementsByTagName("*");

	function getRandom(min, max) {
	var result = Math.random() * (max - min) + min;
  	return result;
	}


	function mixing(elementContent) {

		var splitted = elementContent.split('');
		for (var i = 0; i < splitted.length; i++) {
			if (parseInt(getRandom(1, 100)) > 50) {
				splitted[i] = splitted[i].toUpperCase();
			}
			else {
				splitted[i] = splitted[i].toLowerCase();
			}
		}
		return splitted.join('');
	}

	for (var i = 0; i < elements.length; i++) {
		switch (elements[i].localName) {
			case 'upcase': {
				elements[i].innerHTML = elements[i].innerHTML.toUpperCase();
				break;
			}
			case 'lowcase': {
				elements[i].innerHTML = elements[i].innerHTML.toLowerCase();
				break;
			}
			case 'mixcase': {
				elements[i].innerHTML = mixing(elements[i].innerHTML);
			}
		}
	}

})();