function generatePoint(x1, y1) {
    return {
        x: x1,
        y: y1,
        toString: function () {
            return 'x: ' + this.x + ', y: ' + this.y;
        }
    };
}

function generateLine(firstPoint, secondPoint) {
    return {
        begin: firstPoint,
        end: secondPoint,
        length: distance(firstPoint, secondPoint),    
        toString: function () {
            return 'start point: ' + this.begin.toString() + '; end point: ' + this.end.toString() + '; length: ' + this.length;
        }
    };
}

function distance(point1, point2) {
    var dist = Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
    return dist;
}

var firstPoint = generatePoint(1, 2);
var secondPoint = generatePoint(5, 6);
var thirdPoint = generatePoint(-3, -1);
var fourthPoint = generatePoint(0, 4);
var fifthPoint = generatePoint(-1, -2);
var sixthPoint = generatePoint(6, 6);

var firstLine = generateLine(firstPoint, secondPoint);
var secondLine = generateLine(thirdPoint, fourthPoint);
var thirdLine = generateLine(fifthPoint, sixthPoint);

console.log('firstPoint -> ' + firstPoint);
console.log('secondPoint -> ' + secondPoint);
console.log('Distance between first and second point: ' + distance(firstPoint, secondPoint));

console.log('first line -> ' + firstLine);
console.log('second line -> ' + secondLine);
console.log('third line -> ' + thirdLine);

function trianleCheck(length1, length2, length3) {
    var lineLenght = [length1, length2, length3];
    var triangle = false;
    lineLenght.sort(function (a, b) {
        return a - b;
    });
    if (lineLenght[0] + lineLenght[1] > lineLenght[2]) {
        triangle = true;
    }
    return triangle;
}

console.log('Is it possible to create a triangle with those three lines? -> ' + trianleCheck(firstLine.length, secondLine.length, thirdLine.length));