using System;
using Eto.Forms;
using Eto.Drawing;
using System.Text.RegularExpressions;

namespace cpts_322_project
{
    public partial class MainForm : Form
    {
        public event EventHandler<EventArgs> Click;
        public MainForm()
        {
            Title = "RegBasic";
            MinimumSize = new Size(800, 800);

            TextBox regex = new TextBox
            {
                PlaceholderText = "Enter Regex",
                Size = new Size(780, -1),
            };
            TextBox userString = new TextBox
            {
                PlaceholderText = "Enter String",
                Size = new Size(780, -1),
            };
            Button checkRegex = new Button
            {
                Text = "Evaluate"
            };
			CheckBox match = new CheckBox
			{
			};
			
            Content = new StackLayout
            {
                Padding = 10,
                Items =
                {
                    userString,
					regex,
                    checkRegex,
					match,
				}
            };

            // create a few commands that can be used for the menu and toolbar
            var quitCommand = new Command { MenuText = "Quit", Shortcut = Application.Instance.CommonModifier | Keys.Q };
            quitCommand.Executed += (sender, e) => Application.Instance.Quit();

            var aboutCommand = new Command { MenuText = "About..." };
            aboutCommand.Executed += (sender, e) => new AboutDialog().ShowDialog(this);

            checkRegex.Click += new EventHandler<EventArgs>((args, sender) => {
				var r = new Regex(regex.Text);
				var s = userString.Text;
				if (r.IsMatch(s)) {
					match.Checked = true;
				} else {
					match.Checked = false;
				}
			});

            // create menu
            Menu = new MenuBar
            {
                Items =
                {
					// File submenu
					new ButtonMenuItem { Text = "&File", Items = { } },
					// new ButtonMenuItem { Text = "&Edit", Items = { /* commands/items */ } },
					// new ButtonMenuItem { Text = "&View", Items = { /* commands/items */ } },
				},
            
                QuitItem = quitCommand,
                AboutItem = aboutCommand
            };

        }

    }
}
