(function () {

    var maxPeople = 10;

    function createPerson(fname, lname, age, gender) {
        return {
            firstname: fname,
            lastname: lname,
            age: age,
            gender: gender,
            toString: function () {
                return this.firstname + ' ' + this.lastname;
            }
        }
    }
    var pesho = createPerson('Pesho', 'Petrov', 20, false),
        gosho = createPerson('Gosho', 'Goshev', 15, false),
        james = createPerson('James', 'Tomkins', 15, false),
        helen = createPerson('Helen', 'Owen', 17, true),
        kevin = createPerson('Kevin', 'Nolan', 32, false),
        audrey = createPerson('Audrey', 'Tautou', 39, true),
        jerard = createPerson('Jerard', 'Pique', 21, false),
        penelope = createPerson('Penelope', 'Cruz', 41, true),
        jean = createPerson('Jean', 'Dujardin', 42, false),
        keira = createPerson('Keira', 'Knightley', 29, true)
    
    //Problem 1. Make person

    //Write a function for creating persons.
    //    Each person must have firstname, lastname, age and gender (true is female, false is male)
    //    Generate an array with ten person with different names, ages and genders

    var peopleArr = [pesho, gosho, james, helen, kevin, audrey, jerard, penelope, jean, keira];

    //Problem 2. People of age

    //Write a function that checks if an array of person contains only people of age (with age 18 or greater)
    //    Use only array methods and no regular loops (for, while)
    function isGreaterThan18(person) {
        return person.age > 18;
    }

    console.log(peopleArr.every(isGreaterThan18));

    //Problem 3. Underage people

    //Write a function that prints all underaged persons of an array of person
    //    Use Array#filter and Array#forEach
    //    Use only array methods and no regular loops (for, while)

    console.log('Underaged people: ');
    var underagedFilter = peopleArr.filter(function (person) {
        return person.age < 21;
    }).forEach(function (person) {
        console.log(person);
    })

    //Problem 4. Average age of females

    //Write a function that calculates the average age of all females, extracted from an array of persons
    //    Use Array#filter
    //    Use only array methods and no regular loops (for, while)

    var averageAgeFemales = peopleArr.filter(function (person) {
        return person.gender == true;
    }).reduce(function (sum, person, index, array) {
        return (sum + person.age / array.length);
    }, 0)

    console.log('Average age of women - ' + averageAgeFemales);

    //Problem 5. Youngest person

    //Write a function that finds the youngest male person in a given array of people and prints his full name
    //    Use only array methods and no regular loops (for, while)
    //    Use Array#find

    if (!Array.prototype.find) {
        Array.prototype.find = function (callback) {
            var i, len = this.length;
            for (i = 0; i < len; i += 1) {
                if (callback(this[i], i, this)) {
                    return this[i];
                }
            }
        }
    }

    var youngestMale =
    peopleArr.sort(function (a, b) {
        return a.age - b.age;
    }).find(function (person) {
        return !person.gender;
    });

    console.log(youngestMale);

    //Problem 6. Group people

    //Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
    //    Use Array#reduce
    //    Use only array methods and no regular loops (for, while)

    var grouped = peopleArr.sort(function (a, b) {
        return a.firstname - b.firstname;
    })

    var result = peopleArr.reduce(function (obj, item) {
        if (obj[item.firstname[0]]) {
            obj[item.firstname[0]].push(item);
        } else {
            obj[item.firstname[0]] = [item];
        }
        return obj;
    }, {});

    console.log(result);
    })();