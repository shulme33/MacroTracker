using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MacroTrackerUI
{
    class EditItemActionPanel : ActionPanel
    {
        private Button actionButton;
        private String actionButtonString;

        public EditItemActionPanel(Button actionButton)
        {
            this.actionButton = actionButton;
            actionButtonString = "Edit Item";
            Render();
        }

        public void Execute()
        {
            Console.WriteLine("Edit Item Execute()");
        }

        public void Render()
        {
            Console.WriteLine("Edit Item Render()");
            actionButton.Content = actionButtonString;
        }

        public void UnRender()
        {
            Console.WriteLine("Edit Item UnRender()");
        }
    }
}
