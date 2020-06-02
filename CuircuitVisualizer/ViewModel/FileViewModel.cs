using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuircuitVisualizer.ViewModel
{
    public class FileViewModel : ViewModelBase
    {
        public string FileName { get; set; }

        public FileViewModel(string _name)
        {
            FileName = _name; 
        }
    }
}
    