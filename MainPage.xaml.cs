using KimTerrence_Activity2.resource;

namespace KimTerrence_Activity2
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        public void handleSubmit(object s, EventArgs e)
        {
            String fullname = fname.Text;
            String college = col.Text;

            NewPage n = new NewPage();
            n.diplayData(collected.name, collected.col);
        }
    }

}
