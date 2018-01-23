using SlideOutApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SlideOutApp
{
    public class ViewcellPage : ContentPage
    {
        ListView lstv;
        public ViewcellPage()
        {
            lstv = new ListView
            {
                ItemsSource = new List<Users>
                {
                      new Users { Name = "Abc_pqr", Description = "Student" },
                new Users { Name = "Bcd_efg", Description = "Professor" },
                new Users { Name = "Cde_lmn", Description = "Hod" },
                },
                ItemTemplate = new DataTemplate(typeof(NameCell)),
                RowHeight = NameCell.RowHeight
            };
            lstv.ItemTapped += (sender, e) =>
            {
                lstv.SelectedItem = null;
              Navigation.PushAsync(new ViewcellDeatilPage(e.Item as Users));
            };
            Title = "Users";
            Content = lstv;
        }
    }
}
