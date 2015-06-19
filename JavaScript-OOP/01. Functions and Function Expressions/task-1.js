/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(params) {

	if(params.length === 0){
		return null
	}

	return params.reduce(function(s, number){
		number = +number;
		if(isNaN(number)){
			throw new Error();
		}
		return s + number;
	}, 0);

}

module.exports = sum;