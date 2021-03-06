using MediatR;

namespace Khaos.MediatrRpc.Client;

public interface IMediatorRpcClient : IMediator
{ }

public interface IMediatorRpcClient<TMarker> : IMediatorRpcClient
{ }