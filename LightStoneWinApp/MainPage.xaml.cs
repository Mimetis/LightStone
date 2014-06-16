using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LightStoneWinApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            MainPageViewModel mainPageViewModel = (MainPageViewModel)this.DataContext;

            Button b = (Button)sender;

            string tag = b.Tag.ToString();
            var allItems = tag.Split(new[] { '-' });

            Data[] datas = new Data[allItems.Length];

            for (int i = 0; i < allItems.Length; i++)
            {
                Int32 indexToRemove = Int32.Parse(allItems[i]);
                Int32 maxIndex = mainPageViewModel.Datas.Count - 1;
                indexToRemove = Math.Min(indexToRemove, maxIndex);

                datas[i] = mainPageViewModel.Datas[indexToRemove];
            }

            foreach (var item in datas.Where(item => mainPageViewModel.Datas.Contains(item)))
                mainPageViewModel.Datas.Remove(item);
        }

        private void AddItemClick(object sender, RoutedEventArgs e)
        {
            MainPageViewModel mainPageViewModel = (MainPageViewModel)this.DataContext;

            mainPageViewModel.Datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic01.jpg", UriKind.Absolute)), Title = "Wall 05" });
            mainPageViewModel.Datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic02.jpg", UriKind.Absolute)), Title = "Wall 06" });

        }
    }
}
