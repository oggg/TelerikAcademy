(function () {
    String.prototype.sub = function (sample) {
        var i = 0,
        foundAt,
        count = 0,
        sliced = this.toLowerCase(),
        sample = sample.toLowerCase();

        if (!(sample === '')) {
            while (true) {
                foundAt = sliced.indexOf(sample);
                if (foundAt == -1) {
                    break;
                }
                i += foundAt + sample.length;
                sliced = sliced.slice(i);
                count++;
                i = 0;
            }
        }
        else {
            return count;
        }
        return count;
    };

    var example = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    console.log(example.sub('in'));
})();