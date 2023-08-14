namespace swipeview_cv_crash
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			cView.ItemsSource = new List<string>() { "One" };
		}
	}

}
