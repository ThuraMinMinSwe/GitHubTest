using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for GS_HotelProTaskAssign_Enq.xaml
    /// </summary>
    public partial class GS_HotelProTaskAssign_Enq : UserControl
    {

        public delegate void Custom_EventHandler(object sender, Custom_EventArgs args);

        public event Custom_EventHandler OnButtonClick;

        public GS_HotelProTaskAssign_Enq()
        {
            InitializeComponent();
            this.DataContext = this;
            CurrentItemList = new ObservableCollection<GS_HotelPro_RoomAssign.Task_Assign>();
        }

        private ICollectionView _task_assignList;

        public ICollectionView Task_AssignList
        {
            get { return _task_assignList; }
            set { _task_assignList = value; }
        }

        private ObservableCollection<Room_HouseKeeping_Status> _room_HouseKeeping_Status;

        public ObservableCollection<Room_HouseKeeping_Status> room_HouseKeeping_Status
        {
            get { return _room_HouseKeeping_Status; }
            set { _room_HouseKeeping_Status = value; }
        }


        public static ObservableCollection<Task_Assign> CurrentItemList { get; set; }

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

        private void CurrentItem_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (CurrentItem.Count > 0)
            {
                CurrentItem[0].room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
                CurrentItem[0].room_HouseKeeping_Status = room_HouseKeeping_Status;
            }
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {




            this.CurrentItem.Clear();
            this.CurrentItem.Add(CurrentItemList.FirstOrDefault());
            Custom_EventArgs args = new Custom_EventArgs(CurrentItem[0]);
            FilterFlyOut.IsOpen = true;

            //MahApps.Metro.Controls.Flyout flyout = new MahApps.Metro.Controls.Flyout();
            //flyout.Header = "Test";
            //flyout.IsOpen = true;
            //flyouts.IsOpen = true;

            if (OnButtonClick != null)
            { OnButtonClick(sender, args); }
        }
    }
    public class TaskAssignList_CurrentItemConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] != null)
            {
                GS_HotelProTaskAssign_Enq.CurrentItemList = new ObservableCollection<Task_Assign>();
                
                
                GS_HotelProTaskAssign_Enq.CurrentItemList.Add((Task_Assign)CollectionViewSource.GetDefaultView(values[1]).CurrentItem);
                //((ObservableCollection<Task_Assign>)values[1]).ToList().Where(x => x.roomNo != CustomRoomAssign.CurrentItem[0].roomNo).ToList().ForEach(x => x.IsSelected = false);
            }
            return values[0];
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
