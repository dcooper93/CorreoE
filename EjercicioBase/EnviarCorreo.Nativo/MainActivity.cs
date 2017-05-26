using System;
using Android.App;
using Android.Widget;
using Android.OS;
using EnviarCorreo.Nativo.Services;
namespace EnviarCorreo.Nativo

{
    [Activity(Label = "EnviarCorreo.Nativo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity

    {
        Button actionButton;
        string emailBase = "dcarcanoalv@hotmail.com";

        string codeBase = "INICIATIVA";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            actionButton = FindViewById<Button>(Resource.Id.btnReportar);
            actionButton.Click += btnReportar_Click;
        }

        private async void btnReportar_Click(object sender, EventArgs e)
        {
            ServiceHelper serviceHelper = new ServiceHelper();

            if (emailBase == "dcarcanoalv@hotmail.com" || codeBase == "INICIATIVA")
            {


            }
            actionButton.Enabled = false;
            await serviceHelper.InsertarEntidad("dcarcanoalv@hotmail.com", "INICIATIVA");

            actionButton.Text = "Tu reporte ha sido enviado";


            Toast.MakeText(this, "HEY! tienes un correo nuevo!!", ToastLength.Short).Show();
        }
    }
}