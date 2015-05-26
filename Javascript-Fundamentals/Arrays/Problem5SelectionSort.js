var arr = [17, 1, 33, 5, 3, 7, 4, 45, 2, -1];
var i, j, min, swap;

for (j = 0; j < arr.length - 1; j += 1) {
	min = j;
	for (i = j + 1; i < arr.length; i += 1) {
		if (arr[i] < arr[min]) {
			min = i;
		}
	}
	if (min !== j) {
		swap = arr[j];
		arr[j] = arr[min];
		arr[min] = swap;
	}
}

console.log(arr.join(', '));