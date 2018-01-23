using Xamarin.Forms;

namespace SlideOutApp
{
    public class NameCell: ViewCell
    {
        public const int RowHeight = 55;
        public NameCell()
        {
            var nameLabel = new Label { FontAttributes = FontAttributes.Bold };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            var descriptionLabel = new Label { TextColor = Color.Gray };
            descriptionLabel.SetBinding(Label.TextProperty, "Description");

            View = new StackLayout
            {
                Spacing = 2,
                Padding = 5,
                Children = {
                nameLabel,
                descriptionLabel,
            },
            };
        }
    }
}