using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GS_HotelPro_RoomAssign
{
    public class Clean_Type : INotifyPropertyChanged
    {

        private int _clean_TypeId;

        public int clean_TypeId
        {
            get { return _clean_TypeId; }
            set
            {
                _clean_TypeId = value;
                OnPropertyChanged();
            }
        }

        private string _clean_TypeName;

        public string clean_TypeName
        {
            get { return _clean_TypeName; }
            set
            {
                _clean_TypeName = value;
                OnPropertyChanged();
            }
        }

        private string _short;

        public string Short_Name 
        {
            get { return _short; }
            set
            {
                _short = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
    }
}
