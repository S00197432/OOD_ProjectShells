using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Xml.Linq;



namespace OOD_ProjectShells
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ComponentsData db = new ComponentsData();

        ObservableCollection<Shell> ShellCurrentList = new ObservableCollection<Shell>();
        ObservableCollection<ShellExamples> EMPshellExample = new ObservableCollection<ShellExamples>();
        ObservableCollection<ShellExamples> FragshellExample = new ObservableCollection<ShellExamples>();
        ObservableCollection<ShellExamples> HEshellExample = new ObservableCollection<ShellExamples>();
        ObservableCollection<ShellExamples> FlakshellExample = new ObservableCollection<ShellExamples>();
        ObservableCollection<ShellExamples> SabotshellExample = new ObservableCollection<ShellExamples>();

        public MainWindow()
        {            
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var query = from c in db.Components
                        select c;

            query.ToString();
            LBOX_ShellComponents.ItemsSource = query.ToList();
            
            LBOX_CurrentShell.ItemsSource = ShellCurrentList;

            //EMP EXAMPLE
            ShellExamples Emp_Head = new ShellExamples("EMP Head");
            ShellExamples Gunpowder_casing = new ShellExamples("Gunpowder Casing");
            ShellExamples Emp_body = new ShellExamples("EMP Body");
           
            EMPshellExample.Add(Emp_Head);         
            EMPshellExample.Add(Emp_body);
            EMPshellExample.Add(Gunpowder_casing);

            //HE EXAMPLE
            ShellExamples he_Head = new ShellExamples("HE Head");          
            ShellExamples he_body = new ShellExamples("HE Body");

            HEshellExample.Add(he_Head);
            HEshellExample.Add(he_body);
            HEshellExample.Add(Gunpowder_casing);

            //FRAG EXAMPLE
            ShellExamples frag_Head = new ShellExamples("Frag Head");           
            ShellExamples frag_body = new ShellExamples("Frag Body");

            FragshellExample.Add(frag_Head);
            FragshellExample.Add(frag_body);
            FragshellExample.Add(Gunpowder_casing);

            //FLAK EXAMPLE
            ShellExamples flak_Head = new ShellExamples("Flak Head");           
            ShellExamples flak_body = new ShellExamples("Flak Body");

            FlakshellExample.Add(flak_Head);          
            FlakshellExample.Add(flak_body);
            FlakshellExample.Add(Gunpowder_casing);

            //SABOT EXAMPLE
            ShellExamples sabot_Head = new ShellExamples("Sabot Head");
            ShellExamples sabot_body = new ShellExamples("Sabot Body");

            SabotshellExample.Add(sabot_Head);
            SabotshellExample.Add(sabot_body);
            SabotshellExample.Add(Gunpowder_casing);

        }

        private void LBOX_ShellComponents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Components selectedComponent = LBOX_ShellComponents.SelectedItem as Components;
            Shell newPart;
            if(selectedComponent == LBOX_ShellComponents.SelectedItem)
            {
                newPart = new Shell( selectedComponent.Component);
                if (newPart != null)
                {
                    ShellCurrentList.Add(newPart);
                }
               
            }
            
        }
        

        private void BTN_Remove_Click(object sender, RoutedEventArgs e)
        {
            Shell SelectedShellPart = LBOX_CurrentShell.SelectedItem as Shell;
            
            if(SelectedShellPart != null)
            {
                ShellCurrentList.Remove(SelectedShellPart);
            }
        }

        private void BTN_Clear_Click(object sender, RoutedEventArgs e)
        {
            ShellCurrentList.Clear();           
        }

        
        public bool shellVisible = false;
        private void BTN_ShellExamples_Click(object sender, RoutedEventArgs e)
        {
            
            if (shellVisible == false)
            {
               TAB_SHELLexamples.Visibility = Visibility.Visible;
                shellVisible = true;
                
            }
            else
            {
                TAB_SHELLexamples.Visibility = Visibility.Hidden;
                shellVisible = false;
            }
            
        }

        private void TB_HEexample_GotFocus(object sender, RoutedEventArgs e)
        {
            LBOX_HEExample.ItemsSource = HEshellExample;
        }
        private void TB_EMPexample_GotFocus(object sender, RoutedEventArgs e)
        {
            LBOX_EMPExample.ItemsSource = EMPshellExample;
        }

        private void TB_FLAKexample_GotFocus(object sender, RoutedEventArgs e)
        {
            LBOX_FLAKExample.ItemsSource = FlakshellExample;
        }

        private void TB_FRAGexample_GotFocus_1(object sender, RoutedEventArgs e)
        {
            LBOX_FRAGExample.ItemsSource = FragshellExample;
        }

        private void TB_SABOTexample_GotFocus_1(object sender, RoutedEventArgs e)
        {
            LBOX_SABOTExample.ItemsSource = SabotshellExample;
        }

        public bool TXTVisible = false;
        private void BTN_Sve_Copy_Click(object sender, RoutedEventArgs e)
        {
            if(TXTVisible == false)
            {

                TXTVID.Visibility = Visibility.Visible;

                TXTVisible = true;
            }
            else
            {
                TXTVID.Visibility = Visibility.Hidden;
                
                TXTVisible = false;
            }
            
          
            
            
        }

       
    }
}
