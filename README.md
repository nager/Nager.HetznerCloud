# Nager.HetznerCloud

A modern **.NET API client** for the [Hetzner Cloud API](https://docs.hetzner.cloud).  
This library provides a clean and easy-to-use interface to manage servers, networks, firewalls, and other Hetzner Cloud resources directly from your .NET applications.


## 🚀 Installation

The package is available on [NuGet](https://www.nuget.org/packages/Nager.HetznerCloud).

```ps
PM> Install-Package Nager.HetznerCloud
```

or

```
dotnet add package Nager.HetznerCloud
```

## 💡 Example Usage

```cs
var apiToken = "<your-api-token>";

var httpClient = new HttpClient();
var hetznerCloudClient = new HetznerCloudClient(httpClient, apiToken);

var prices = await hetznerCloudClient.PricesQueryAsync();
```

## ⚙️ Features Overview

✅ – Feature implemented  
⚪ – Feature not implemented  
➖ – Not available in the Hetzner API

|  | Create | Read | Update | Delete | Actions | Extras |
|--|:--:|:--:|:--:|:--:|:--:|:--:|
| General actions | ➖ | ⚪ | ➖ | ➖ | ➖ | ➖ |
| Certificates | ⚪ | ⚪ | ⚪ | ⚪ | ➖ | ➖ |
| Firewalls | ✅ | ✅ | ⚪ | ✅ | ⚪ | ⚪ |
| Floating IPs | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ |
| Images | ➖ | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ |
| ISOs | ➖ | ⚪ | ➖ | ➖ | ➖ | ➖ |
| Load Balancers | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ |
| Locations | ➖ | ✅ | ➖ | ➖ | ➖ | ➖ |
| Networks | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ |
| Placement Groups | ⚪ | ✅ | ⚪ | ⚪ | ⚪ | ⚪ |
| Pricing | ➖ | ✅ | ➖ | ➖ | ➖ | ➖ |
| Primary IPs | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ |
| Servers | ✅ | ✅ | ⚪ | ✅ | ⚪ | ⚪ |
| Server Types | ➖ | ✅ | ➖ | ➖ | ➖ | ➖ |
| SSH Keys | ✅ | ✅ | ⚪ | ✅ | ⚪ | ⚪ |
| Volumes | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ | ⚪ |

