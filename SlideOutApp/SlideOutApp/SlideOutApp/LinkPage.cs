using Xamarin.Forms;

namespace SlideOutApp
{
    public class LinkPage : ContentPage
    {
        public LinkPage(string name)
        {
            BackgroundColor = Color.Azure;
            Title = "Deatil";
            Content = new StackLayout
            {
                Children = {
                new SubLink(name + ".1"),
                new SubLink(name + ".2"),
                new SubLink(name + ".3"),
            },
            };
        }
    }
}