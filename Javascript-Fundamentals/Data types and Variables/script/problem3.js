var notDefined;
var nullValue = null;
var intVar = 12;
var floatVar = 1.2;
var stringVar = 'string';
var boolVar = true;
var obj = {name: 'Java',
			lastName: 'Script'};

var arr = [notDefined, nullValue, intVar, floatVar, stringVar, boolVar, obj];			

for (var i = 0; i < arr.length; i++) {
	console.log('Variable with value of', arr[i], 'is', typeof arr[i], 'of type.');
}