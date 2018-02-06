using Xamarin.Forms;

namespace GwareduBVD
{
    public partial class GwareduBVDPage : MasterDetailPage
    {
        public GwareduBVDPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new CheckListPage());
            IsPresented = false;
        }


        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new CheckListPage());
            IsPresented = false;
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new SettingPage());
            IsPresented = false;
        }
    }
}
