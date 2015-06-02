function hasProperty(obj, prop) {
	if (obj === null || typeof obj !== 'object') {
		console.log('The input is not an object');
		return;
	}

	return prop in obj;
}

var date = new Date();
console.log('A new Date object for property check -> ' + date);
var hasProp = hasProperty(date, 'getDate');
console.log('Does it have "getDate" property -> ' + hasProp);
hasProp = hasProperty(date, 'length');
console.log('Does it have "length" property -> ' + hasProp);