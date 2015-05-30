var arr = [1, 2, 3, 5, 8, 9, 6, 4, 3, 2, 2];

function larger(arr, position) {

	var result = false;
	if (Array.isArray(arr) && +position) {
		if (position < 0 && position > arr.length - 1) {
			return -1;
		}
		else {
			if (position === 0) {
				if (arr[position] > arr[position + 1]) {
					result = true;
				}
			}
			if (position === arr.length - 1) {
				if (arr[position] > arr[position - 1]) {
				result = true;
				}
			}
			if (position > 0 && position < arr.length - 1) {
				if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1]) {
					result = true;
				}
			}
		}
	}
	return result;
}

function getIndex(arr) {
	var i;
	for (i = 0; i < arr.length; i++) {
		if (larger(arr, i)) {
			return i;
		}
		else {
			if (i === arr.length - 1) {
				return - 1;
			}
		}
	}
}

console.log(getIndex(arr));