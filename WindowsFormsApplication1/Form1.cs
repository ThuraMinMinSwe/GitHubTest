using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using GS_HotelPro_RoomAssign;
using System.Collections.ObjectModel;
using System.Windows.Data;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        CustomRoomAssign custom;
        GS_HotelProHouseKeeperList housekeeper;
        GS_HotelProAssign_RoomList roomlist;
         List<CustomRoomAssign> customList;
        GS_HotelProTaskAssign_Enq taskassign_enq;
        ElementHost host;

        Staff selectedhousekeeper;
        Assign_RoomsList selectedroomlist;

        

        public Form1()
        {
            InitializeComponent();
            customList = new List<CustomRoomAssign>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            host = new ElementHost();
            host.AutoSize = true;

            host.Dock = DockStyle.Top;
            GS_HotelProPopUpBox popup = new GS_HotelProPopUpBox();
            
            host.Child = popup;
            this.panel3.Controls.Add(host);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            host = new ElementHost();
            //host.Size = new Size(400, 600);
            host.AutoSize = true;
           
            host.Dock = DockStyle.Top;
            
            
             custom = new GS_HotelPro_RoomAssign.CustomRoomAssign();

            custom.hkpname = "Thura";
            custom.CurrentItem = new ObservableCollection<Task_Assign>();



            custom.room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
            custom.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 1, Room_HouseKeeping_Name = "Dirty" });
            custom.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 2, Room_HouseKeeping_Name = "Clean" });
            custom.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 3, Room_HouseKeeping_Name = "PickUp" });

            custom.Task_Assign = new ObservableCollection<GS_HotelPro_RoomAssign.Task_Assign>();


            custom.Task_Assign.Add(new Task_Assign { roomName = "DoubleRoom" , roomNo = "1001"});
            //custom.Task_Assign[0].room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
            //custom.Task_Assign[0].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 1, Room_HouseKeeping_Name = "Dirty" });
            //custom.Task_Assign[0].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 2, Room_HouseKeeping_Name = "Clean" });
            //custom.Task_Assign[0].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 3, Room_HouseKeeping_Name = "PickUp" });

            custom.Task_Assign.Add(new Task_Assign { roomName = "SingleRoom", roomNo = "1002" });
            //custom.Task_Assign[1].room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
            //custom.Task_Assign[1].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 1, Room_HouseKeeping_Name = "Dirty" });
            //custom.Task_Assign[1].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 2, Room_HouseKeeping_Name = "Clean" });
            //custom.Task_Assign[1].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 3, Room_HouseKeeping_Name = "PickUp" });


            custom.Task_Assign.Add(new Task_Assign { roomName = "Delux", roomNo = "1003" });
            //custom.Task_Assign[2].room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
            //custom.Task_Assign[2].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 1, Room_HouseKeeping_Name = "Dirty" });
            //custom.Task_Assign[2].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 2, Room_HouseKeeping_Name = "Clean" });
            //custom.Task_Assign[2].room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 3, Room_HouseKeeping_Name = "PickUp" });



            customList.Add(custom);

            custom.OnButtonClick += Custom_OnButtonClick;
            host.Child = custom.GetCustomRoomAssign(custom);
            this.flowLayoutPanel1.Controls.Add(host);
            


        }

        private void Custom_OnButtonClick(object sender, Custom_EventArgs args)
        {
           Task_Assign selecteditem = args._CurrentData;
            //MessageBox.Show(selecteditem.roomNo);
           selecteditem.IsSelected = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            host = new ElementHost();
            //host.Size = new Size(400, 600);
            host.AutoSize = true;

            host.Dock = DockStyle.Top;
            custom = customList[1];
            custom.Task_Assign.Add(new Task_Assign());
            //custom.Task_Assign.Add(new Task_Assign { roomName = "AddNew", roomNo = "1004",IsSelected=false });
            host.Refresh();
            this.flowLayoutPanel1.Controls.Add(host);
            
            



        }

        private void btn_HKP_Click(object sender, EventArgs e)
        {
            host = new ElementHost();
            //host.Size = new Size(400, 600);
            host.AutoSize = true;

            host.Dock = DockStyle.Top;
            housekeeper = new GS_HotelProHouseKeeperList();
            housekeeper.currentitem_HRP = new ObservableCollection<Staff>();
            housekeeper.housekeepers = new ObservableCollection<Staff>();
            housekeeper.housekeepers.Add(new Staff { StaffId = 1, Name = "ThuraTun" });
            housekeeper.housekeepers.Add(new Staff { StaffId = 2, Name = "TunTun" });
            housekeeper.housekeepers.Add(new Staff { StaffId = 3, Name = "MgMg" });

            housekeeper.housekeepers.Add(new Staff { StaffId = 4, Name = "ZawMinTun" });
            housekeeper.housekeepers.Add(new Staff { StaffId = 5, Name = "EiThandar" });
            housekeeper.housekeepers.Add(new Staff { StaffId = 6, Name = "TDWS" });
            housekeeper.housekeepers.Add(new Staff { StaffId = 7, Name = "EiThaw" });


            housekeeper.OnButtonClick += Housekeeper_OnButtonClick;
            host.Child = housekeeper.GetHouseKeeperList();
            this.panel1.Controls.Add(host);

            
        }

        private void Housekeeper_OnButtonClick(object sender, HKP_EventArgs args)
        {

            selectedhousekeeper = new Staff();
            selectedhousekeeper = args.Selected_HKP;

            if(custom!=null)
            {
                housekeeper.housekeepers.Where(a => a.StaffId != selectedhousekeeper.StaffId).ToList().ForEach(a => a.IsSelected = false);
                roomlist.assign_RoomList.ToList().ForEach(a => a.IsSelected = false);

            }


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            host = new ElementHost();
            //host.Size = new Size(400, 600);
            host.AutoSize = true;

            host.Dock = DockStyle.Top;


            roomlist = new GS_HotelProAssign_RoomList();
            roomlist.currentitem_ROOM = new ObservableCollection<Assign_RoomsList>();

            roomlist.assign_RoomList = new ObservableCollection<Assign_RoomsList>();
            roomlist.assign_RoomList.Add(new Assign_RoomsList { roomId = 1, roomNo = "1001" , roomName = "SingleRoom" , room_HKStatus_Id=1 });
            roomlist.assign_RoomList.Add(new Assign_RoomsList { roomId = 2, roomNo="1002"   , roomName = "DoublRoom", room_HKStatus_Id = 2 });
            roomlist.assign_RoomList.Add(new Assign_RoomsList { roomId = 3, roomNo="1003"   , roomName = "StandardRoom", room_HKStatus_Id = 1 });
            roomlist.assign_RoomList.Add(new Assign_RoomsList { roomId = 4, roomNo = "1004", roomName = "DeluxeRoom", room_HKStatus_Id = 3 });
            

            roomlist.OnButtonClick += Roomlist_OnButtonClick; ;
            host.Child = roomlist.GetRoomList();
            this.panel2.Controls.Add(host);
        }

        private void Roomlist_OnButtonClick(object sender, roomList_EventArgs args)
        {
            bool IsOldRecord = false;

            host = new ElementHost();
            host.AutoSize = true;
            host.Dock = DockStyle.Top;
           

            custom = new GS_HotelPro_RoomAssign.CustomRoomAssign();
           
            

            foreach (CustomRoomAssign assignedlist in customList)
            {
                if(assignedlist.hkpId == selectedhousekeeper.StaffId)
                {
                    custom = assignedlist;
                    IsOldRecord = true;
                    break;
                }
            }


            if(!IsOldRecord)
            {
                custom.CurrentItem = new ObservableCollection<Task_Assign>();
                custom.Task_Assign = new ObservableCollection<GS_HotelPro_RoomAssign.Task_Assign>();


                custom.room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
                custom.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 1, Room_HouseKeeping_Name = "Dirty" });
                custom.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 2, Room_HouseKeeping_Name = "Clean" });
                custom.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 3, Room_HouseKeeping_Name = "PickUp" });


                custom.hkpname = selectedhousekeeper.Name;
                custom.hkpId = selectedhousekeeper.StaffId;

                customList.Add(custom);
                custom.OnButtonClick += Custom_OnButtonClick;
                host.Child = custom.GetCustomRoomAssign(custom);
            }
            
            

            
          
            


            Task_Assign task_asssign = new Task_Assign();
            task_asssign.hkp_Id = selectedhousekeeper.StaffId;
            task_asssign.hkp_Name = selectedhousekeeper.Name;
            task_asssign.roomId = args.Selected_assign_RoomList.roomId;
            task_asssign.roomName = args.Selected_assign_RoomList.roomName;
            task_asssign.roomNo = args.Selected_assign_RoomList.roomNo;
            task_asssign.room_HK_Status_Id = args.Selected_assign_RoomList.room_HKStatus_Id;

            task_asssign.assign_RoomList = new ObservableCollection<Assign_RoomsList>();
            foreach(Assign_RoomsList assingroomlist in roomlist.assign_RoomList)
            {
                task_asssign.assign_RoomList.Add(assingroomlist);
            }
            
            


            custom.Task_Assign.Add(task_asssign);


            
            
            host.Refresh();
            this.flowLayoutPanel1.Controls.Add(host);
        }

        private void btn_TaskAssignEnq_Click(object sender, EventArgs e)
        {
            host = new ElementHost();
            //host.Size = new Size(400, 600);
            host.AutoSize = true;

            host.Dock = DockStyle.Top;


            taskassign_enq = new GS_HotelPro_RoomAssign.GS_HotelProTaskAssign_Enq();
            taskassign_enq.CurrentItem = new ObservableCollection<Task_Assign>();




            taskassign_enq.room_HouseKeeping_Status = new ObservableCollection<Room_HouseKeeping_Status>();
            taskassign_enq.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 1, Room_HouseKeeping_Name = "Dirty" });
            taskassign_enq.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 2, Room_HouseKeeping_Name = "Clean" });
            taskassign_enq.room_HouseKeeping_Status.Add(new Room_HouseKeeping_Status { Room_HKStatus_ID = 3, Room_HouseKeeping_Name = "PickUp" });


            ObservableCollection<Task_Assign> taskassign = new ObservableCollection<Task_Assign>();


            // taskassign_enq.Task_AssignList = new ObservableCollection<GS_HotelPro_RoomAssign.Task_Assign>();


            taskassign.Add(new Task_Assign { hkp_Name="ThuraTun", roomName = "DoubleRoom", roomNo = "2001" });
            taskassign.Add(new Task_Assign { hkp_Name = "ThuraTun", roomName = "DoubleRoom", roomNo = "2002" });
            taskassign.Add(new Task_Assign { hkp_Name = "AgAg" , roomName = "SingleRoom", roomNo = "1002" });
            taskassign.Add(new Task_Assign { hkp_Name = "ZawZaw" , roomName = "Delux", roomNo = "3001" });
            taskassign.Add(new Task_Assign { hkp_Name = "ThuraTun", roomName = "FamilyRoom", roomNo = "4001" });

            taskassign_enq.Task_AssignList = CollectionViewSource.GetDefaultView(taskassign);
            taskassign_enq.Task_AssignList.GroupDescriptions.Add(new PropertyGroupDescription("hkp_Name"));
            





            host.Child = taskassign_enq;
            this.flowLayoutPanel1.Controls.Add(host);
        }
    }
}
