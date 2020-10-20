using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MacroTrackerUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ActionPanel actionPanel;
        RunDate runDate;
        public MainWindow()
        {
            InitializeComponent();
            actionPanel = new NewItemActionPanel(BtnExecuteAction);
            runDate = new RunDate(DateTime.Today.Date, LblRunDate);
        }

        private void ImgAddNewItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("NewItem New()");
            actionPanel = new NewItemActionPanel(BtnExecuteAction);
        }

        private void ImgSearchItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("SearchItem New()");
            actionPanel = new SearchItemActionPanel(BtnExecuteAction);
        }

        private void ImgEditItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("EditItem New()");
            actionPanel = new EditItemActionPanel(BtnExecuteAction);
        }

        private void ImgDeleteItem_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("DeleteItem New()");
            actionPanel = new DeleteItemActionPanel(BtnExecuteAction);
        }

        private void BtnExecuteAction_Click(object sender, RoutedEventArgs e)
        {
            actionPanel.Execute();
        }

        private void ImgPrevRunDate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            runDate.prevDate();
        }

        private void ImgNextRunDate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            runDate.nextDate();
        }
    }
}
