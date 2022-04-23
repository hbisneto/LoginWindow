using System.Diagnostics;
using System.Numerics;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LoginWindow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        // NOTE: The rectangle scales up and down using the same element_PointerEntered/Exited events as the prior sample.
        // Set up the relationship between the rectangle and the ellipse.
        private void HoverUser1(object sender, RoutedEventArgs e)
        {
            Compositor _compositor = Window.Current.Compositor;

            var expressionAnim = _compositor.CreateExpressionAnimation();

            // The ellipse's scale is inversely proportional to the rectangle's scale
            expressionAnim.Expression = "Vector3(1/scaleElement.Scale.X, 1/scaleElement.Scale.Y, 1)";
            expressionAnim.Target = "Scale";

            // Use SetExpressionReferenceParameter to alias a UIElement into the expression string
            expressionAnim.SetExpressionReferenceParameter("scaleElement", ElUser1);

            // Start the animation on the ellipse
            ElUser2.StartAnimation(expressionAnim);
        }

        private void HoverUser2(object sender, RoutedEventArgs e)
        {
            Compositor _compositor = Window.Current.Compositor;

            var expressionAnim = _compositor.CreateExpressionAnimation();

            // The ellipse's scale is inversely proportional to the rectangle's scale
            expressionAnim.Expression = "Vector3(1/scaleElement.Scale.X, 1/scaleElement.Scale.Y, 1)";
            expressionAnim.Target = "Scale";

            // Use SetExpressionReferenceParameter to alias a UIElement into the expression string
            expressionAnim.SetExpressionReferenceParameter("scaleElement", ElUser2);

            // Start the animation on the ellipse
            ElUser1.StartAnimation(expressionAnim);
        }

        private void ElUser1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            HoverUser1(sender, e);
            ElUser1.Scale = new Vector3((float)1.2, (float)1.2, (float)1.2);
            User1Selection.Scale = new Vector3((float)1.2, (float)1.2, (float)1.2);
        }
        private void ElUser1_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (User1Selection.Visibility == Visibility.Collapsed)
            {
                ElUser1.Scale = new Vector3(1, 1, 1);
                User1Selection.Scale = new Vector3(1, 1, 1);
            }
        }
        private void ElUser1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            User1Selection.Visibility = Visibility.Visible;
            UserPicker.SelectedIndex = 1;
        }

        private void User1Selection_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ElUser1.Scale = new Vector3(1, 1, 1);
            User1Selection.Scale = new Vector3(1, 1, 1);
            User1Selection.Visibility = Visibility.Collapsed;
        }

        private void ElUser2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            HoverUser2(sender, e);
            ElUser2.Scale = new Vector3((float)1.2, (float)1.2, (float)1.2);
            User2Selection.Scale = new Vector3((float)1.2, (float)1.2, (float)1.2);
        }

        private void ElUser2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            if (User2Selection.Visibility == Visibility.Collapsed)
            {
                ElUser2.Scale = new Vector3(1, 1, 1);
                User2Selection.Scale = new Vector3(1, 1, 1);
            }
        }

        private void ElUser2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            User2Selection.Visibility = Visibility.Visible;
        }

        private void User2Selection_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            ElUser2.Scale = new Vector3(1, 1, 1);
            User2Selection.Scale = new Vector3(1, 1, 1); 
            User2Selection.Visibility = Visibility.Collapsed;
        }



        // Menus Inferiores

        private void Menu1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Menu1Hover.Visibility = Visibility.Visible;
        }

        private void Menu1Hover_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Menu1Hover.Visibility= Visibility.Collapsed;
        }

        private void Menu2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Menu2Hover.Visibility = Visibility.Visible;
        }

        private void Menu2Hover_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Menu2Hover.Visibility = Visibility.Collapsed;
        }

        private void Menu3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Menu3Hover.Visibility = Visibility.Visible;
        }

        private void Menu3Hover_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Menu3Hover.Visibility = Visibility.Collapsed;
        }
    }
}
