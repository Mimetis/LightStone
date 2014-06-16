LightStone
==========

Carousel control for Windows 8.1 store application and Windows Phone 8.1 application

Introduction
==========

If you want to know how this control was built, you can check those 3 part tutorials :

1. [Create a custom user control using Xaml and C# for Windows 8](http://blogs.msdn.com/b/mim/archive/2013/03/19/create-a-custom-user-control-using-xaml-and-c-for-windows-8.aspx)
2. [Upgrading a Windows 8.0 component to Windows 8.1 and Windows Phone 8.1](http://blogs.msdn.com/b/mim/archive/2014/06/10/upgrading-a-windows-8-0-component-to-windows-8-1-and-windows-phone-8-1-winrt.aspx)
3. [Adding gesture feature on the Carousel control component](http://blogs.msdn.com/b/mim/archive/2014/06/16/carousel-user-control-for-windows-8-1-and-windows-phone-8-1-manipulationdelta-arrangeoverride-and-animation.aspx)

Screenshots
==========

Here are some screenshots of the Windows 8.1 and Windows Phone 8.1 version :

![](http://www.dotmim.com/SiteFiles/CarouselWP81.jpg)

![](http://www.dotmim.com/SiteFiles/CarouselW81.jpg)

How to
===========

Straightforward :

Here is the control inside a xaml application (either Windows 8.1 / Windows Phone 8.1)

```
<ctrl:LightStone ItemsSource="{Binding Datas}" 
    SelectedIndex="0"
    ItemTemplate="{StaticResource TemplateFullScreen}"
    TransitionDuration="300" 
    Depth="200" 
    MaxVisibleItems="4"
    x:Name="LightStoneElement"
    Rotation="50" 
    TranslateY="280"
    TranslateX ="100">
<ctrl:LightStone.EasingFunction>
    <CubicEase EasingMode="EaseOut" />
</ctrl:LightStone.EasingFunction>

</ctrl:LightStone>

```

Don't forget the namespace declaration :)

```
     xmlns:ctrl="using:LightStone.Controls"

```

And the template for your databinded item:

```
        <DataTemplate x:Key="TemplateFullScreen">
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto"/>
                    <RowDefinition Height="Auto"/>
                </Grid.RowDefinitions>
                <Image Source="{Binding BitmapImage}" Width="600" VerticalAlignment="Bottom" 
                               Stretch="Uniform"></Image>

                <Rectangle Grid.Row="1" Fill="Black" Margin="0,10" ></Rectangle>

                <Image Grid.Row="1" VerticalAlignment="Top" Width="600"  Margin="0,10" 
                               Source="{Binding BitmapImage}" Stretch="Uniform" 
                               Opacity="0.1" >
                    <Image.RenderTransform>
                        <CompositeTransform ScaleY="1" />
                    </Image.RenderTransform>
                    <Image.Projection>
                        <PlaneProjection RotationX="180"></PlaneProjection>
                    </Image.Projection>
                </Image>

            </Grid>
        </DataTemplate>

```

Have fun :)

Seb






