namespace AD_Project_FinalVers
{
    partial class DeveloperLogIn
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbAStudentA = new System.Windows.Forms.RadioButton();
            this.btnAEachStudentFeedback = new System.Windows.Forms.Button();
            this.rbAStudentB = new System.Windows.Forms.RadioButton();
            this.rbAStudentC = new System.Windows.Forms.RadioButton();
            this.lblAFeedbackInfo = new System.Windows.Forms.Label();
            this.lbFeedback = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRemoveStudentC = new System.Windows.Forms.Button();
            this.btnRemoveStudentB = new System.Windows.Forms.Button();
            this.btnRemoveStudentA = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbRoomA = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbRoomB = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbRoomC = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblASsecName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.dTPDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblASName = new System.Windows.Forms.Label();
            this.lblASDateBirth = new System.Windows.Forms.Label();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.lblASNationality = new System.Windows.Forms.Label();
            this.lblASList = new System.Windows.Forms.Label();
            this.lblAdminStudentA = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddRules = new System.Windows.Forms.Label();
            this.tbAddingRules = new System.Windows.Forms.TextBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.lblARulesList = new System.Windows.Forms.Label();
            this.btnAdminRemoveRules = new System.Windows.Forms.Button();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.btnTaskHistory = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 451);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage1.Controls.Add(this.btnTaskHistory);
            this.tabPage1.Controls.Add(this.btnLogOut);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.lblAFeedbackInfo);
            this.tabPage1.Controls.Add(this.lbFeedback);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(840, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StudentFeedback";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(72, 358);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.rbAStudentA);
            this.panel3.Controls.Add(this.btnAEachStudentFeedback);
            this.panel3.Controls.Add(this.rbAStudentB);
            this.panel3.Controls.Add(this.rbAStudentC);
            this.panel3.Location = new System.Drawing.Point(19, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 144);
            this.panel3.TabIndex = 8;
            // 
            // rbAStudentA
            // 
            this.rbAStudentA.AutoSize = true;
            this.rbAStudentA.Location = new System.Drawing.Point(27, 18);
            this.rbAStudentA.Name = "rbAStudentA";
            this.rbAStudentA.Size = new System.Drawing.Size(95, 21);
            this.rbAStudentA.TabIndex = 3;
            this.rbAStudentA.TabStop = true;
            this.rbAStudentA.Text = "Student: A";
            this.rbAStudentA.UseVisualStyleBackColor = true;
            // 
            // btnAEachStudentFeedback
            // 
            this.btnAEachStudentFeedback.Location = new System.Drawing.Point(118, 60);
            this.btnAEachStudentFeedback.Name = "btnAEachStudentFeedback";
            this.btnAEachStudentFeedback.Size = new System.Drawing.Size(151, 67);
            this.btnAEachStudentFeedback.TabIndex = 7;
            this.btnAEachStudentFeedback.Text = "Show feedback:";
            this.btnAEachStudentFeedback.UseVisualStyleBackColor = true;
            this.btnAEachStudentFeedback.Click += new System.EventHandler(this.btnAEachStudentFeedback_Click);
            // 
            // rbAStudentB
            // 
            this.rbAStudentB.AutoSize = true;
            this.rbAStudentB.Location = new System.Drawing.Point(154, 18);
            this.rbAStudentB.Name = "rbAStudentB";
            this.rbAStudentB.Size = new System.Drawing.Size(95, 21);
            this.rbAStudentB.TabIndex = 4;
            this.rbAStudentB.TabStop = true;
            this.rbAStudentB.Text = "Student: B";
            this.rbAStudentB.UseVisualStyleBackColor = true;
            // 
            // rbAStudentC
            // 
            this.rbAStudentC.AutoSize = true;
            this.rbAStudentC.Location = new System.Drawing.Point(281, 18);
            this.rbAStudentC.Name = "rbAStudentC";
            this.rbAStudentC.Size = new System.Drawing.Size(95, 21);
            this.rbAStudentC.TabIndex = 5;
            this.rbAStudentC.TabStop = true;
            this.rbAStudentC.Text = "Student: C";
            this.rbAStudentC.UseVisualStyleBackColor = true;
            // 
            // lblAFeedbackInfo
            // 
            this.lblAFeedbackInfo.AutoSize = true;
            this.lblAFeedbackInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAFeedbackInfo.Location = new System.Drawing.Point(40, 31);
            this.lblAFeedbackInfo.Name = "lblAFeedbackInfo";
            this.lblAFeedbackInfo.Size = new System.Drawing.Size(325, 36);
            this.lblAFeedbackInfo.TabIndex = 6;
            this.lblAFeedbackInfo.Text = "Each student feedback:";
            // 
            // lbFeedback
            // 
            this.lbFeedback.BackColor = System.Drawing.Color.LightGray;
            this.lbFeedback.FormattingEnabled = true;
            this.lbFeedback.ItemHeight = 16;
            this.lbFeedback.Location = new System.Drawing.Point(477, 48);
            this.lbFeedback.Name = "lbFeedback";
            this.lbFeedback.Size = new System.Drawing.Size(267, 260);
            this.lbFeedback.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage2.Controls.Add(this.btnRemoveStudentC);
            this.tabPage2.Controls.Add(this.btnRemoveStudentB);
            this.tabPage2.Controls.Add(this.btnRemoveStudentA);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.lblASList);
            this.tabPage2.Controls.Add(this.lblAdminStudentA);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "StudentProfiles";
            // 
            // btnRemoveStudentC
            // 
            this.btnRemoveStudentC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveStudentC.Location = new System.Drawing.Point(753, 345);
            this.btnRemoveStudentC.Name = "btnRemoveStudentC";
            this.btnRemoveStudentC.Size = new System.Drawing.Size(75, 43);
            this.btnRemoveStudentC.TabIndex = 30;
            this.btnRemoveStudentC.Text = "Remove student:";
            this.btnRemoveStudentC.UseVisualStyleBackColor = false;
            this.btnRemoveStudentC.Click += new System.EventHandler(this.btnRemoveStudentC_Click);
            // 
            // btnRemoveStudentB
            // 
            this.btnRemoveStudentB.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveStudentB.Location = new System.Drawing.Point(753, 229);
            this.btnRemoveStudentB.Name = "btnRemoveStudentB";
            this.btnRemoveStudentB.Size = new System.Drawing.Size(75, 50);
            this.btnRemoveStudentB.TabIndex = 29;
            this.btnRemoveStudentB.Text = "Remove student:";
            this.btnRemoveStudentB.UseVisualStyleBackColor = false;
            this.btnRemoveStudentB.Click += new System.EventHandler(this.btnRemoveStudentB_Click);
            // 
            // btnRemoveStudentA
            // 
            this.btnRemoveStudentA.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRemoveStudentA.Location = new System.Drawing.Point(753, 119);
            this.btnRemoveStudentA.Name = "btnRemoveStudentA";
            this.btnRemoveStudentA.Size = new System.Drawing.Size(75, 45);
            this.btnRemoveStudentA.TabIndex = 28;
            this.btnRemoveStudentA.Text = "Remove student:";
            this.btnRemoveStudentA.UseVisualStyleBackColor = false;
            this.btnRemoveStudentA.Click += new System.EventHandler(this.btnRemoveStudentA_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Bisque;
            this.panel4.Controls.Add(this.tbRoomA);
            this.panel4.Location = new System.Drawing.Point(463, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 108);
            this.panel4.TabIndex = 26;
            // 
            // tbRoomA
            // 
            this.tbRoomA.BackColor = System.Drawing.Color.Bisque;
            this.tbRoomA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRoomA.Location = new System.Drawing.Point(3, 3);
            this.tbRoomA.Multiline = true;
            this.tbRoomA.Name = "tbRoomA";
            this.tbRoomA.ReadOnly = true;
            this.tbRoomA.Size = new System.Drawing.Size(280, 102);
            this.tbRoomA.TabIndex = 27;
            this.tbRoomA.Text = "ROOM-A";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Bisque;
            this.panel5.Controls.Add(this.tbRoomB);
            this.panel5.Location = new System.Drawing.Point(463, 197);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(286, 108);
            this.panel5.TabIndex = 0;
            // 
            // tbRoomB
            // 
            this.tbRoomB.BackColor = System.Drawing.Color.Bisque;
            this.tbRoomB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRoomB.Location = new System.Drawing.Point(3, 4);
            this.tbRoomB.Multiline = true;
            this.tbRoomB.Name = "tbRoomB";
            this.tbRoomB.ReadOnly = true;
            this.tbRoomB.Size = new System.Drawing.Size(280, 102);
            this.tbRoomB.TabIndex = 28;
            this.tbRoomB.Text = "ROOM-B";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Bisque;
            this.panel6.Controls.Add(this.tbRoomC);
            this.panel6.Location = new System.Drawing.Point(463, 311);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(286, 108);
            this.panel6.TabIndex = 0;
            // 
            // tbRoomC
            // 
            this.tbRoomC.BackColor = System.Drawing.Color.Bisque;
            this.tbRoomC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRoomC.Location = new System.Drawing.Point(3, 3);
            this.tbRoomC.Multiline = true;
            this.tbRoomC.Name = "tbRoomC";
            this.tbRoomC.ReadOnly = true;
            this.tbRoomC.Size = new System.Drawing.Size(280, 102);
            this.tbRoomC.TabIndex = 29;
            this.tbRoomC.Text = "ROOM-C";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbRoom);
            this.panel1.Controls.Add(this.btnAddStudent);
            this.panel1.Controls.Add(this.lblASsecName);
            this.panel1.Controls.Add(this.tbLastName);
            this.panel1.Controls.Add(this.tbFirstName);
            this.panel1.Controls.Add(this.dTPDateOfBirth);
            this.panel1.Controls.Add(this.lblASName);
            this.panel1.Controls.Add(this.lblASDateBirth);
            this.panel1.Controls.Add(this.tbNationality);
            this.panel1.Controls.Add(this.lblASNationality);
            this.panel1.Location = new System.Drawing.Point(16, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 273);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Room:";
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Items.AddRange(new object[] {
            "ROOM-A",
            "ROOM-B",
            "ROOM-C"});
            this.cbRoom.Location = new System.Drawing.Point(260, 108);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(121, 24);
            this.cbRoom.TabIndex = 26;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddStudent.Location = new System.Drawing.Point(240, 186);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(141, 72);
            this.btnAddStudent.TabIndex = 25;
            this.btnAddStudent.Text = "Add student:";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblASsecName
            // 
            this.lblASsecName.AutoSize = true;
            this.lblASsecName.Location = new System.Drawing.Point(273, 13);
            this.lblASsecName.Name = "lblASsecName";
            this.lblASsecName.Size = new System.Drawing.Size(78, 17);
            this.lblASsecName.TabIndex = 23;
            this.lblASsecName.Text = "Last name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(223, 36);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(191, 22);
            this.tbLastName.TabIndex = 24;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(17, 36);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(191, 22);
            this.tbFirstName.TabIndex = 14;
            // 
            // dTPDateOfBirth
            // 
            this.dTPDateOfBirth.Location = new System.Drawing.Point(17, 198);
            this.dTPDateOfBirth.Name = "dTPDateOfBirth";
            this.dTPDateOfBirth.Size = new System.Drawing.Size(191, 22);
            this.dTPDateOfBirth.TabIndex = 22;
            // 
            // lblASName
            // 
            this.lblASName.AutoSize = true;
            this.lblASName.Location = new System.Drawing.Point(76, 13);
            this.lblASName.Name = "lblASName";
            this.lblASName.Size = new System.Drawing.Size(78, 17);
            this.lblASName.TabIndex = 15;
            this.lblASName.Text = "First name:";
            // 
            // lblASDateBirth
            // 
            this.lblASDateBirth.AutoSize = true;
            this.lblASDateBirth.Location = new System.Drawing.Point(76, 163);
            this.lblASDateBirth.Name = "lblASDateBirth";
            this.lblASDateBirth.Size = new System.Drawing.Size(90, 17);
            this.lblASDateBirth.TabIndex = 21;
            this.lblASDateBirth.Text = "Date of birth:";
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(17, 110);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(191, 22);
            this.tbNationality.TabIndex = 13;
            // 
            // lblASNationality
            // 
            this.lblASNationality.AutoSize = true;
            this.lblASNationality.Location = new System.Drawing.Point(76, 79);
            this.lblASNationality.Name = "lblASNationality";
            this.lblASNationality.Size = new System.Drawing.Size(78, 17);
            this.lblASNationality.TabIndex = 18;
            this.lblASNationality.Text = "Nationality:";
            // 
            // lblASList
            // 
            this.lblASList.AutoSize = true;
            this.lblASList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblASList.Location = new System.Drawing.Point(464, 20);
            this.lblASList.Name = "lblASList";
            this.lblASList.Size = new System.Drawing.Size(279, 50);
            this.lblASList.TabIndex = 26;
            this.lblASList.Text = "Information about each student\r\nin each room:\r\n";
            // 
            // lblAdminStudentA
            // 
            this.lblAdminStudentA.AutoSize = true;
            this.lblAdminStudentA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminStudentA.Location = new System.Drawing.Point(111, 20);
            this.lblAdminStudentA.Name = "lblAdminStudentA";
            this.lblAdminStudentA.Size = new System.Drawing.Size(247, 36);
            this.lblAdminStudentA.TabIndex = 0;
            this.lblAdminStudentA.Text = "Add new student:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.lblARulesList);
            this.tabPage3.Controls.Add(this.btnAdminRemoveRules);
            this.tabPage3.Controls.Add(this.lbRules);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(840, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rules";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.lblAddRules);
            this.panel2.Controls.Add(this.tbAddingRules);
            this.panel2.Controls.Add(this.btnAddRule);
            this.panel2.Location = new System.Drawing.Point(25, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 189);
            this.panel2.TabIndex = 6;
            // 
            // lblAddRules
            // 
            this.lblAddRules.AutoSize = true;
            this.lblAddRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddRules.Location = new System.Drawing.Point(104, 12);
            this.lblAddRules.Name = "lblAddRules";
            this.lblAddRules.Size = new System.Drawing.Size(199, 36);
            this.lblAddRules.TabIndex = 3;
            this.lblAddRules.Text = "Add new rule:";
            // 
            // tbAddingRules
            // 
            this.tbAddingRules.Location = new System.Drawing.Point(19, 70);
            this.tbAddingRules.Name = "tbAddingRules";
            this.tbAddingRules.Size = new System.Drawing.Size(378, 22);
            this.tbAddingRules.TabIndex = 2;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Location = new System.Drawing.Point(120, 110);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(173, 61);
            this.btnAddRule.TabIndex = 1;
            this.btnAddRule.Text = "Add rule";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // lblARulesList
            // 
            this.lblARulesList.AutoSize = true;
            this.lblARulesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblARulesList.Location = new System.Drawing.Point(516, 19);
            this.lblARulesList.Name = "lblARulesList";
            this.lblARulesList.Size = new System.Drawing.Size(217, 32);
            this.lblARulesList.TabIndex = 5;
            this.lblARulesList.Text = "House rules list:";
            // 
            // btnAdminRemoveRules
            // 
            this.btnAdminRemoveRules.Location = new System.Drawing.Point(541, 319);
            this.btnAdminRemoveRules.Name = "btnAdminRemoveRules";
            this.btnAdminRemoveRules.Size = new System.Drawing.Size(165, 72);
            this.btnAdminRemoveRules.TabIndex = 4;
            this.btnAdminRemoveRules.Text = "Remove selected rule:";
            this.btnAdminRemoveRules.UseVisualStyleBackColor = true;
            this.btnAdminRemoveRules.Click += new System.EventHandler(this.btnAdminRemoveRules_Click);
            // 
            // lbRules
            // 
            this.lbRules.BackColor = System.Drawing.Color.LightGray;
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 16;
            this.lbRules.Location = new System.Drawing.Point(506, 58);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(247, 244);
            this.lbRules.TabIndex = 0;
            // 
            // btnTaskHistory
            // 
            this.btnTaskHistory.Location = new System.Drawing.Point(283, 255);
            this.btnTaskHistory.Name = "btnTaskHistory";
            this.btnTaskHistory.Size = new System.Drawing.Size(136, 33);
            this.btnTaskHistory.TabIndex = 10;
            this.btnTaskHistory.Text = "View Task History";
            this.btnTaskHistory.UseVisualStyleBackColor = true;
            this.btnTaskHistory.Click += new System.EventHandler(this.btnTaskHistory_Click);
            // 
            // DeveloperLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DeveloperLogIn";
            this.Text = "DeveloperLogIn";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbAStudentA;
        private System.Windows.Forms.Button btnAEachStudentFeedback;
        private System.Windows.Forms.RadioButton rbAStudentB;
        private System.Windows.Forms.RadioButton rbAStudentC;
        private System.Windows.Forms.Label lblAFeedbackInfo;
        private System.Windows.Forms.ListBox lbFeedback;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemoveStudentC;
        private System.Windows.Forms.Button btnRemoveStudentB;
        private System.Windows.Forms.Button btnRemoveStudentA;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbRoomA;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbRoomB;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbRoomC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblASsecName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.DateTimePicker dTPDateOfBirth;
        private System.Windows.Forms.Label lblASName;
        private System.Windows.Forms.Label lblASDateBirth;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.Label lblASNationality;
        private System.Windows.Forms.Label lblASList;
        private System.Windows.Forms.Label lblAdminStudentA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddRules;
        private System.Windows.Forms.TextBox tbAddingRules;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Label lblARulesList;
        private System.Windows.Forms.Button btnAdminRemoveRules;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Button btnTaskHistory;
    }
}