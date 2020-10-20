using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ActionPanel items are the buttons that allow for adding, searching, editing, and deleting food items

namespace MacroTrackerUI
{
    interface ActionPanel
    {
        void Execute();
        void Render();
        void UnRender();
    }
}
