using System.ComponentModel;

namespace ChatBox
{
    class Usuario : INotifyPropertyChanged
    {

        string _imagen, _nombreUsuario, _textoAEnviar;

        public string Imagen
        {
            get { return _imagen; }
            set
            {
                if (_imagen != value)
                {
                    _imagen = value;
                    NotifyPropertyChanged(Imagen);
                }
            }
        }

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set
            {
                if (_nombreUsuario != value)
                {
                    _nombreUsuario = value;
                    NotifyPropertyChanged(NombreUsuario);
                }
            }
        }

        public string TextoAEnviar
        {
            get { return _textoAEnviar; }
            set
            {
                if (_textoAEnviar != value)
                {
                    _textoAEnviar = value;
                    NotifyPropertyChanged(TextoAEnviar);
                }
            }
        }

        public Usuario(string imagen, string nombreUsuario, string textoAEnviar)
        {
            Imagen = imagen;
            NombreUsuario = nombreUsuario;
            TextoAEnviar = textoAEnviar;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
