/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and isbn
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book isbn
			*	Book isbn is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var books = [];
		var categories = [];
		var listings = [];

		function listBooks(args) {
			var query;
			if(args) {
				for(query in args) {
					if(args.hasOwnProperty(query)) {
						listings = books.filter(function(item) {
							return item[query] === args[query];
						});
					}
				}
				books = listings.slice();
			}
			books = books.sort(function(a, b) {
				return a.id - b.id;
			});

			return books;
		}

		function addBook(book) {
			var i;

			if(book === undefined || book.title === undefined || book.author === undefined || book.isbn === undefined) {
				throw new Error();
			}

			if(book.title.length > 100 || book.title.length < 2) {
				throw new Error();
			}

			if(book.category.length > 100 || book.category.length < 2 || typeof book.category !== 'string') {
				throw new Error();
			}

			if(book.author === '' || typeof book.author !== 'string') {
				throw new Error();
			}

			if(book.isbn.toString().length !== 10 && book.isbn.toString().length !== 13 || book.isbn.split('').every(function(item) {
					return isNaN(item);
				})) {
				throw new Error();
			}

			for (i = 0; i < books.length; i += 1) {
				if(books[i].title === book.title || books[i].isbn === book.isbn) {
					throw new Error();
				}
			}

			var newBook = {
				title: book.title,
				isbn: book.isbn,
				author: book.author,
				category: book.category || 'no category',
				ID: 0
			};

			newBook.ID = books.length + 1;
			books.push(newBook);

			var categ = {
				category: '',
				ID: 0
			};

			var pos = categories.filter(function(item) {
				return item.category === book.category;
			});

			if(pos.length === 0) {
				categ.category = book.category;
				categ.ID = categories.length + 1;
				categories.push(categ);
			}

			return newBook;
		}

		function listCategories() {
			categories = categories.sort(function(a, b) {
				return a.ID - b.ID;
			}).map(function(item) {
				item = item.category;
				return item;
			});

			return categories;

		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());

	return library;
}

module.exports = solve;
