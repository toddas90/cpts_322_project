using System;
using Eto.Forms;
using Eto.Drawing;
using System.Text.RegularExpressions;

namespace cpts_322_project
{
    public partial class MainForm : Form
    {
        public event EventHandler<EventArgs> Click;
        DataStoreCollection<String> dropData = new DataStoreCollection<String>();

        public MainForm()
        {
            Title = "RegBasic";
            MinimumSize = new Size(800, 800);

            dropData.Add("C# Regex");
            dropData.Add("Test");

            TextBox regex = new TextBox
            {
                PlaceholderText = "Enter Regex",
                Size = new Size(780, 100),
            };
            TextBox userString = new TextBox
            {
                PlaceholderText = "Enter String",
                Size = new Size(780, 100),
            };
            Button checkRegex = new Button
            {
                Text = "Evaluate"
            };
			CheckBox match = new CheckBox
			{
			};
            DropDown flavors = new DropDown();

            flavors.DataStore = dropData;
            flavors.SelectedIndex = 0;
			
            Content = new StackLayout
            {
                Padding = 10,
                Items =
                {
                    flavors,
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
                ConvertToRegex reg = new ConvertToRegex(regex.Text);
                var r = reg.getRegex();
				var s = userString.Text;
				if (r.IsMatch(s)) {
					match.Checked = true;
				} else {
					match.Checked = false;
				}
			});

            flavors.SelectedIndexChanged += new EventHandler<EventArgs>((args, sender) => {
                // Dropdown Click event goes here
                // Could maybe use a different event, I just picked SelectedIndex just because
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
