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
using System.Windows.Shapes;
using ToDo.Model.Enum;
using ToDo.Model.EntryTypes;
using ToDo.Model;
using ToDo.Controller;

namespace ToDo
{
    /// <summary>
    /// Interaction logic for DetailEntryWindow.xaml
    /// </summary>
    public partial class DetailEntryWindow : Window
    {
        private Entry? CurrentEntry = new NoteEntry();
        
        public DetailEntryWindow(Entry currentEntry)
        {
            InitializeComponent();
            CurrentEntry = currentEntry;
            InitializeComboBoxes();
            LoadValues();
        }

        public DetailEntryWindow()
        {
            InitializeComponent();
            InitializeComboBoxes();
            LoadValues();
        }

        private void InitializeComboBoxes()
        {
            for(int i = 0; i < EnumExtension.GetAllNames<Typ>().Count; i++)
            CmbType.Items.Add(EnumExtension.GetAllNames<Typ>()[i]);
            CmbType.SelectedIndex = 0;
            
            for(int i = 0; i < EnumExtension.GetAllNames<Priority>().Count; i++)
                CmbToDoPriority.Items.Add(EnumExtension.GetAllNames<Priority>()[i]);
            
            for(int i = 0; i < EnumExtension.GetAllNames<Difficulty>().Count; i++)
                CmbToDoDifficulty.Items.Add(EnumExtension.GetAllNames<Difficulty>()[i]);
        }

        private void LoadValues()
        {
            TbxPath.Text = DataHandler.RootPath + CurrentEntry.Path;
            TbxTagName1.Text = CurrentEntry.GetTagStr(0);
            TbxTagName2.Text = CurrentEntry.GetTagStr(1);
            TbxTagName3.Text = CurrentEntry.GetTagStr(2);
        }
    }
}
