/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
	var studentID = 0,
		EXAM_WEIGHT = 75,
		HOMEWORK_WEIGHT = 25,
		i,
		studentIndex,
		p;

	var Course = {
		init: function(title, presentations) { // presentation is an array of strings
			this.title = title;
			this.presentations = presentations;
			this.students = [];
			this.studentsHomeworks = [];
			this.finalExamResults = [];
			this.homeworkEvaluation = [];
			this.examEvaluation = [];
			this.topTen = [];
			return this;
		},
		addStudent: function(name) {
			if(!checkStudentName(name)) {
				throw new Error('Student name is not valid');
			}
			this.students.push({firstname: name.split(' ')[0], lastname: name.split(' ')[1], id: idGenerator()});
			return this.students[this.students.length - 1].id;
		},
		getAllStudents: function() {
			return this.students;
		},
		submitHomework: function(studentID, homeworkID) {
			if(studentID < 1 || studentID > this.students.length || isNaN(studentID)) {
				throw new Error('The homework is from a student with ID, which is not valid');
			}

			if(homeworkID > this.presentations.length) {
				throw new Error('Homework Id is not valid');
			}

			//if(homeworkID < 1) { //|| homeworkID > this.presentations.length) {
			//	throw new Error('Homework Id is not valid');
			//}

			// studentID = +studentID;


			this.studentsHomeworks.push({StudentID: studentID, HomeworkID: homeworkID});
		},
		pushExamResults: function(results) {
			results = results.sort(function(a, b) {
				return a.StudentID - b.StudentID;
			});
			this.students = this.students.sort(function(a, b) {
				return a.id - b.id;
			});

			validateResults(this.students, results);

			results = results.map(function(item) {
				return item = item.StudentID;
			});
			this.finalExamResults = results.slice();
			for(i = 0; i < this.students.length; i++) {
				if(results.indexOf(this.students[i].id) === -1) {
					this.finalExamResults.push({StudentID: this.students[i].id, Score: 0});
				}
			}
		},
		getTopStudents: function() {
			this.finalExamResults = this.finalExamResults.sort(function(a, b) {
				return a.StudentID - b.StudentID;
			});

			this.examEvaluation = this.finalExamResults.map(function(score) {
				return score.Score = score.Score * EXAM_WEIGHT;
			});

			this.homeworkEvaluation = gradingHomeworks(this.students, this.studentsHomeworks, this.presentations);

			for(studentIndex = 0; studentIndex < this.students.length; studentIndex++) {
				this.examEvaluation.push({
					StudentID: studentIndex + 1,
				Score: (this.examEvaluation[i].Score + this.homeworkEvaluation[i].homeworksDone) / 100
				});
			}

			this.examEvaluation = this.examEvaluation.sort(function(a, b) {
				return a.Score - b.Score;
			});

			for(i = 0; i < this.examEvaluation.length; i ++ ) {
				if(i === 10) {
					break;
				}
				this.topTen.push(this.examEvaluation[i]);
			}
			return this.topTen;
		}
	};

	Object.defineProperties(Course, {
		'title': {
			get: function () {
				return this._title;
			},
			set: function(value) {
				if(!checkTitle(value)) {
					throw new Error('Title is not valid');
				}
				this._title = value;
				return this;
			}
		},
		'presentations': {
			get: function() {
				return this._presentations;
			},
			set: function(value) {
				if(value.length === 0) {
					throw new Error('Presentations should be added to course');
				}
				this._presentations = value;
				return this;
			}
		}
	});

	function checkTitle(title) {
		if(title[0] === ' '
			|| title[title.length - 1] === ' '
			|| title.indexOf('  ') > -1
			|| title === '') {
			return false;
		}
		return true;
	}

	function checkStudentName(name) {

		var firstName = name.split(' ')[0];
		var secondName = name.split(' ')[1];
		var allNames = name.split(' ');
		if(allNames.length > 2) {
			return false;
		}

		if(nameValidator(firstName) && nameValidator(secondName)) {
			return true;
		}
		return false;
	}

	function nameValidator(name) {
		var firstLetter,
			otherLetters,
			isFirstLetterUppercase,
			areLettersLowercase;

		firstLetter = name[0];
		isFirstLetterUppercase = /[A-Z]/.test(firstLetter);
		if(name.length > 1) {
			otherLetters = name.slice(1);
			areLettersLowercase = /[a-z]/.test(otherLetters);

			return !!(isFirstLetterUppercase && areLettersLowercase);
		}
		else {
			if(isFirstLetterUppercase) {
				return true;
			}
			else {
				return false;
			}
		}
	}

	function idGenerator() {
		return ++studentID;
	}

	function validateResults(students, results) {

		results.forEach(function(item) {
			if(item.StudentID < 1 || item.StudentID > students.id || isNaN(item.StudentID) || isNaN(+item.Score)) {
				throw new Error('Result ID or score is not valid');
			}
		});

		for(i = 0; i < results.length - 1; i++) {
			if(results[i].StudentID === results[i + 1].StudentID) {
				throw new Error('Student with ID ' + results[i].StudentID + ' is cheating');
			}
		}
	}

	function gradingHomeworks(students, homeworks, presentations) {
		var sortedHW = [],
			countHW,
			gradeHW = [],
			i;
		sortedHW = homeworks.sort(function(a, b){
			return a.StudentID - b.StudentID;
		});

		for(i = 1; i < sortedHW.length; i++) {
			if(sortedHW[i].StudentID === sortedHW[i - 1].StudentID) {
				countHW++;
			}
			else {
				gradeHW.push({StudentID: sortedHW[i - 1].StudentID, homeworksDone: countHW});
				countHW = 1;
			}
		}

		gradeHW = gradeHW.map(function(homework) {
			return homework.homeworksDone = (homework.homeworksDone / presentations.length) * 25;
		})
			.map(function(student) {
				return student.StudentID;
			});

		for(i = 0; i < students.length; i++) {
			if(gradeHW.indexOf(i) === -1) {
				gradeHW.push({StudentID: i, homeworksDone: 0});
			}
		}

		sortedHW = gradeHW.sort(function(a, b){
			return a - b;
		});
		return sortedHW;
	}

	// test area start
	//var jsoop = Object.create(Course),
	//	id;
	//jsoop.init('Valid title', ['Valid presentations']);
	//id = jsoop.addStudent('Pesho' + ' ' + 'Peshev');
	//jsoop.submitHomework(id, 1);
	// test area end

	return Course;
}

//solve();

module.exports = solve;
