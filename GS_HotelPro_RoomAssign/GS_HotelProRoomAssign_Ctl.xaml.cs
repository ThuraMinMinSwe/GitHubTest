using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GS_HotelPro_RoomAssign
{
    /// <summary>
    /// Interaction logic for CustomRoomAssign.xaml
    /// </summary>
    public partial class CustomRoomAssign : UserControl,INotifyPropertyChanged
    {

        public delegate void Custom_EventHandler(object sender, Custom_EventArgs args);

        public event Custom_EventHandler OnButtonClick;

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Task_Assign> _Task_Assign;
        public ObservableCollection<Task_Assign> Task_Assign
        {
            get { return _Task_Assign; }
            set { _Task_Assign = value; }
        }

        public static ObservableCollection<Task_Assign> CurrentItemList;


        private ObservableCollection<Task_Assign> _CurrentItem;
        public ObservableCollection<Task_Assign> CurrentItem
        {
            get { return _CurrentItem; }
            set
            {
                _CurrentItem = value;
                CurrentItem.CollectionChanged += CurrentItem_CollectionChanged;
            }
        }

        

        public CustomRoomAssign()
        {
            InitializeComponent();
            this.DataContext = this;
            CurrentItemList = new ObservableCollection<GS_HotelPro_RoomAssign.Task_Assign>();
            
            

        }

        private void CurrentItem_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if(CurrentItem.Count>0)
            { 
            CurrentItem[0].room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
            CurrentItem[0].room_HouseKeeping_Status = room_HouseKeeping_Status;
            }
        }

        public Control GetCustomRoomAssign(CustomRoomAssign Data)
        {
        
            this.roomName = Data.roomName;
            return this;
        }


        private void ButtonClicked(object sender , RoutedEventArgs e)
        {


            

            this.CurrentItem.Clear();
            this.CurrentItem.Add(CustomRoomAssign.CurrentItemList.FirstOrDefault());
            Custom_EventArgs args = new Custom_EventArgs(CurrentItem[0]);
            FilterFlyOut.IsOpen = true;

            //MahApps.Metro.Controls.Flyout flyout = new MahApps.Metro.Controls.Flyout();
            //flyout.Header = "Test";
            //flyout.IsOpen = true;
            //flyouts.IsOpen = true;

            if (OnButtonClick!=null)
            { OnButtonClick(sender, args); }
        }


   #region      Field Definition

        private int _tranid;
        public int Tranid    
        {
            get { return _tranid; }
            set
            {
                _tranid = value;
                OnPropertyChanged();
            }
        }

        private string _hkpname;

        public string hkpname
        {
            get { return _hkpname; }
            set
            {
                _hkpname = value;
                OnPropertyChanged();
            }
        }


        private int _hkpId;
        public int hkpId
        {
            get { return _hkpId; }
            set
            {
                _hkpId = value;
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


        private string _Inspectorname;
        public string Inspectorname
        {
            get { return _Inspectorname; }
            set
            {
                _Inspectorname = value;
                OnPropertyChanged();
            }
        }

        private string _roomname;
        public string roomName
        {
            get { return _roomname; }
            set
            {
                _roomname = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Room_HouseKeeping_Status> _room_HouseKeeping_Status;

        public ObservableCollection<Room_HouseKeeping_Status> room_HouseKeeping_Status
        {
            get { return _room_HouseKeeping_Status; }
            set { _room_HouseKeeping_Status = value; }
        }

        #endregion
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            { PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); }
        }
    }


    public class CurrentItemConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if(values[0] != null)
            { 
            CustomRoomAssign.CurrentItemList = new ObservableCollection<Task_Assign>();
            CustomRoomAssign.CurrentItemList.Add(((ObservableCollection<Task_Assign>)values[1]).Where(a => a.roomNo == values[0].ToString()).FirstOrDefault());
                //((ObservableCollection<Task_Assign>)values[1]).ToList().Where(x => x.roomNo != CustomRoomAssign.CurrentItem[0].roomNo).ToList().ForEach(x => x.IsSelected = false);
            }
            return values[0];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CleanStatusColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {


            SolidColorBrush color = new SolidColorBrush();
            switch (int.Parse(value.ToString()))
            {
                case 0:
                    color.Color = Colors.Red;
                    break;
                case 1:
                    color.Color = Colors.Green;
                    break;
                case 2:
                    color.Color = Colors.Yellow;
                    break;
                default:
                    color.Color = Colors.Blue;
                    break;
            }

            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class Custom_EventArgs : EventArgs
    {
        public Task_Assign _CurrentData { get; set; }
        public Custom_EventArgs(Task_Assign EventArgs)
        {
            _CurrentData = EventArgs;
            
        }


    }

    
}
