using System.Windows;

namespace Elmish.WPF.Samples.SubModelSeq {
  public partial class MainWindow : Window {
    public MainWindow() {
      /* This next line is needed to prevent a runtime exception
      * 'Could not load file or assembly 'Microsoft.Xaml.Behaviors...'
      * See https://github.com/microsoft/XamlBehaviorsWpf/issues/86
      */
      _ = new Microsoft.Xaml.Behaviors.EventTrigger {
        SourceName = "foo"
      };
      InitializeComponent();
    }
  }
}
