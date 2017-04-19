using System;
using System.Collections.Generic;
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

namespace WPF_USERCONTROL
{
    /// <summary>
    /// Interaction logic for CustomRoomAssign.xaml
    /// </summary>
    public partial class CustomRoomAssign : UserControl
    {
  

        private List<Room_HouseKeeping_Status> _houseKeeping_Status;

        public List<Room_HouseKeeping_Status> houseKeeping_Status
        {
            get { return _houseKeeping_Status; }
            set { _houseKeeping_Status = value; }
        }

        public CustomRoomAssign()
        {
            InitializeComponent();
            this.DataContext = this;
            InitializeData();


        }


       public void InitializeData()
        {
            this.userName = "ThuraTun";
            this.roomName = "101";

            houseKeeping_Status = new List<Room_HouseKeeping_Status>();
            houseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 1, Room_HouseKeeping_Name = "Dirty" });
            houseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 2, Room_HouseKeeping_Name = "Clean" });
            houseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 3, Room_HouseKeeping_Name = "Pickup" });

        }





        private string _username;

        public string userName       
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _roomname;

        public string roomName
        {
            get { return _roomname; }
            set { _roomname = value; }
        }


    }
}

public class Room_HouseKeeping_Status
{
    public int Room_HKStatus_ID { get; set; }
    public string Room_HouseKeeping_Name { get; set; }
    public int FinalStatus { get; set; }
}
