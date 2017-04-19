using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GS_HotelPro_RoomAssign
{
    public class Staff : INotifyPropertyChanged
    {

        private int _staffId;

        public int StaffId
        {
            get { return _staffId; }
            set
            {
                _staffId = value;
                OnPropertyChanged();
            }
        }


        private string _name;  

        public string  Name 
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }


        private int _inspectorId;

        public int InspectorId
        {
            get { return _inspectorId; }
            set
            {
                _inspectorId = value;
                OnPropertyChanged();
            }
        }

        private bool _IsSelected;

        public bool IsSelected
        {
            get { return _IsSelected; }
            set
            {
                _IsSelected = value;
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
