using Xamarin.Forms;

namespace SlideOutApp
{
  public class SubLink : Button
    {
        public SubLink(string name)
        {
            Text = name;
            //Command = new Command(o => App.MasterDetailPage.Detail.Navigation.PushAsync(new LinkPage(name)));

        }
       
    }
}