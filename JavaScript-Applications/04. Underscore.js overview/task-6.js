/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
  return function (books) {

	var fullNameAuthors = _.each(books, function(book) {
		book.authorFullName = book.author.firstName + ' ' + book.author.lastName;
	});
	
	var groupByAuthors = _.groupBy(fullNameAuthors, 'authorFullName');
	var kvPairs = _.pairs(groupByAuthors);
	var popular = _.sortBy(kvPairs, function(pair) {
		return -pair[1]['length'];
	});

	var mostBooksWritten = popular[0][1].length;

	var mostPopular = _.filter(popular, function(author) {
		return author[1].length == mostBooksWritten;
	});
	var sortedMostPopular = _.sortBy(mostPopular, function(author) {
		return author[0];
	});
	var logging = _.each(sortedMostPopular, function(author) {
		console.log(author[0]);
	});

  };
}

module.exports = solve;
