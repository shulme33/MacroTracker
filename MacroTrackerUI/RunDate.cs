using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MacroTrackerUI
{
    class RunDate
    {
        private DateTime Date { get; set; }
        private System.Windows.Controls.Label runDateLabel;

        public RunDate(DateTime date, System.Windows.Controls.Label runDateLabel)
        {
            this.Date = date;
            this.runDateLabel = runDateLabel;
            updateLabel();
        }

        public DateTime prevDate()
        {
            this.Date = Date.AddDays(-1);
            Console.WriteLine("Prev Date: " + this.Date);
            updateLabel();
            return this.Date;
        }

        public DateTime nextDate()
        {
            this.Date = Date.AddDays(1);
            Console.WriteLine("Next Date: " + this.Date);
            updateLabel();
            return this.Date;
        }

        public void updateLabel()
        {
            runDateLabel.Content = this.Date.Date; ;
        }

    }
}
