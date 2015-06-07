
var result = document.getElementById('result');

var people = [{ name: 'Peter', age: 14 }, { name: 'Ivan', age: 55 }, { name: 'Gosho', age: 16 }];
var tmpl = document.getElementById('list-item').innerHTML;
var peopleList = generateList(people, tmpl);

result.innerHTML = peopleList;
console.log(peopleList);

function stringReplace(person, template) {
    template = template.replace('-{name}-', person.name);
    template = template.replace('-{age}-', person.age);

    return template;
}

function generateList(people, template) {
    var result = '<ul>';

    for (var i = 0; i < people.length; i++) {
        var person = people[i];
        result += '<li>' + stringReplace(person, template) + '</li>';
    }

    result += '</ul>';

    return result;
}