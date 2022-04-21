namespace NetMauiZIndex
{
    public class ViewModel
    {
        private static int Zindex = 10;
        private Command bringToFront;

        public Command BringToFront
        {
            get { return bringToFront; }
            set { bringToFront = value; }
        }
        public ViewModel()
        {
            bringToFront = new Command<object>(OnBringToFrontAsync);            
        }

        private async void OnBringToFrontAsync(object view)
        {
            var viewName = (view as Label).Text;
            bool answer = await Application.Current.MainPage.DisplayAlert("Bring to front", "I am "+viewName + " , " + "Shall i move to front ?", "Yes", "No");
            if (answer)
            {
                (view as Label).ZIndex = Zindex;
                Zindex += 1;
            }
        }
    }
}
