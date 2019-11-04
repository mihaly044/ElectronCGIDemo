const { ConnectionBuilder } = require('electron-cgi');

const connection = new ConnectionBuilder()
    .connectTo('dotnet', 'run', '--project', '../ElectronCGIDemo')
    .build();

connection.send('greeting', 'John', greeting => {
    console.log(greeting); // will print "Hello John!"
});