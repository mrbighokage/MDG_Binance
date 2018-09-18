# BinanceDotNet <img src="https://i.imgur.com/x2YPVe6.png" width="56" />

## C# Wrapper for the official Binance exchange API

Compatible with .NETSTANDARD2.0

This repository provides a C# wrapper for the official Binance API, and provides rate limiting features _(set to 10 by 10 out the box)_, a `IAPICacheManager` interface to allow users to provide their own cache implementations, all `REST` endpoints covered, and a best practice solution coupled with strongly typed responses and requests. It is built on the latest .NET Framework and in .NET Core

Feel free to raise issues and Pull Request to help improve the library. If you found this API useful, and you wanted to give back feel free to sign up to Binance via my referral link [**here**](https://www.binance.com/?ref=10886925).

## Documentation
- [Binance Clients](https://github.com/binance-exchange/BinanceDotNet/docs/BINANCE-CLIENTS.md)
- [REST API Calls](https://github.com/binance-exchange/BinanceDotNet/docs/REST-API.md)
- [WebSocket API Calls](https://github.com/binance-exchange/BinanceDotNet/docs/WEBSOCKET-API.md)

## Installation
The package is available in NuGet, or feel free to download:
https://www.nuget.org/packages/MDG.BinanceDotNet/

**Nuget PM**
```
Install-Package MDG.BinanceDotNet -Version 1.0.0
```

