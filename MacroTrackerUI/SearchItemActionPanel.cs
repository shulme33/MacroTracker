using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MacroTrackerUI
{
    class SearchItemActionPanel : ActionPanel
    {

        private Button actionButton;
        private String actionButtonString;

        public SearchItemActionPanel(Button actionButton)
        {
            this.actionButton = actionButton;
            actionButtonString = "Search Item";
            Render();
        }
        public void Execute()
        {
            Console.WriteLine("Search Item Execute()");
        }

        public void Render()
        {
            Console.WriteLine("Search Item Render()");
            actionButton.Content = actionButtonString;
        }

        public void UnRender()
        {
            Console.WriteLine("Search Item UnRender()");
        }
    }
}
