using System;
using WebSocket4Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace WSClient
{
    struct cmdPacket { public string command; }
    public delegate void WebSocketEventHandler(object sender, EventArgs e);
    public delegate void WebSocketMessageHandler(object sender, MessageReceivedEventArgs e);

    class SocketClient
    {
        private bool _peekModus;
        private cmdPacket _packet;
        private WebSocket _websocket;

        public event WebSocketEventHandler WebSocketOpened;
        public event WebSocketEventHandler WebSocketClosed;
        public event WebSocketMessageHandler PeekSampleArrived;
        public event WebSocketMessageHandler SampleArrived;

        /// <summary>
        /// Initialise a websocket client
        /// </summary>
        /// <param name="ipAddress">The ipAddress where the server is located</param>
        public SocketClient(string ipAddress)
        {
            Open(ipAddress);
        }

        /// <summary>
        /// Open a connection to the websocket server
        /// </summary>
        /// <param name="ipAddress">The ip address where the websocket server is located</param>
        public void Open(string ipAddress)
        {
            _peekModus = false;

            wsConnect(ipAddress);
            _packet = new cmdPacket();
        }

        /// <summary>
        /// Close the conection to the websocket server
        /// </summary>
        public void Close()
        {
            _websocket.Close();
        }

        /// <summary>
        /// Start the sampling process on the websocket client
        /// </summary>
        public void StartSampling()
        {
            _peekModus = false;

            _packet.command = "start";
            _websocket.Send(JsonConvert.SerializeObject(_packet));
        }

        /// <summary>
        /// Stop the sampling process on the websocket client
        /// </summary>
        public void StopSampling()
        {
            //Stop sampling
            _packet.command = "stop";
            _websocket.Send(JsonConvert.SerializeObject(_packet));

            this.RetrieveSamples();
        }

        /// <summary>
        /// Get 1 sample from the websocket server
        /// </summary>
        public void NextSample()
        {
            _peekModus = true;
            _packet.command = "peek";
            _websocket.Send(JsonConvert.SerializeObject(_packet));

            this.RetrieveSamples();
        }

        /// <summary>
        /// Get all the samples from the websocket server
        /// </summary>
        public void RetrieveSamples()
        {
            _packet.command = "retrieve";
            _websocket.Send(JsonConvert.SerializeObject(_packet));
        }

        /// <summary>
        /// Destructor the websocket client
        /// </summary>
        ~SocketClient()
        {
            if(_websocket.State.Equals(WebSocketState.Open))
                this.Close();
        }


        /***************************** PRIVATE ZONE *****************************/
        /// <summary>
        /// Connect to a websocket server on a certain ipaddress
        /// </summary>
        /// <param name="ipAddress">The ipaddress to connect to</param>
        private void wsConnect(string ipAddress)
        {
            _websocket = new WebSocket("ws://" + ipAddress);
            _websocket.Opened += new EventHandler(websocket_Opened);
            _websocket.Closed += new EventHandler(websocket_Closed);
            _websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(websocket_MessageReceived);
            _websocket.Open();
        }

        /// <summary>
        /// Event when a new message is recieved from the websocket
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">Parameters</param>
        private void websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            if (!_peekModus)
                SampleArrived(sender, e);
            else
                PeekSampleArrived(sender, e);
        }

        /// <summary>
        /// Event when the websocket is opened
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">Parameters</param>
        private void websocket_Opened(object sender, EventArgs e)
        {
            WebSocketOpened(sender, e);
            Console.WriteLine("Opened");
        }

        /// <summary>
        /// Event when the websocket is closed
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">Parameters</param>
        private void websocket_Closed(object sender, EventArgs e)
        {
            WebSocketClosed(sender, e);
            Console.WriteLine("Closed");
        }
    }
}
