(function () {

    function aTag() {
        var content = document.documentElement.innerHTML,
            startIndex,
            endIndex;
        var sub = '';
        while (content.indexOf('<a') > 0) {
            startIndex = content.indexOf('<a');
            endIndex = content.indexOf('">', startIndex) + 2;

            editSub = content.substring(startIndex, endIndex)
            .replace('<a href="', '[URL=')
            .replace('">', ']');
            
            startSub = content.substring(0, startIndex);
            endSub = content.substring(endIndex);
            content = startSub + editSub + endSub;
            content = content.replace('</a>', '[/URL]');
        }

        return content;
    }

    console.log(aTag());
})();
