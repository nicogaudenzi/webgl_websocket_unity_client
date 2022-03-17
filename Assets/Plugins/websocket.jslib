mergeInto(LibraryManager.library, {

  WebSocketInit: function(url, protocol) {
         this.socket = new WebSocket("ws://127.0.0.1:5678").onmessage = function (event) {
         		gameInstance.SendMessage("ReciveFromBrowser","ReciveSimple",3);
                console.log(event.data);
            };
  },

  WebSocketSend: function(message) {
         this.socket.send(message);
  }

});