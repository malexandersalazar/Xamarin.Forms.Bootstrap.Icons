# Xamarin.Forms.Bootstrap.Icons

![alt text](/images/cover.png "Bootstrap Icons")

This project is an implementation of [Bootstrap Icons][1] for Xamarin.Forms.

| Bootstrap Icon        | Web Font   |   Xamarin.Forms.Bootstrap.Icons |
|:-----------------|:-------------------|--------------------:|
| 123 | bi bi-123        |            **Z123**  |
| arrow-90deg-down | bi bi-arrow-90deg-down         |            **Arrow90DegDown**  |
| grid-1x2-fill | bi bi-grid-1x2-fill         |            **Grid1X2Fill**  |
| 0 square | bi bi-0-square        |            **Z0Square**  |
| telephone-inbound | bi bi-telephone-inbound        |            **TelephoneInbound**  |
| umbrella | bi bi-umbrella        |            **Umbrella**  |
| 1 circle fill | bi bi-1-circle-fill        |            **Z1CircleFill**  |

## Installation

Xamarin.Forms.Bootstrap.Icons can be loaded via NuGet [![NuGet](https://img.shields.io/nuget/v/Xamarin.Forms.Bootstrap.Icons?style=plastic)](https://www.nuget.org/packages/Xamarin.Forms.Bootstrap.Icons/).

Alternatively, Xamarin.Forms.Bootstrap.Icons can be installed as following:

### Package Manager

> Install-Package Xamarin.Forms.Bootstrap.Icons

### .NET CLI

> dotnet add package Xamarin.Forms.Bootstrap.Icons

## Getting Started

If you're using XAML, you can add this namespace to your root node: `xmlns:bi="clr-namespace:Xamarin.Forms.Bootstrap.Icons;assembly=Xamarin.Forms.Bootstrap.Icons"`. I.e.:

```xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml" 
             xmlns:bi="clr-namespace:Xamarin.Forms.Bootstrap.Icons;assembly=Xamarin.Forms.Bootstrap.Icons">

<!-- The rest of your page here -->

</ContentPage>
```

After this, start using the features you're after.

```xml
<FlyoutItem>
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

```xml
<FlyoutItem>
    <ShellContent>
        <ShellContent.Icon>
            <bi:IconSource Icon="PinMap" Size="24"/>
        </ShellContent.Icon>
    </ShellContent>
    <ShellContent>
        <ShellContent.Icon>
            <bi:IconSource Icon="ListStars" Size="24"/>
        </ShellContent.Icon>
    </ShellContent>
</FlyoutItem>
```

## Icons

All supported icons can be found in the [Icon.cs](/src/Xamarin.Forms.Bootstrap.Icons/Icon.cs) file.

## Prerequisites

* NETStandard.Library (>= 2.0.3)
* Xamarin.Forms (>= 4.5.0.356)

## License

This project is licenced under the [MIT License][2].

[1]: https://icons.getbootstrap.com/ "Bootstrap Icons"

[2]: https://opensource.org/licenses/mit-license.html "The MIT License | Open Source Initiative"