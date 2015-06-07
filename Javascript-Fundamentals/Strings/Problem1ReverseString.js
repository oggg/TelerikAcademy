(function () {
    function reverseStr(str) {
        var resultStr = '',
        	i;
        for (i = str.length - 1; i >= 0; i--) {
            resultStr += str[i];
        }
        return resultStr;
    }

    console.log(reverseStr('testing test'));
}
)();