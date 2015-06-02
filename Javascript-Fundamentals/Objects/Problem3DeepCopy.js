function generatePoint(x1, y1) {
    return {
        x: x1,
        y: y1,
    };
}

function generateLine(firstPoint, secondPoint, lineName) {
    return {
        name: lineName,
        begin: firstPoint,
        end: secondPoint,
    };
}


var firstPoint = generatePoint(1, 2);
var secondPoint = generatePoint(5, 6);
var thirdPoint = generatePoint(-3, -1);
var fourthPoint = generatePoint(0, 4);

var firstLine = generateLine(firstPoint, secondPoint, 'firstLine');
var secondLine = generateLine(thirdPoint, fourthPoint, 'secondLine');

console.log(firstLine);
console.log(secondLine);

secondLine = (JSON.parse(JSON.stringify(firstLine)));

console.log('after cloning the second line is: ');
console.log(secondLine);
console.log('Changing second line name to "third line"');

secondLine.name = 'third line';
console.log('The first line is: ');
console.log(firstLine);
console.log('The second line is: ');
console.log(secondLine);

// The recursive way
// function cloning(obj) {
//     if (obj === null || typeof obj !== 'object') {
//         return obj;
//     }
//     var newObj = obj.constructor();
//     for (var item in obj) {
//         newObj[item] = cloning(obj[item]);
//     }
// }