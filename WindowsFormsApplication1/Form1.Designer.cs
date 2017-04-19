namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_HKP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_RoomList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_TaskAssignEnq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "AddRoomAssign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(319, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(824, 452);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(966, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "InsertRS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_HKP
            // 
            this.btn_HKP.Location = new System.Drawing.Point(714, 472);
            this.btn_HKP.Name = "btn_HKP";
            this.btn_HKP.Size = new System.Drawing.Size(75, 23);
            this.btn_HKP.TabIndex = 4;
            this.btn_HKP.Text = "AddHKP";
            this.btn_HKP.UseVisualStyleBackColor = true;
            this.btn_HKP.Click += new System.EventHandler(this.btn_HKP_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 237);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 217);
            this.panel2.TabIndex = 6;
            // 
            // btn_RoomList
            // 
            this.btn_RoomList.Location = new System.Drawing.Point(795, 472);
            this.btn_RoomList.Name = "btn_RoomList";
            this.btn_RoomList.Size = new System.Drawing.Size(75, 23);
            this.btn_RoomList.TabIndex = 7;
            this.btn_RoomList.Text = "AddRoomList";
            this.btn_RoomList.UseVisualStyleBackColor = true;
            this.btn_RoomList.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(251, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(70, 47);
            this.panel3.TabIndex = 7;
            // 
            // btn_TaskAssignEnq
            // 
            this.btn_TaskAssignEnq.Location = new System.Drawing.Point(516, 479);
            this.btn_TaskAssignEnq.Name = "btn_TaskAssignEnq";
            this.btn_TaskAssignEnq.Size = new System.Drawing.Size(75, 23);
            this.btn_TaskAssignEnq.TabIndex = 8;
            this.btn_TaskAssignEnq.Text = "Add_TaskAssignEnq";
            this.btn_TaskAssignEnq.UseVisualStyleBackColor = true;
            this.btn_TaskAssignEnq.Click += new System.EventHandler(this.btn_TaskAssignEnq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 514);
            this.Controls.Add(this.btn_TaskAssignEnq);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_RoomList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_HKP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_HKP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_RoomList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_TaskAssignEnq;
    }
}

