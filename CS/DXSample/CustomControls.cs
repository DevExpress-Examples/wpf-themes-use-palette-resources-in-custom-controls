using System.Windows;
using System.Windows.Controls;

namespace DXSample {
    public class CustomControl1 : Control {
        static CustomControl1() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl1), new FrameworkPropertyMetadata(typeof(CustomControl1)));
        }

        public string Text {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(CustomControl1), new PropertyMetadata(null));
    }
}
