using System.Collections.ObjectModel;
using GothicModComposer.UI.Helpers;

namespace GothicModComposer.UI.Models
{
    public class GothicVdfsConfig : ObservableVM
    {
        private string _fileName;
        private ObservableCollection<string> _directories;
        private ObservableCollection<string> _include;
        private ObservableCollection<string> _exclude;
        private string _comment;
        
        public string Filename
        {
            get => _fileName;
            set => SetProperty(ref _fileName, value);
        }
        
        public ObservableCollection<string> Directories
        {
            get => _directories;
            set => SetProperty(ref _directories, value);
        }
        
        public ObservableCollection<string> Include
        {
            get => _include;
            set => SetProperty(ref _include, value);
        }
        
        public ObservableCollection<string> Exclude
        {
            get => _exclude;
            set => SetProperty(ref _exclude, value);
        }
        
        public string Comment
        {
            get => _comment;
            set => SetProperty(ref _comment, value);
        }
    }
}