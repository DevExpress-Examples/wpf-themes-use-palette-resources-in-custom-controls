using DevExpress.Xpf.Core;

namespace DXSample {
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void comboBoxEdit1_EditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e) {
            ApplicationThemeHelper.ApplicationThemeName = e.NewValue as string;
        }
    }
}
