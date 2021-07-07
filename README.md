# Xamarin.Forms.Bootstrap.Icons

<center>
<img src="https://icons.getbootstrap.com/assets/img/icons-hero.png" alt="Bootstrap Icons">
</center>

This project is an implementation of [Bootstrap Icons][1] for Xamarin.Forms.

[1]: https://icons.getbootstrap.com/ "Bootstrap Icons"

| Bootstrap Icon        | Web Font   |   Xamarin.Forms.Bootstrap.Icons |
|:-----------------|:-------------------|--------------------:|
| arrow-90deg-down | bi bi-arrow-90deg-down         |            **Arrow90degDown**  |
| grid-1x2-fill | bi bi-grid-1x2-fill         |            **Grid1x2Fill**  |
| telephone-inbound | bi bi-telephone-inbound        |            **TelephoneInbound**  |
| umbrella | bi bi-umbrella        |            **Umbrella**  |

## Installation

Xamarin.Forms.Bootstrap.Icons can be loaded via NuGet [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Bootstrap.Icons?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.Bootstrap.Icons/).

Alternatively, Xamarin.Forms.Bootstrap.Icons can be installed as following:

### Package Manager

> Install-Package Xamarin.Forms.Bootstrap.Icons -Version 1.5.0.0

### .NET CLI

> dotnet add package Xamarin.Forms.Bootstrap.Icons --version 1.5.0.0

## Usage

```xml
xmlns:bi="clr-namespace:Xamarin.Forms.Bootstrap.Icons;assembly=Xamarin.Forms.Bootstrap.Icons"
```

```xml
<FlyoutItem Title="Payments">
    <FlyoutItem.Icon>
        <bi:IconSource Icon="CurrencyDollar" Size="24" Color="White"/>
    </FlyoutItem.Icon>
    <!-- ... -->
</FlyoutItem>
```

```xml
<Image>
    <Image.Source>
        <bi:IconSource Icon="Pencil" Size="24" Color="#28B1D0"/>
    </Image.Source>
</Image>
```

## Prerequisites

* NETStandard.Library (>= 2.0.3)
* Xamarin.Forms (>= 4.5.0.356)

## License

This project is licenced under the [MIT License][2].

[2]: https://opensource.org/licenses/mit-license.html "The MIT License | Open Source Initiative"