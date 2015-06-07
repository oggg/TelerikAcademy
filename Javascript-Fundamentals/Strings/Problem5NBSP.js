(function() {

	var text = 'Lorem ipsum dolor       sit amet, consectetur adipisicing elit, sed do    eiusmod 	tempor incididunt    ut labore    et dolore magna';

	function spaceReplace(text) {
		
		var arr = text.split(' '),
		index,
		result;
		console.log(text);
		for(index = 0; index < arr.length; index += 1) {
			if (arr[index] === "") {
				arr.splice(index, 1);
				index--;
			}
		}
		result = arr.join('\&nbsp;');
		return result;
	}
	
	console.log(spaceReplace(text));

	})();