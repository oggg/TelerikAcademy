/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (students) {

  	var MIN_AGE = 18;
  	var MAX_AGE = 24;

  	var studentsFullName = _.map(students, function(student){
		return {
			firstName: student.firstName,
			lastName: student.lastName,
			age: student.age,
			fullName: student.firstName + ' ' + student.lastName
		}
	});
	var ageRange = _.chain(studentsFullName).filter(function(student) {
					var inRange = MIN_AGE <= student.age && student.age <= MAX_AGE;
					return inRange;
		}).sortBy('fullName').value();
	
		_.each(ageRange, function(student){
			console.log(student.fullName);
		});
  };
}

module.exports = solve;
