namespace _sorting_
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Sort_Button_Clicked(object sender, EventArgs e)
        {
            float[] X = new float[5];

            float.TryParse(X1.Text, out X[0]);
            float.TryParse(X2.Text, out X[1]);
            float.TryParse(X3.Text, out X[2]);
            float.TryParse(X4.Text, out X[3]);
            float.TryParse(X5.Text, out X[4]);

            Array.Sort(X);

            X1.Text = X[0].ToString();
            X2.Text = X[1].ToString();
            X3.Text = X[2].ToString();
            X4.Text = X[3].ToString();
            X5.Text = X[4].ToString();

        }
    }

}
