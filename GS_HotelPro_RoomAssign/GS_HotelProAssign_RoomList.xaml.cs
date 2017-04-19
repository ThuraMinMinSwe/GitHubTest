using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GS_HotelPro_RoomAssign
{
    /// <summary>
    /// Interaction logic for GS_HotelProAssign_RoomList.xaml
    /// </summary>
    public partial class GS_HotelProAssign_RoomList : UserControl
    {
        public delegate void Custom_EventHandler(object sender, roomList_EventArgs args);

        public event Custom_EventHandler OnButtonClick;

        public GS_HotelProAssign_RoomList()
        {
            InitializeComponent();
            this.DataContext = this;
            CurrentItemList_ROOMSLIST = new ObservableCollection<Assign_RoomsList>();
        }

        public static ObservableCollection<Assign_RoomsList> CurrentItemList_ROOMSLIST;



        private ObservableCollection<Assign_RoomsList> _currentitem_ROOM;
        public ObservableCollection<Assign_RoomsList> currentitem_ROOM
        {
            get { return _currentitem_ROOM; }
            set { _currentitem_ROOM = value; }
        }



        private ObservableCollection<Assign_RoomsList> _assign_RoomList;
        public ObservableCollection<Assign_RoomsList> assign_RoomList
        {
            get { return _assign_RoomList; }
            set { _assign_RoomList = value; }
        }

        #region Composite Filter Region
        private string _filter_roomName;

        public string filter_roomName
        {
            get { return _filter_roomName; }
            set { _filter_roomName = value; }
        }


        #endregion


        public Control GetRoomList()
        {


            return this;
        }
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {




            this.currentitem_ROOM.Clear();
            this.currentitem_ROOM.Add(GS_HotelProAssign_RoomList.CurrentItemList_ROOMSLIST.FirstOrDefault());
            roomList_EventArgs args = new roomList_EventArgs(currentitem_ROOM[0]);


            if (OnButtonClick != null)
            { OnButtonClick(sender, args); }
        }
    }


    public class roomList_CurrentItemConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] != null)
            {
                GS_HotelProAssign_RoomList.CurrentItemList_ROOMSLIST = new ObservableCollection<Assign_RoomsList>();
                GS_HotelProAssign_RoomList.CurrentItemList_ROOMSLIST.Add(((ObservableCollection<Assign_RoomsList>)values[1]).Where(a => a.roomId == int.Parse(values[2].ToString())).FirstOrDefault());
            }
            return values[0];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }


    public class roomList_EventArgs : EventArgs
    {
        public Assign_RoomsList Selected_assign_RoomList { get; set; }
        public roomList_EventArgs(Assign_RoomsList assign_RoomList)
        {
            Selected_assign_RoomList = assign_RoomList;
        }

    }
}
