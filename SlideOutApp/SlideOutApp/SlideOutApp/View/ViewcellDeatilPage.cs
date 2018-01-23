using SlideOutApp.Model;
using Xamarin.Forms;

namespace SlideOutApp
{
    public class ViewcellDeatilPage : ContentPage
    {
     

        public ViewcellDeatilPage(Users users)
        {
            Title = users.Name;
            Content = new Label
            {
                Text = users.Description,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };
        }
    }
}