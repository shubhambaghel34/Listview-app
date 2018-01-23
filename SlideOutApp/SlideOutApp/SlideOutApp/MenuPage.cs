using Xamarin.Forms;

namespace SlideOutApp
{
   public class MenuPage : ContentPage
    {
       
        public MenuPage()
        {
            Title = "Master";

            Content = new StackLayout
            {
                Padding = new Thickness(0,20,0,0),
                Children = {
                new MainLink("Page A"),
                new MainLink("Page B"),
                new MainLink("Page C"),
            }
            };
          
           BackgroundColor = Color.FromHex("#D8A395");
            Icon= "menuicon.png";
        }
    }
}