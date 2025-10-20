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

:heavy_check_mark: - Feature implemented\
:x: - Feature not implemented\
:heavy_minus_sign:  - Not available on Hetzner API


|  | Create | Read | Update | Delete | Actions | Extras |
|--|:--:|:--:|:--:|:--:|:--:|:--:|
| General actions | :heavy_minus_sign: | :x: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Certificates | :x: | :x: | :x: | :x: | :heavy_minus_sign: | :heavy_minus_sign: |
| Datacenters | :heavy_minus_sign: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Firewalls | :heavy_check_mark: | :heavy_check_mark: | :x: | :heavy_check_mark: | :x: | :x: |
| Floating IPs | :x: | :x: | :x: | :x: | :x: | :x: |
| Images | :heavy_minus_sign: | :x: | :x: | :x: | :x: | :x: |
| ISOs | :heavy_minus_sign: | :x: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Load Balancers | :x: | :x: | :x: | :x: | :x: | :x: |
| Locations | :heavy_minus_sign: | :x: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Networks | :x: | :x: | :x: | :x: | :x: | :x: |
| Placement Groups | :x: | :heavy_check_mark: | :x: | :x: | :x: | :x: |
| Pricing | :heavy_minus_sign: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Primary IPs | :x: | :x: | :x: | :x: | :x: | :x: |
| Servers | :heavy_check_mark: | :heavy_check_mark: | :x: | :heavy_check_mark: | :x: | :x: |
| Server Types | :heavy_minus_sign: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| SSH Keys | :heavy_check_mark: | :heavy_check_mark: | :x: | :heavy_check_mark: | :x: | :x: |
| Volumes | :x: | :x: | :x: | :x: | :x: | :x: |
