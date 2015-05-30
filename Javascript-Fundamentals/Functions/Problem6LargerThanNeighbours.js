var arr = [1, 5, 3, 5, 8, 9, 6, 4, 3, 2, 3];

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

console.log(larger(arr, 10));