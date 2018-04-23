using System.Windows.Input;
using DevExpress.Xpf.Gauges;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace DXGauges_Show_Tooltips {
    public partial class MainPage : UserControl {
        public MainPage() {

            InitializeComponent();
        }

        private void circularGaugeControl1_MouseMove(object sender, MouseEventArgs e) {
            Point position = e.GetPosition(circularGaugeControl1);

            CircularGaugeHitInfo hitInfo =
              circularGaugeControl1.CalcHitInfo(position);

            if (hitInfo.InNeedle) {
                tooltip_text.Text = "Value: " + hitInfo.Needle.Value.ToString("n2");
                tooltip.HorizontalOffset = position.X;
                tooltip.VerticalOffset = position.Y;

                tooltip.IsOpen = true;
            }
            else {
                tooltip.IsOpen = false;
            }

        }

        private void circularGaugeControl1_MouseLeave(object sender, MouseEventArgs e) {
            tooltip.IsOpen = false;
        }

    }
}

