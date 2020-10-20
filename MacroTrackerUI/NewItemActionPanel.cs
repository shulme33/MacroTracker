using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MacroTrackerUI
{
    class NewItemActionPanel : ActionPanel
    {

        private Button actionButton;
        private String actionButtonString;

        public NewItemActionPanel(Button actionButton)
        {
            this.actionButton = actionButton;
            actionButtonString = "Add Item";
            Render();
        }

        public void Execute()
        {
            Console.WriteLine("New Item Execute()");
        }

        public void Render()
        {
            Console.WriteLine("New Item Render()");
            actionButton.Content = actionButtonString;
        }

        public void UnRender()
        {
            Console.WriteLine("New Item UnRender()");
        }
    }
}
