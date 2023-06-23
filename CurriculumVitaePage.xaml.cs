using Xamarin.Forms;

namespace FormApp
{
    public partial class CurriculumVitaePage : ContentPage
    {
        public string NombresApellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ocupacion { get; set; }
        public string Aptitudes { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroCelular { get; set; }

        public CurriculumVitaePage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
