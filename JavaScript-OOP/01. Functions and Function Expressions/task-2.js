/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(start, end) {
    var divider,
        i,
        isPrime,
        endLoop,
        result = [];

    start = +start;
    end = +end;

    if(isNaN(start) || isNaN(end)) {
        throw new Error();
    }

    for (i = start; i <= end; i += 1) {
        if (i > 1) {
            isPrime = true;
            endLoop = parseInt(Math.sqrt(i)) + 1;
            for (divider = 2; divider < endLoop; divider += 1) {
                if (i % divider === 0) {
                    isPrime = false;
                    break;
                }
            }
        }
        else {
            isPrime = false;
        }
        if (isPrime) {
            result.push(i);
        }
    }
    return result;
}

module.exports = findPrimes;
