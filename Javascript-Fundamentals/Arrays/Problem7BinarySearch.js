var arr = [3, 15, 16, 20, 45, 50, 66, 69, 71, 82, 91, 100];
var key,
	imin,
	imax;

function binSearch(arr, key, imin, imax) {
	if (imax < imin) {
		console.log('KEY_NOT_FOUND');
		return;
	}
	else {
		var imid = imin + (((imax - imin) / 2) | 0);

		if (arr[imid] > key) {
			return binSearch(arr, key, imin, imid - 1);
		}
		else if (arr[imid] < key) {
			return binSearch(arr, key, imid + 1, imax);
		}
		else {
			console.log('The searched element "' + key +'" is at position ' + imid);
			return;
		}
	}
}

binSearch(arr, 91, 0, arr.length - 1);