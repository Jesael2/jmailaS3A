namespace jmailaS3A.Views;

public partial class lista1 : ContentPage
{
	public lista1()
	{
		InitializeComponent();
	}
    string usuariof = " ";
    string contrasenaf = " ";
    public lista1(string usuario, string contrasena)
    {
        InitializeComponent();
        this.usuariof = usuario;
        this.contrasenaf = contrasena;
    }

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        if(txtUsuario.Text == usuariof && txtContrasena.Text == contrasenaf)
        {
            Navigation.PushAsync(new Views.lista2(txtUsuario.Text));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "ok");
        }
		
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.lista3());
    }
}