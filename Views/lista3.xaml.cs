namespace jmailaS3A.Views;

public partial class lista3 : ContentPage
{
	public lista3()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		string usuarioc = txtUsuario.Text;
		string contrasenac = txtContrasena.Text;

		DisplayAlert("Alerta", "Usuario Almacenado", "ok");
		Navigation.PushAsync(new Views.lista1(usuarioc, contrasenac));
    }
}