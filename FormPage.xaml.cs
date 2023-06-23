using Xamarin.Forms;

namespace FormApp
{
    public partial class FormPage : ContentPage
    {
        public FormPage()
        {
            InitializeComponent();
        }

        private async void Enviar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                dpFechaNacimiento.Date == default ||
                string.IsNullOrWhiteSpace(txtOcupacion.Text) ||
                string.IsNullOrWhiteSpace(txtAptitudes.Text) ||
                string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                string.IsNullOrWhiteSpace(txtNumeroCelular.Text))
            {
                await DisplayAlert("Error", "Debes completar todos los campos", "Aceptar");
            }
            else if (!IsValidEmail(txtCorreoElectronico.Text))
            {
                await DisplayAlert("Error", "Ingresa un correo electrónico válido", "Aceptar");
            }
            else
            {
                // Curriculum Vitae 
                var cvPage = new CurriculumVitaePage
                {
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text,
                    FechaNacimiento = dpFechaNacimiento.Date,
                    Ocupacion = txtOcupacion.Text,
                    Aptitudes = txtAptitudes.Text,
                    CorreoElectronico = txtCorreoElectronico.Text,
                    NumeroCelular = txtNumeroCelular.Text
                };
                await Navigation.PushAsync(cvPage);
            }
        }

        private bool IsValidEmail(string email)
        {
           //validacion c.e
            return Regex.IsMatch(email, @"^\S+@\S+\.\S+$");
        }
    }
}
