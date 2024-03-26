using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabbed_pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Aprill : ContentPage
	{
		public Aprill ()
		{
			InitializeComponent ();
            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            Label lbl = new Label { Text = "Aprill", FontSize = 36, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand };
            Image img = new Image { Source = "aprill.jpg", Margin = 20 };
            Label kirjeldus = new Label { Text = "Aprill on neljas aasta kuu!)!)!) \n Teine kevade kuu!!)!))", FontSize = 24, VerticalOptions = LayoutOptions.CenterAndExpand, HorizontalOptions = LayoutOptions.CenterAndExpand };
            grid.Children.Add(lbl, 0, 0);
            grid.Children.Add(img, 0, 1);
            grid.Children.Add(kirjeldus, 0, 2);
            this.Content = grid;
        }
	}
}