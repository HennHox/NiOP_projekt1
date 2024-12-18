namespace dotnetmaui
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            Lista.ItemsSource = new List<Podatci>
            {
                new Podatci ("NiOP","programiranje","csharp.png"),
                new Podatci ("PMU", "programiranje", "xaml.png")
            };
        }

        

        private async void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Podatci item = (Podatci)e.Item;
            await DisplayAlert("HI", item.Ime + "je moj predmet", "OK");

        }
    }

}
