using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WorkingWithCashe
{
    /// <summary>
    /// Логика взаимодействия для AnotherWindows.xaml
    /// </summary>
    public partial class AnotherWindows : Window
    {
        public class PersonalSettings {
            public string FirstSetting { get; set; }
            public string SecondSetting { get; set; }

}
        public AnotherWindows()
        {
            InitializeComponent();
            AddressBook.Items.Add(new AdressBookData { Name = "Lezin Konstantin", PhoneNumber = "+7(921) 396-75-86" });
            
        }

        private void SaveData_Click(object sender, RoutedEventArgs e)
        {



            /*DataTable dt = new DataTable("xmlTable");

            dt = DataGridtoDataTable(AddressBook);
            dt.TableName = "xmlTable";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            sfd.ShowDialog();
            dt.WriteXml(sfd.FileName);*/

            var _PerSett = new PersonalSettings()
            {

                FirstSetting = "First setting Value",
                SecondSetting = "Second setting Value"

            };
            

            SaveFileDialog sfd2 = new SaveFileDialog();
            sfd2.Filter = "XML|*.xml";
            sfd2.ShowDialog();
           

            XmlSerializer writer = new XmlSerializer(_PerSett.GetType());
            StreamWriter file = new StreamWriter(sfd2.FileName);
            writer.Serialize(file, _PerSett);
            file.Close();

          





        }

        public static DataTable DataGridtoDataTable(DataGrid dg)
        {
            dg.SelectAllCells();
            dg.ClipboardCopyMode =DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, dg);
            dg.UnselectAllCells();
            String result = (string)Clipboard.GetData(DataFormats.CommaSeparatedValue);
            string[] Lines = result.Split(new string[] { "\r\n", "\n" },
            StringSplitOptions.None);
            string[] Fields;
            Fields = Lines[0].Split(new char[] { ',' });
            int Cols = Fields.GetLength(0);
            DataTable dt = new DataTable();
            //1st row must be column names; force lower case to ensure matching later on.
            for (int i = 0; i < Cols; i++)
                dt.Columns.Add(Fields[i].ToUpper(), typeof(string));
            DataRow Row;
            for (int i = 1; i < Lines.GetLength(0) - 1; i++)
            {
                Fields = Lines[i].Split(new char[] { ',' });
                Row = dt.NewRow();
                for (int f = 0; f < Cols; f++)
                {
                    Row[f] = Fields[f];
                }
                dt.Rows.Add(Row);
            }
            return dt;

        }



        public class AdressBookData
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
}
