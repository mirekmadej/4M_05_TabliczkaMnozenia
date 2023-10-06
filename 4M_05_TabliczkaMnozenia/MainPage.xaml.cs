namespace _4M_05_TabliczkaMnozenia
{
    public partial class MainPage : ContentPage
    {
        private string s = "1";

        public MainPage()
        {
            InitializeComponent();
        }
        
        private void btnResetClicked(object sender, EventArgs e)
        {
            s= "1";
            lblTabliczka.Text = s;
            SemanticScreenReader.Announce(lblTabliczka.Text);
        }
        private int maks = 0;
        private string zamienNaString(int i, int j)
        {
            string k = (i*j).ToString();
            int start = k.Length;
            int stop = maks.ToString().Length;
            for (int a = start; a <= stop; a++)
                k = " " + k;
            return k + " ";
        }
        private void btnGenerujClicked(object sender, EventArgs e)
        {
            s = "";
            int n = int.Parse(entRozmiar.Text);
            maks = n * n;
            for(int i=1; i<=n; i++)
            {
                for (int j = 1; j <= n; j++)
                    s += zamienNaString(i,j);
                s += "\n";
            }
            lblTabliczka.Text = s;
            SemanticScreenReader.Announce(lblTabliczka.Text);
        }

    }
}