using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PocSaveTxtUsb
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public string SdFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //public string SdFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        //public string SdFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        //Write Information to a Local File
        public void WriteLocalFile(string FileName, string Data)
        {
            string filePath = Path.Combine(SdFolderPath, FileName);
            File.WriteAllText(filePath, Data);
        }
        //Load Information from a Local File
        //public string LoadLocalFile(string FileName)
        //{
        //    string filePath = Path.Combine(PersonalFolderPath, FileName);
        //    if (File.Exists(filePath))
        //    {
        //        showtext.Text = File.ReadAllText(filePath);
        //        return showtext.Text;
        //    }
        //    return null;
        //}

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            WriteLocalFile("SaveToSd.txt", CommentaryEditor.Text);
        }

        //private void LoadButton_Clicked(object sender, EventArgs e)
        //{
        //    LoadLocalFile("Burak.txt");
        //}
    }
}
