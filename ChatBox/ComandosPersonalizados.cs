using System.Windows.Input;

namespace ChatBox
{
    public static class ComandosPersonalizados
    {
        public static readonly RoutedUICommand Enter = new RoutedUICommand
            (
                "Enter",
                "Intro",
                typeof(ComandosPersonalizados),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.Enter, ModifierKeys.None)
                }
            );

        public static readonly RoutedUICommand Exit = new RoutedUICommand
            (
                "Exit",
                "Salir",
                typeof(ComandosPersonalizados),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.X, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand CheckInternet = new RoutedUICommand
            (
                "Check",
                "Comprobar",
                typeof(ComandosPersonalizados),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.O, ModifierKeys.Control)
                }
            );

        public static readonly RoutedUICommand Configure = new RoutedUICommand
            (
                "Confi",
                "Configurar",
                typeof(ComandosPersonalizados),
                new InputGestureCollection()
                {
                    new KeyGesture(Key.C, ModifierKeys.Control)
                }
            );
    }
}
