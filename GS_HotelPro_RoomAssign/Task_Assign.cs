using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GS_HotelPro_RoomAssign
{
    public class Task_Assign : INotifyPropertyChanged
    {
        private int _tranid;
        public int tranid
        {
            get { return _tranid; }
            set
            {
                _tranid = value;
                OnPropertyChanged();
            }
        }

        private DateTime _Assign_Date;
        public DateTime Assign_Date
        {
            get { return _Assign_Date; }
            set
            {
                _Assign_Date = value;
                OnPropertyChanged();
            }
        }

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

        private int _room_HK_Status_Id;
        public int room_HK_Status_Id
        {
            get { return _room_HK_Status_Id; }
            set
            {
                _room_HK_Status_Id = value;
                if(assign_RoomList!=null)
                { 
                assign_RoomList.Where(a => a.roomId == roomId).ToList().ForEach(a => a.room_HKStatus_Id = room_HK_Status_Id);
                }
                OnPropertyChanged();
            }
        }

        private int _clean_Type_Id;
        public int clean_Type_Id
        {
            get { return _clean_Type_Id; }
            set
            {
                _clean_Type_Id = value;
                OnPropertyChanged();
            }
        }

        private int _est_Time;
        public int est_Time
        {
            get { return _est_Time; }
            set
            {
                _est_Time = value;
                OnPropertyChanged();
            }
        }

        private int _actual_Time;
        public int actual_Time
        {
            get { return _actual_Time; }
            set
            {
                _actual_Time = value;
                OnPropertyChanged();
            }
        }

        private DateTime _start_Time;
        public DateTime start_Time
        {
            get { return _start_Time; }
            set
            {
                _start_Time = value;
                OnPropertyChanged();
            }
        }

        private DateTime _end_Time;
        public DateTime end_Time
        {
            get { return _end_Time; }
            set
            {
                _end_Time = value;
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

        private DateTime _entry_Date;
        public DateTime entry_Date
        {
            get { return _entry_Date; }
            set
            {
                _entry_Date = value;
                OnPropertyChanged();
            }
        }

        private DateTime _edited_Date;
        public DateTime edited_Date
        {
            get { return _edited_Date; }
            set
            {
                _edited_Date = value;
                OnPropertyChanged();
            }
        }

        private int _entry_UserID;
        public int entry_UserID
        {
            get { return _entry_UserID; }
            set
            {
                _entry_UserID = value;
                OnPropertyChanged();
            }
        }

        private int _edited_UserID;
        public int edited_UserID
        {
            get { return _edited_UserID; }
            set
            {
                _edited_UserID = value;
                OnPropertyChanged();
            }
        }

        private int _room_StatusID;
        public int room_StatusID
        {
            get { return _room_StatusID; }
            set
            {
                _room_StatusID = value;

                

                OnPropertyChanged();
            }
        }

        private string _room_StatusName;
        public string room_StatusName
        {
            get { return _room_StatusName; }
            set
            {
                _room_StatusName = value;
                OnPropertyChanged();
            }
        }

        private int _finished_StatusID;
        public int finished_StatusID
        {
            get { return _finished_StatusID; }
            set
            {
                _finished_StatusID = value;
                OnPropertyChanged();
            }
        }

        private int _hkpId;
        public int hkp_Id
        {
            get { return _hkpId; }
            set
            {
                _hkpId = value;
                OnPropertyChanged();
            }
        }

        private string _hkpName;
        public string hkp_Name
        {
            get { return _hkpName; }
            set
            {
                _hkpName = value;
                OnPropertyChanged();
            }
        }

        private int _InspectorId;
        public int InspectorId
        {
            get { return _InspectorId; }
            set
            {
                _InspectorId = value;
                OnPropertyChanged();
            }
        }

        private string _InspectorName;
        public string InspectorName
        {
            get { return _InspectorName; }
            set
            {
                _InspectorName = value;
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

        #region Compsite Memebers
        private ObservableCollection<Room_HouseKeeping_Status> _room_HouseKeeping_Status;

        public ObservableCollection<Room_HouseKeeping_Status> room_HouseKeeping_Status
        {
            get { return _room_HouseKeeping_Status; }
            set { _room_HouseKeeping_Status = value; }
        }


        private ObservableCollection<Assign_RoomsList> _assign_RoomList;

        public ObservableCollection<Assign_RoomsList> assign_RoomList
        {
            get { return _assign_RoomList; }
            set { _assign_RoomList = value; }
        }


        #endregion



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
    }
}
