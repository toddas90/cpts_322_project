using Eto.Drawing;
using Eto.Forms;

namespace ConsoleApp1
{
    public class HelloForm : Form
    {
        public HelloForm()
        {
            Title = "Hello, World!";
            ClientSize = new Size(200, 200);
            Content = new Label {Text = "Hello, World!"};
        }
    }
}