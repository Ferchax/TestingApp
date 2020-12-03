using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Models;
using TestingApp.Services;
using Xamarin.Forms;

namespace TestingApp.ViewModels
{
    public class UsuariosViewModel : BaseViewModel
    {
        public UsuariosViewModel()
        {
            GetUsuariosCommand = new Command(async () => await GetUsuarios(), () => !isBusyGetUsuariosCommand);
        }

        private WebApiClientService webApi = new WebApiClientService();

        public Command GetUsuariosCommand { get; }

        private bool isBusyGetUsuariosCommand;
        public bool IsBusyGetUsuariosCommand
        {
            get => isBusyGetUsuariosCommand;
            set 
            { 
                isBusyGetUsuariosCommand = value;
                OnPropertyChanged();
                GetUsuariosCommand.ChangeCanExecute();
            }
        }

        private ObservableCollection<Usuario> usuarios;
        public ObservableCollection<Usuario> Usuarios
        {
            get => usuarios;
            set 
            { 
                usuarios = value;
                OnPropertyChanged();
            }
        }

        private async Task GetUsuarios()
        {
            IsBusyGetUsuariosCommand = true;

            Usuarios = await webApi.Get<ObservableCollection<Usuario>>();

            IsBusyGetUsuariosCommand = false;
        }
    }
}
