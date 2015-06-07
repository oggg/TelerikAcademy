(function() {

	function textExtract() {

	var markup = document.documentElement.innerHTML;
	var result;
	var stripped = markup.replace(/(<([^>]+)>)/ig,"");
	var arr = stripped.split('\n');
	var i;
	for (i = 0; i < arr.length; i++) {
		arr[i] = arr[i].trim();
	}
	arr = arr.filter(function(word){
		return !!word || word !== " ";
	});
	result = arr.join('');
	return result;
	}
	
	console.log(textExtract());
	
	})();