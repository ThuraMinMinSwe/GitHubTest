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
    /// Interaction logic for GS_HotelProHouseKeeperList.xaml
    /// </summary>
    public partial class GS_HotelProHouseKeeperList : UserControl
    {

        public delegate void Custom_EventHandler(object sender, HKP_EventArgs args);

        public event Custom_EventHandler OnButtonClick;


        public GS_HotelProHouseKeeperList()
        {
            InitializeComponent();
            this.DataContext = this;
            CurrentItemList_HKP = new ObservableCollection<Staff>();
        }


        public static ObservableCollection<Staff> CurrentItemList_HKP;


        private ObservableCollection<Staff> _currentitem_HKP;

        public ObservableCollection<Staff> currentitem_HRP
        {
            get { return _currentitem_HKP; }
            set { _currentitem_HKP = value; }
        }





        private ObservableCollection<Staff> _housekeepers;

        public ObservableCollection<Staff> housekeepers
        {
            get { return _housekeepers; }
            set { _housekeepers = value; }
        }

        private void ButtonClicked(object sender, RoutedEventArgs e)
        {




            this.currentitem_HRP.Clear();
            this.currentitem_HRP.Add(GS_HotelProHouseKeeperList.CurrentItemList_HKP.FirstOrDefault());
            HKP_EventArgs args = new HKP_EventArgs(currentitem_HRP[0]);
           

            if (OnButtonClick != null)
            { OnButtonClick(sender, args); }
        }
        public Control GetHouseKeeperList()
        {

            
            return this;
        }

    }


    public class HKP_CurrentItemConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] != null)
            {
                GS_HotelProHouseKeeperList.CurrentItemList_HKP = new ObservableCollection<Staff>();
                GS_HotelProHouseKeeperList.CurrentItemList_HKP.Add(((ObservableCollection<Staff>)values[1]).Where(a => a.StaffId == int.Parse(values[2].ToString())).FirstOrDefault());
            }
            return values[0];
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class HKP_EventArgs : EventArgs
    {
        public Staff Selected_HKP { get; set; }
        public HKP_EventArgs(Staff staff)
        {
            Selected_HKP = staff;
        }

    }

}
