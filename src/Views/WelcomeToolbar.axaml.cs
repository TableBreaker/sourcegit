using Avalonia.Controls;
using Avalonia.Interactivity;

namespace SourceGit.Views
{
    public partial class WelcomeToolbar : UserControl
    {
        public WelcomeToolbar()
        {
            InitializeComponent();
        }

        private void ToggleToolbarLabels(object sender, RoutedEventArgs e)
        {
            var pref = ViewModels.Preferences.Instance;
            pref.ShowToolbarLabels = !pref.ShowToolbarLabels;
            e.Handled = true;
        }
    }
}
