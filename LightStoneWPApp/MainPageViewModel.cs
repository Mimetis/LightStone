using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace LightStoneWPApp
{
    public class MainPageViewModel
    {
        public ObservableCollection<Object> Datas
        {
            get; set; }

        public MainPageViewModel()
        {
            var datas = new ObservableCollection<Object>();
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic01.jpg", UriKind.Absolute)), Title = "01" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic03.jpg", UriKind.Absolute)), Title = "02" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic05.jpg", UriKind.Absolute)), Title = "03" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic04.jpg", UriKind.Absolute)), Title = "04" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic02.jpg", UriKind.Absolute)), Title = "05" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic06.jpg", UriKind.Absolute)), Title = "06" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic01.jpg", UriKind.Absolute)), Title = "07" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic02.jpg", UriKind.Absolute)), Title = "08" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic03.jpg", UriKind.Absolute)), Title = "09" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic04.jpg", UriKind.Absolute)), Title = "10" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic05.jpg", UriKind.Absolute)), Title = "11" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic06.jpg", UriKind.Absolute)), Title = "12" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic01.jpg", UriKind.Absolute)), Title = "13" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic02.jpg", UriKind.Absolute)), Title = "14" });
            datas.Add(new Data { BitmapImage = new BitmapImage(new Uri("ms-appx:///Assets/pic03.jpg", UriKind.Absolute)), Title = "15" });

            this.Datas = datas;
        }
    }
    public class Data
    {
        public BitmapImage BitmapImage { get; set; }
        public String Title { get; set; }
    }
}
