using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GS_HotelPro_RoomAssign
{
    public class Assign_RoomsList : INotifyPropertyChanged
    {
        private int _roomId;

        public int roomId
        {
            get { return _roomId; }
            set
            {
                _roomId = value;
                OnPropertyChanged();
            }
        }

        private string _roomNo;

        public string roomNo
        {
            get { return _roomNo; }
            set
            {
                _roomNo = value;
                OnPropertyChanged();
            }
        }


        private string _roomName;
        public string roomName
        {
            get { return _roomName; }
            set
            {
                _roomName = value;
                OnPropertyChanged();
            }
        }

        private int _roomTypeId;
        public int roomTypeId
        {
            get { return _roomTypeId; }
            set
            {
                _roomTypeId = value;
                OnPropertyChanged();
            }
        }

        private string _roomTypeName;
        public string roomTypeName
        {
            get { return _roomTypeName; }
            set
            {
                _roomTypeName = value;
                OnPropertyChanged();
            }
        }

        private int _room_HKStatus_Id;
        public int room_HKStatus_Id
        {
            get { return _room_HKStatus_Id; }
            set
            {
                _room_HKStatus_Id = value;
                OnPropertyChanged();
            }
        }

        private int _room_HouseKeeping_Name;
        public int room_HouseKeeping_Name
        {
            get { return _room_HouseKeeping_Name; }
            set
            {
                _room_HouseKeeping_Name = value;
                OnPropertyChanged();
            }
        }

        private string _occupancy_status;
        public string occupancy_status
        {
            get { return _occupancy_status; }
            set
            {
                _occupancy_status = value;
                OnPropertyChanged();
            }
        }

        private int _floor_type;
        public int floor_type
        {
            get { return _floor_type; }
            set
            {
                _floor_type = value;
                OnPropertyChanged();
            }
        }

        private string _floor_Name;
        public string floor_Name    
        {
            get { return _floor_Name; }
            set
            {
                _floor_Name = value;
                OnPropertyChanged();
            }
        }

        private string _remark;
        public string remark
        {
            get { return _remark; }
            set
            {
                _remark = value;
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
