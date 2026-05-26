[//]: # (CLASS:Intrinio.SDK.Model.AccountWebsocketStatus)

[//]: # (KIND:object)

### Intrinio.SDK.Model.AccountWebsocketStatus
#### Properties

[//]: # (START_DEFINITION)

Name | Type | Description
------------ | ------------- | -------------
**Feed** | string | The feed name for the connection. &nbsp;
**FeedConnectionNumber** | int? | The connection number for this account within a feed. &nbsp;
**Ip** | string | The IP address detected for the client connection. &nbsp;
**ConnectedOn** | DateTime? | The UTC time this client connection connected to the server. &nbsp;
**StatusUpdatedOn** | DateTime? | The UTC time the server updated this client connection status data. &nbsp;
**IsDelayed** | bool? | Whether this connection is delayed an extra 15 minutes from the source. Note that the Delayed SIP source is already delayed, so this value will be false for those connections. &nbsp;
**IsFirehose** | bool? | The client connection is in firehose mode (all channels subscribed). &nbsp;
**TradeSubscriptions** | int? | The count of channel subscriptions for trade events. &nbsp;
**QuoteSubscriptions** | int? | The count of channel subscriptions for ask and bid events. &nbsp;
**RefreshSubscriptions** | int? | The count of channel subscriptions for refresh events (OPRA options feed only). &nbsp;
**UnusualActivitySubscriptions** | int? | The count of channel subscriptions for unusual activity events (OPRA options feed only). &nbsp;
**PacketsPerSecond** | decimal? | The packets per second sent since the last status update. &nbsp;
**TotalPacketsSent** | string | The total packets sent since the beginning of this connection.  A packet is a group of events sent as one message over the websocket. &nbsp;
**EventsPerSecond** | decimal? | The events per second sent since the last status update. &nbsp;
**TotalEvents** | string | The total events sent to this connection&#39;s server-side queue since the beginning of this connection.  An event is an individual occurrence of a trade, quote, etc. &nbsp;
**TotalSentEvents** | string | The total events sent to the client inside packets. A packet is a group of events sent as one message over the websocket. &nbsp;
**TotalDrops** | string | The total number of events dropped from the connection&#39;s server-side queue.  Event drops happen when the connection&#39;s server-side queue is full. The server-side queue fills due to client-side connections not receiving packets fast enough, which can be caused by a slow network, or clients not decoupling processing of packets from the receipt of packets. &nbsp;
**QueueDepthPercentage** | decimal? | The percentage that the connection&#39;s server-side queue is full. 0-100. &nbsp;

[//]: # (END_DEFINITION)


