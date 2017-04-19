using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GS_HotelPro_RoomAssign
{
    public class Room_HouseKeeping_Status : INotifyPropertyChanged
    {
        private int _room_HKStatus_ID;

        public int Room_HKStatus_ID
        {
            get
            {
                return _room_HKStatus_ID;
            }
            set
            {
                _room_HKStatus_ID = value;
                OnPropertyChanged();
            }
        }

        private string _room_HouseKeeping_Name;

        public string Room_HouseKeeping_Name
        {
            get
            {
                return _room_HouseKeeping_Name;
            }
            set
            {
                _room_HouseKeeping_Name = value;
                OnPropertyChanged();
            }
        }


        private int _finalStatus;

        public int FinalStatus
        {
            get
            {
                return _finalStatus;
            }
            set
            {
                _finalStatus = value;
                OnPropertyChanged();
            }
        }

        private bool _IsSelected;

        public bool IsSelected
        {
            get
            {
                return _IsSelected;
            }
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
