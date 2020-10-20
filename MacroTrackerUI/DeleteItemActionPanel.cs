using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MacroTrackerUI
{
    class DeleteItemActionPanel : ActionPanel
    {
        private Button actionButton;
        private String actionButtonString;

        public DeleteItemActionPanel(Button actionButton)
        {
            this.actionButton = actionButton;
            actionButtonString = "Delete Item";
            Render();
        }

        public void Execute()
        {
            Console.WriteLine("Delete Item Execute()");
        }

        public void Render()
        {
            Console.WriteLine("Delete Item Render()");
            actionButton.Content = actionButtonString;
        }

        public void UnRender()
        {
            Console.WriteLine("Delete Item UnRender()");
        }
    }
}
