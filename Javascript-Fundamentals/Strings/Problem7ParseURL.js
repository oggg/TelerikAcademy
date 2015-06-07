(function () {

    function parsing(url) {
        var protocol,
            protocolIndex,
			server,
            serverIndex,
			resource;
        protocolIndex = url.indexOf('://');
        protocol = url.substring(0, protocolIndex);
        protocolIndex += 3;
        serverIndex = url.indexOf('/', protocolIndex);
        server = url.substring(protocolIndex, serverIndex);
        resource = url.substring(serverIndex);
        return {
            protocol: protocol,
            server: server,
            resource: resource
        };
    }

    var url = 'http://telerikacademy.com/Courses/Courses/Details/239';
    console.log(parsing(url));
})();
