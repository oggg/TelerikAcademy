(function () {

    function stringFormat() {
        var args = [].slice.apply(arguments),
            input = args.shift(),
            i,
            formats,
            index,
            currentIndex;
            
        for (i = 0; i < args.length; i++) {
            formats = '{' + i + '}';
            index = 0;
            currentIndex = input.indexOf(formats, index);
            while (currentIndex >=0) {
                input = input.replace(formats, args[i]);
                index = currentIndex;
                currentIndex = input.indexOf(formats, index);
            }
        }
        return input;
    }

    stringFormat('Format {0}, testing {1} and last string', 'of a string', 'now');
})();