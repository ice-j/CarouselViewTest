using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace CarouselViewTest
{
	public partial class TheMainPage : ContentPage
	{
        public ObservableCollection<GalleryImage> Images { get; set; } = new ObservableCollection<GalleryImage>();

        public TheMainPage()
		{
			InitializeComponent ();
            BindingContext = this;
            Images.Add(new GalleryImage
            {
                ImgUrl = "https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"
            });
            Images.Add(new GalleryImage
            {
                ImgUrl = "https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"
            });
            Images.Add(new GalleryImage
            {
                ImgUrl = "https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"
            });
        }
	}

    public class GalleryImage
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ImgUrl { get; set; }
    }
}
