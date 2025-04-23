namespace jmailaS3A.Views;

public partial class lista2 : ContentPage
{
	public lista2(string usuario)
	{
		InitializeComponent();
		lblUsuario.Text = "USUARIO CONECTADO"+usuario;
	}

    private void btnAbrir_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Views.lista3());
    }
}