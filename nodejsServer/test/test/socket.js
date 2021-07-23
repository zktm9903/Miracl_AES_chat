const { isObject } = require('util');

var app = require('express')();
var server = require('http').createServer(app);
// http server를 socket.io server로 upgrade한다
var io = require('socket.io')(server);

// localhost:3000으로 서버에 접속하면 클라이언트로 index.html을 전송한다
app.get('/', function(req, res) {
  res.sendFile(__dirname + '/index-room.html');
});

var chat = io.on('connection', function(socket) {
  console.log('Conneted by something')
  console.log(socket.id)
  socket.on('chat', function(data){
    console.log('message from client: ', data);

    // 메시지를 전송한 클라이언트를 제외한 모든 클라이언트에게 메시지를 전송한다
    socket.broadcast.emit('chat', data);

    // 메시지를 전송한 클라이언트에게만 메시지를 전송한다
     //socket.emit('test', data);
  });
});

server.listen(3000, function() {
  console.log('Socket IO server listening on port 3000');
});