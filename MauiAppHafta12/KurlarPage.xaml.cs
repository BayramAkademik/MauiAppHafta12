namespace MauiAppHafta12;

public partial class KurlarPage : ContentPage
{
	public KurlarPage()
	{
		InitializeComponent();

	}

	List<Servisler.KurData> Kurlar = null;
    private async void KurlariGuncelle(object sender, EventArgs e)
    {
		Kurlar = await Servisler.KurServis.GetKurlar();
        lstKurlar.ItemsSource = Kurlar;
        refreshView.IsRefreshing = false;
    }
}