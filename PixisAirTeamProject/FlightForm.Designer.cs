namespace PixisAirTeamProject
{
    partial class FlightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightForm));
            this.menuStripFlight = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.Button();
            this.displayAirplanesButton = new System.Windows.Forms.Button();
            this.pinkAccentLabel = new System.Windows.Forms.Label();
            this.orangeAccentLabel = new System.Windows.Forms.Label();
            this.greenAccentLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.paperPlanePictureBox = new System.Windows.Forms.PictureBox();
            this.airplanesListBox = new System.Windows.Forms.ListBox();
            this.planeNumberLabel = new System.Windows.Forms.Label();
            this.planeNumberTextBox = new System.Windows.Forms.TextBox();
            this.maxDistanceLabel = new System.Windows.Forms.Label();
            this.firstClassLabel = new System.Windows.Forms.Label();
            this.coachClassLabel = new System.Windows.Forms.Label();
            this.planeAvailableLabel = new System.Windows.Forms.Label();
            this.maintenanceMilesLabel = new System.Windows.Forms.Label();
            this.planeModelLabel = new System.Windows.Forms.Label();
            this.maintenanceDateLabel = new System.Windows.Forms.Label();
            this.planeMakeLabel = new System.Windows.Forms.Label();
            this.aPARCDLabel = new System.Windows.Forms.Label();
            this.aPACTDTLabel = new System.Windows.Forms.Label();
            this.aPIACTDTLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.maxDistanceTextBox = new System.Windows.Forms.TextBox();
            this.firstClassTextBox = new System.Windows.Forms.TextBox();
            this.coachClassTextBox = new System.Windows.Forms.TextBox();
            this.planeAvailableTextBox = new System.Windows.Forms.TextBox();
            this.maintenanceMilesTextBox = new System.Windows.Forms.TextBox();
            this.planeModelTextBox = new System.Windows.Forms.TextBox();
            this.planeMakeTextBox = new System.Windows.Forms.TextBox();
            this.aPARCDTextBox = new System.Windows.Forms.TextBox();
            this.aPACTDTTextBox = new System.Windows.Forms.TextBox();
            this.aPIACTDTTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.maintenanceDateTextBox = new System.Windows.Forms.TextBox();
            this.addAirplaneButton = new System.Windows.Forms.Button();
            this.employeeNumberListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayEmployeeStateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeStateTextBox = new System.Windows.Forms.TextBox();
            this.airplanesLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.employeeStateLabel = new System.Windows.Forms.Label();
            this.menuStripFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperPlanePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripFlight
            // 
            this.menuStripFlight.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStripFlight.Location = new System.Drawing.Point(0, 0);
            this.menuStripFlight.Name = "menuStripFlight";
            this.menuStripFlight.Size = new System.Drawing.Size(800, 24);
            this.menuStripFlight.TabIndex = 0;
            this.menuStripFlight.Text = "Flight Menu";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeFormToolStripMenuItem,
            this.jobFormToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // employeeFormToolStripMenuItem
            // 
            this.employeeFormToolStripMenuItem.Name = "employeeFormToolStripMenuItem";
            this.employeeFormToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.employeeFormToolStripMenuItem.Text = "Employee Form";
            this.employeeFormToolStripMenuItem.Click += new System.EventHandler(this.employeeFormToolStripMenuItem_Click);
            // 
            // jobFormToolStripMenuItem
            // 
            this.jobFormToolStripMenuItem.Name = "jobFormToolStripMenuItem";
            this.jobFormToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.jobFormToolStripMenuItem.Text = "Job Form";
            this.jobFormToolStripMenuItem.Click += new System.EventHandler(this.jobFormToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 784);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(776, 35);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // displayAirplanesButton
            // 
            this.displayAirplanesButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAirplanesButton.Location = new System.Drawing.Point(12, 347);
            this.displayAirplanesButton.Name = "displayAirplanesButton";
            this.displayAirplanesButton.Size = new System.Drawing.Size(776, 35);
            this.displayAirplanesButton.TabIndex = 0;
            this.displayAirplanesButton.Text = "Display Airplanes";
            this.displayAirplanesButton.UseVisualStyleBackColor = true;
            this.displayAirplanesButton.Click += new System.EventHandler(this.displayAirplanesButton_Click);
            // 
            // pinkAccentLabel
            // 
            this.pinkAccentLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinkAccentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(176)))));
            this.pinkAccentLabel.Location = new System.Drawing.Point(12, 191);
            this.pinkAccentLabel.Name = "pinkAccentLabel";
            this.pinkAccentLabel.Size = new System.Drawing.Size(567, 38);
            this.pinkAccentLabel.TabIndex = 17;
            this.pinkAccentLabel.Text = "                                                                   ";
            this.pinkAccentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // orangeAccentLabel
            // 
            this.orangeAccentLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orangeAccentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(180)))), ((int)(((byte)(154)))));
            this.orangeAccentLabel.Location = new System.Drawing.Point(12, 153);
            this.orangeAccentLabel.Name = "orangeAccentLabel";
            this.orangeAccentLabel.Size = new System.Drawing.Size(567, 38);
            this.orangeAccentLabel.TabIndex = 16;
            this.orangeAccentLabel.Text = "                                                             ";
            this.orangeAccentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // greenAccentLabel
            // 
            this.greenAccentLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenAccentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.greenAccentLabel.Location = new System.Drawing.Point(12, 115);
            this.greenAccentLabel.Name = "greenAccentLabel";
            this.greenAccentLabel.Size = new System.Drawing.Size(567, 38);
            this.greenAccentLabel.TabIndex = 15;
            this.greenAccentLabel.Text = "                                                       ";
            this.greenAccentLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.titleLabel.Location = new System.Drawing.Point(12, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(567, 39);
            this.titleLabel.TabIndex = 14;
            this.titleLabel.Text = "PixisAir Flight Reservations  ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // paperPlanePictureBox
            // 
            this.paperPlanePictureBox.Image = global::PixisAirTeamProject.Properties.Resources.PixisAirPaperPlane;
            this.paperPlanePictureBox.Location = new System.Drawing.Point(585, 29);
            this.paperPlanePictureBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paperPlanePictureBox.Name = "paperPlanePictureBox";
            this.paperPlanePictureBox.Size = new System.Drawing.Size(203, 195);
            this.paperPlanePictureBox.TabIndex = 13;
            this.paperPlanePictureBox.TabStop = false;
            // 
            // airplanesListBox
            // 
            this.airplanesListBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplanesListBox.FormattingEnabled = true;
            this.airplanesListBox.HorizontalScrollbar = true;
            this.airplanesListBox.ItemHeight = 15;
            this.airplanesListBox.Location = new System.Drawing.Point(12, 247);
            this.airplanesListBox.Name = "airplanesListBox";
            this.airplanesListBox.Size = new System.Drawing.Size(776, 94);
            this.airplanesListBox.TabIndex = 18;
            // 
            // planeNumberLabel
            // 
            this.planeNumberLabel.AutoSize = true;
            this.planeNumberLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.planeNumberLabel.Location = new System.Drawing.Point(9, 385);
            this.planeNumberLabel.Name = "planeNumberLabel";
            this.planeNumberLabel.Size = new System.Drawing.Size(76, 15);
            this.planeNumberLabel.TabIndex = 19;
            this.planeNumberLabel.Text = "Plane Number";
            // 
            // planeNumberTextBox
            // 
            this.planeNumberTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeNumberTextBox.Location = new System.Drawing.Point(12, 403);
            this.planeNumberTextBox.Name = "planeNumberTextBox";
            this.planeNumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.planeNumberTextBox.TabIndex = 20;
            // 
            // maxDistanceLabel
            // 
            this.maxDistanceLabel.AutoSize = true;
            this.maxDistanceLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDistanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.maxDistanceLabel.Location = new System.Drawing.Point(121, 385);
            this.maxDistanceLabel.Name = "maxDistanceLabel";
            this.maxDistanceLabel.Size = new System.Drawing.Size(72, 15);
            this.maxDistanceLabel.TabIndex = 21;
            this.maxDistanceLabel.Text = "Max Distance";
            // 
            // firstClassLabel
            // 
            this.firstClassLabel.AutoSize = true;
            this.firstClassLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstClassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.firstClassLabel.Location = new System.Drawing.Point(233, 385);
            this.firstClassLabel.Name = "firstClassLabel";
            this.firstClassLabel.Size = new System.Drawing.Size(57, 15);
            this.firstClassLabel.TabIndex = 22;
            this.firstClassLabel.Text = "First Class";
            // 
            // coachClassLabel
            // 
            this.coachClassLabel.AutoSize = true;
            this.coachClassLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachClassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.coachClassLabel.Location = new System.Drawing.Point(345, 385);
            this.coachClassLabel.Name = "coachClassLabel";
            this.coachClassLabel.Size = new System.Drawing.Size(64, 15);
            this.coachClassLabel.TabIndex = 23;
            this.coachClassLabel.Text = "Coach Class";
            // 
            // planeAvailableLabel
            // 
            this.planeAvailableLabel.AutoSize = true;
            this.planeAvailableLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeAvailableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.planeAvailableLabel.Location = new System.Drawing.Point(457, 385);
            this.planeAvailableLabel.Name = "planeAvailableLabel";
            this.planeAvailableLabel.Size = new System.Drawing.Size(83, 15);
            this.planeAvailableLabel.TabIndex = 24;
            this.planeAvailableLabel.Text = "Plane Available";
            // 
            // maintenanceMilesLabel
            // 
            this.maintenanceMilesLabel.AutoSize = true;
            this.maintenanceMilesLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceMilesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.maintenanceMilesLabel.Location = new System.Drawing.Point(569, 385);
            this.maintenanceMilesLabel.Name = "maintenanceMilesLabel";
            this.maintenanceMilesLabel.Size = new System.Drawing.Size(99, 15);
            this.maintenanceMilesLabel.TabIndex = 25;
            this.maintenanceMilesLabel.Text = "Maintenance Miles";
            // 
            // planeModelLabel
            // 
            this.planeModelLabel.AutoSize = true;
            this.planeModelLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeModelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.planeModelLabel.Location = new System.Drawing.Point(681, 385);
            this.planeModelLabel.Name = "planeModelLabel";
            this.planeModelLabel.Size = new System.Drawing.Size(68, 15);
            this.planeModelLabel.TabIndex = 26;
            this.planeModelLabel.Text = "Plane Model";
            // 
            // maintenanceDateLabel
            // 
            this.maintenanceDateLabel.AutoSize = true;
            this.maintenanceDateLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.maintenanceDateLabel.Location = new System.Drawing.Point(569, 426);
            this.maintenanceDateLabel.Name = "maintenanceDateLabel";
            this.maintenanceDateLabel.Size = new System.Drawing.Size(96, 15);
            this.maintenanceDateLabel.TabIndex = 27;
            this.maintenanceDateLabel.Text = "Maintenance Date";
            // 
            // planeMakeLabel
            // 
            this.planeMakeLabel.AutoSize = true;
            this.planeMakeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeMakeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.planeMakeLabel.Location = new System.Drawing.Point(9, 426);
            this.planeMakeLabel.Name = "planeMakeLabel";
            this.planeMakeLabel.Size = new System.Drawing.Size(65, 15);
            this.planeMakeLabel.TabIndex = 28;
            this.planeMakeLabel.Text = "Plane Make";
            // 
            // aPARCDLabel
            // 
            this.aPARCDLabel.AutoSize = true;
            this.aPARCDLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPARCDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.aPARCDLabel.Location = new System.Drawing.Point(121, 426);
            this.aPARCDLabel.Name = "aPARCDLabel";
            this.aPARCDLabel.Size = new System.Drawing.Size(48, 15);
            this.aPARCDLabel.TabIndex = 29;
            this.aPARCDLabel.Text = "APARCD";
            // 
            // aPACTDTLabel
            // 
            this.aPACTDTLabel.AutoSize = true;
            this.aPACTDTLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPACTDTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.aPACTDTLabel.Location = new System.Drawing.Point(233, 426);
            this.aPACTDTLabel.Name = "aPACTDTLabel";
            this.aPACTDTLabel.Size = new System.Drawing.Size(51, 15);
            this.aPACTDTLabel.TabIndex = 30;
            this.aPACTDTLabel.Text = "APACTDT";
            // 
            // aPIACTDTLabel
            // 
            this.aPIACTDTLabel.AutoSize = true;
            this.aPIACTDTLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPIACTDTLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.aPIACTDTLabel.Location = new System.Drawing.Point(345, 426);
            this.aPIACTDTLabel.Name = "aPIACTDTLabel";
            this.aPIACTDTLabel.Size = new System.Drawing.Size(54, 15);
            this.aPIACTDTLabel.TabIndex = 31;
            this.aPIACTDTLabel.Text = "APIACTDT";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.statusLabel.Location = new System.Drawing.Point(457, 426);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(38, 15);
            this.statusLabel.TabIndex = 32;
            this.statusLabel.Text = "Status";
            // 
            // maxDistanceTextBox
            // 
            this.maxDistanceTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxDistanceTextBox.Location = new System.Drawing.Point(124, 403);
            this.maxDistanceTextBox.Name = "maxDistanceTextBox";
            this.maxDistanceTextBox.Size = new System.Drawing.Size(104, 20);
            this.maxDistanceTextBox.TabIndex = 33;
            // 
            // firstClassTextBox
            // 
            this.firstClassTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstClassTextBox.Location = new System.Drawing.Point(236, 403);
            this.firstClassTextBox.Name = "firstClassTextBox";
            this.firstClassTextBox.Size = new System.Drawing.Size(104, 20);
            this.firstClassTextBox.TabIndex = 34;
            // 
            // coachClassTextBox
            // 
            this.coachClassTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coachClassTextBox.Location = new System.Drawing.Point(348, 403);
            this.coachClassTextBox.Name = "coachClassTextBox";
            this.coachClassTextBox.Size = new System.Drawing.Size(104, 20);
            this.coachClassTextBox.TabIndex = 35;
            // 
            // planeAvailableTextBox
            // 
            this.planeAvailableTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeAvailableTextBox.Location = new System.Drawing.Point(460, 403);
            this.planeAvailableTextBox.Name = "planeAvailableTextBox";
            this.planeAvailableTextBox.Size = new System.Drawing.Size(104, 20);
            this.planeAvailableTextBox.TabIndex = 36;
            // 
            // maintenanceMilesTextBox
            // 
            this.maintenanceMilesTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceMilesTextBox.Location = new System.Drawing.Point(572, 403);
            this.maintenanceMilesTextBox.Name = "maintenanceMilesTextBox";
            this.maintenanceMilesTextBox.Size = new System.Drawing.Size(104, 20);
            this.maintenanceMilesTextBox.TabIndex = 37;
            // 
            // planeModelTextBox
            // 
            this.planeModelTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeModelTextBox.Location = new System.Drawing.Point(684, 403);
            this.planeModelTextBox.Name = "planeModelTextBox";
            this.planeModelTextBox.Size = new System.Drawing.Size(104, 20);
            this.planeModelTextBox.TabIndex = 38;
            // 
            // planeMakeTextBox
            // 
            this.planeMakeTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planeMakeTextBox.Location = new System.Drawing.Point(12, 444);
            this.planeMakeTextBox.Name = "planeMakeTextBox";
            this.planeMakeTextBox.Size = new System.Drawing.Size(104, 20);
            this.planeMakeTextBox.TabIndex = 39;
            // 
            // aPARCDTextBox
            // 
            this.aPARCDTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPARCDTextBox.Location = new System.Drawing.Point(124, 444);
            this.aPARCDTextBox.Name = "aPARCDTextBox";
            this.aPARCDTextBox.Size = new System.Drawing.Size(104, 20);
            this.aPARCDTextBox.TabIndex = 40;
            // 
            // aPACTDTTextBox
            // 
            this.aPACTDTTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPACTDTTextBox.Location = new System.Drawing.Point(236, 444);
            this.aPACTDTTextBox.Name = "aPACTDTTextBox";
            this.aPACTDTTextBox.Size = new System.Drawing.Size(104, 20);
            this.aPACTDTTextBox.TabIndex = 41;
            // 
            // aPIACTDTTextBox
            // 
            this.aPIACTDTTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPIACTDTTextBox.Location = new System.Drawing.Point(348, 444);
            this.aPIACTDTTextBox.Name = "aPIACTDTTextBox";
            this.aPIACTDTTextBox.Size = new System.Drawing.Size(104, 20);
            this.aPIACTDTTextBox.TabIndex = 42;
            // 
            // statusTextBox
            // 
            this.statusTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTextBox.Location = new System.Drawing.Point(460, 444);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(104, 20);
            this.statusTextBox.TabIndex = 43;
            // 
            // maintenanceDateTextBox
            // 
            this.maintenanceDateTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenanceDateTextBox.Location = new System.Drawing.Point(572, 444);
            this.maintenanceDateTextBox.Name = "maintenanceDateTextBox";
            this.maintenanceDateTextBox.Size = new System.Drawing.Size(104, 20);
            this.maintenanceDateTextBox.TabIndex = 44;
            // 
            // addAirplaneButton
            // 
            this.addAirplaneButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAirplaneButton.Location = new System.Drawing.Point(12, 470);
            this.addAirplaneButton.Name = "addAirplaneButton";
            this.addAirplaneButton.Size = new System.Drawing.Size(776, 35);
            this.addAirplaneButton.TabIndex = 45;
            this.addAirplaneButton.Text = "Add Airplane";
            this.addAirplaneButton.UseVisualStyleBackColor = true;
            this.addAirplaneButton.Click += new System.EventHandler(this.addAirplaneButton_Click);
            // 
            // employeeNumberListBox
            // 
            this.employeeNumberListBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberListBox.FormattingEnabled = true;
            this.employeeNumberListBox.ItemHeight = 15;
            this.employeeNumberListBox.Location = new System.Drawing.Point(12, 564);
            this.employeeNumberListBox.Name = "employeeNumberListBox";
            this.employeeNumberListBox.Size = new System.Drawing.Size(776, 94);
            this.employeeNumberListBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 38);
            this.label1.TabIndex = 47;
            this.label1.Text = "                                                                         ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // displayEmployeeStateButton
            // 
            this.displayEmployeeStateButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmployeeStateButton.Location = new System.Drawing.Point(12, 705);
            this.displayEmployeeStateButton.Name = "displayEmployeeStateButton";
            this.displayEmployeeStateButton.Size = new System.Drawing.Size(776, 35);
            this.displayEmployeeStateButton.TabIndex = 48;
            this.displayEmployeeStateButton.Text = "Display Employee State";
            this.displayEmployeeStateButton.UseVisualStyleBackColor = true;
            this.displayEmployeeStateButton.Click += new System.EventHandler(this.displayEmployeeStateButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(12, 743);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(776, 38);
            this.label2.TabIndex = 50;
            this.label2.Text = "                                                                               ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // employeeStateTextBox
            // 
            this.employeeStateTextBox.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeStateTextBox.Location = new System.Drawing.Point(12, 679);
            this.employeeStateTextBox.Name = "employeeStateTextBox";
            this.employeeStateTextBox.Size = new System.Drawing.Size(104, 20);
            this.employeeStateTextBox.TabIndex = 51;
            // 
            // airplanesLabel
            // 
            this.airplanesLabel.AutoSize = true;
            this.airplanesLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airplanesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.airplanesLabel.Location = new System.Drawing.Point(12, 229);
            this.airplanesLabel.Name = "airplanesLabel";
            this.airplanesLabel.Size = new System.Drawing.Size(53, 15);
            this.airplanesLabel.TabIndex = 52;
            this.airplanesLabel.Text = "Airplanes";
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.AutoSize = true;
            this.employeeNumberLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.employeeNumberLabel.Location = new System.Drawing.Point(9, 546);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(95, 15);
            this.employeeNumberLabel.TabIndex = 53;
            this.employeeNumberLabel.Text = "Employee Number";
            // 
            // employeeStateLabel
            // 
            this.employeeStateLabel.AutoSize = true;
            this.employeeStateLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(196)))), ((int)(((byte)(224)))));
            this.employeeStateLabel.Location = new System.Drawing.Point(9, 661);
            this.employeeStateLabel.Name = "employeeStateLabel";
            this.employeeStateLabel.Size = new System.Drawing.Size(83, 15);
            this.employeeStateLabel.TabIndex = 54;
            this.employeeStateLabel.Text = "Employee State";
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 831);
            this.Controls.Add(this.employeeStateLabel);
            this.Controls.Add(this.employeeNumberLabel);
            this.Controls.Add(this.airplanesLabel);
            this.Controls.Add(this.employeeStateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayEmployeeStateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeNumberListBox);
            this.Controls.Add(this.addAirplaneButton);
            this.Controls.Add(this.maintenanceDateTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.aPIACTDTTextBox);
            this.Controls.Add(this.aPACTDTTextBox);
            this.Controls.Add(this.aPARCDTextBox);
            this.Controls.Add(this.planeMakeTextBox);
            this.Controls.Add(this.planeModelTextBox);
            this.Controls.Add(this.maintenanceMilesTextBox);
            this.Controls.Add(this.planeAvailableTextBox);
            this.Controls.Add(this.coachClassTextBox);
            this.Controls.Add(this.firstClassTextBox);
            this.Controls.Add(this.maxDistanceTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.aPIACTDTLabel);
            this.Controls.Add(this.aPACTDTLabel);
            this.Controls.Add(this.aPARCDLabel);
            this.Controls.Add(this.planeMakeLabel);
            this.Controls.Add(this.maintenanceDateLabel);
            this.Controls.Add(this.planeModelLabel);
            this.Controls.Add(this.maintenanceMilesLabel);
            this.Controls.Add(this.planeAvailableLabel);
            this.Controls.Add(this.coachClassLabel);
            this.Controls.Add(this.firstClassLabel);
            this.Controls.Add(this.maxDistanceLabel);
            this.Controls.Add(this.planeNumberTextBox);
            this.Controls.Add(this.planeNumberLabel);
            this.Controls.Add(this.airplanesListBox);
            this.Controls.Add(this.pinkAccentLabel);
            this.Controls.Add(this.orangeAccentLabel);
            this.Controls.Add(this.greenAccentLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.paperPlanePictureBox);
            this.Controls.Add(this.displayAirplanesButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStripFlight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFlight;
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Form";
            this.Load += new System.EventHandler(this.FlightForm_Load);
            this.menuStripFlight.ResumeLayout(false);
            this.menuStripFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paperPlanePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFlight;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobFormToolStripMenuItem;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button displayAirplanesButton;
        private System.Windows.Forms.Label pinkAccentLabel;
        private System.Windows.Forms.Label orangeAccentLabel;
        private System.Windows.Forms.Label greenAccentLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox paperPlanePictureBox;
        private System.Windows.Forms.ListBox airplanesListBox;
        private System.Windows.Forms.Label planeNumberLabel;
        private System.Windows.Forms.TextBox planeNumberTextBox;
        private System.Windows.Forms.Label maxDistanceLabel;
        private System.Windows.Forms.Label firstClassLabel;
        private System.Windows.Forms.Label coachClassLabel;
        private System.Windows.Forms.Label planeAvailableLabel;
        private System.Windows.Forms.Label maintenanceMilesLabel;
        private System.Windows.Forms.Label planeModelLabel;
        private System.Windows.Forms.Label maintenanceDateLabel;
        private System.Windows.Forms.Label planeMakeLabel;
        private System.Windows.Forms.Label aPARCDLabel;
        private System.Windows.Forms.Label aPACTDTLabel;
        private System.Windows.Forms.Label aPIACTDTLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox maxDistanceTextBox;
        private System.Windows.Forms.TextBox firstClassTextBox;
        private System.Windows.Forms.TextBox coachClassTextBox;
        private System.Windows.Forms.TextBox planeAvailableTextBox;
        private System.Windows.Forms.TextBox maintenanceMilesTextBox;
        private System.Windows.Forms.TextBox planeModelTextBox;
        private System.Windows.Forms.TextBox planeMakeTextBox;
        private System.Windows.Forms.TextBox aPARCDTextBox;
        private System.Windows.Forms.TextBox aPACTDTTextBox;
        private System.Windows.Forms.TextBox aPIACTDTTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox maintenanceDateTextBox;
        private System.Windows.Forms.Button addAirplaneButton;
        private System.Windows.Forms.ListBox employeeNumberListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayEmployeeStateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeStateTextBox;
        private System.Windows.Forms.Label airplanesLabel;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label employeeStateLabel;
    }
}