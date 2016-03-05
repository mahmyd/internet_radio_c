namespace MIr.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListStatinName = new System.Windows.Forms.ListBox();
            this.ContextStationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TextName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LNameStation = new System.Windows.Forms.Label();
            this.TextUrl = new System.Windows.Forms.TextBox();
            this.LAdressStation = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.stationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохраниятьСостояниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.цветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ФонToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обЭтомТворенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonPanelClose = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lTime = new System.Windows.Forms.Label();
            this.tVolum = new System.Windows.Forms.TrackBar();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.pRadioBut = new System.Windows.Forms.Panel();
            this.LRadioText = new System.Windows.Forms.TextBox();
            this.bAddCheck = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.bPlayStop = new System.Windows.Forms.Button();
            this.bMute = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContextStationMenu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tVolum)).BeginInit();
            this.pRadioBut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListStatinName
            // 
            this.ListStatinName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ListStatinName.ContextMenuStrip = this.ContextStationMenu;
            this.ListStatinName.FormattingEnabled = true;
            resources.ApplyResources(this.ListStatinName, "ListStatinName");
            this.ListStatinName.Name = "ListStatinName";
            this.ListStatinName.SelectedValueChanged += new System.EventHandler(this.ListStatinNameSelectedValueChanged);
            this.ListStatinName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListStatinNameMouseDoubleClick);
            this.ListStatinName.MouseHover += new System.EventHandler(this.ListStatinNameMouseHover1);
            this.ListStatinName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListStatinNameMouseDown);
            // 
            // ContextStationMenu
            // 
            this.ContextStationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem1,
            this.toolStripSeparator1,
            this.редактироватьToolStripMenuItem,
            this.toolStripSeparator3});
            this.ContextStationMenu.Name = "ContextStationMenu";
            resources.ApplyResources(this.ContextStationMenu, "ContextStationMenu");
            // 
            // playToolStripMenuItem1
            // 
            this.playToolStripMenuItem1.Name = "playToolStripMenuItem1";
            resources.ApplyResources(this.playToolStripMenuItem1, "playToolStripMenuItem1");
            this.playToolStripMenuItem1.Click += new System.EventHandler(this.PlayToolStripMenuItem1Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переименоватьToolStripMenuItem1,
            this.изменитьToolStripMenuItem,
            this.toolStripSeparator4,
            this.удалитьToolStripMenuItem});
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            resources.ApplyResources(this.редактироватьToolStripMenuItem, "редактироватьToolStripMenuItem");
            // 
            // переименоватьToolStripMenuItem1
            // 
            this.переименоватьToolStripMenuItem1.Name = "переименоватьToolStripMenuItem1";
            resources.ApplyResources(this.переименоватьToolStripMenuItem1, "переименоватьToolStripMenuItem1");
            this.переименоватьToolStripMenuItem1.Click += new System.EventHandler(this.ПереименоватьToolStripMenuItem1Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            resources.ApplyResources(this.изменитьToolStripMenuItem, "изменитьToolStripMenuItem");
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьToolStripMenuItemClick);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            resources.ApplyResources(this.удалитьToolStripMenuItem, "удалитьToolStripMenuItem");
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.УдалитьToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // TextName
            // 
            resources.ApplyResources(this.TextName, "TextName");
            this.TextName.Name = "TextName";
            this.TextName.TextChanged += new System.EventHandler(this.TextNameTextChanged);
            this.TextName.MouseHover += new System.EventHandler(this.TextNameMouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // LNameStation
            // 
            this.LNameStation.ForeColor = System.Drawing.Color.Blue;
            resources.ApplyResources(this.LNameStation, "LNameStation");
            this.LNameStation.Name = "LNameStation";
            // 
            // TextUrl
            // 
            resources.ApplyResources(this.TextUrl, "TextUrl");
            this.TextUrl.Name = "TextUrl";
            this.TextUrl.TextChanged += new System.EventHandler(this.TextUrlTextChanged);
            this.TextUrl.MouseHover += new System.EventHandler(this.TextUrlMouseHover);
            // 
            // LAdressStation
            // 
            this.LAdressStation.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.LAdressStation, "LAdressStation");
            this.LAdressStation.Name = "LAdressStation";
            // 
            // bAdd
            // 
            resources.ApplyResources(this.bAdd, "bAdd");
            this.bAdd.Name = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.BAddClick);
            this.bAdd.MouseHover += new System.EventHandler(this.BAddMouseHover);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.Color.Gray;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stationToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // stationToolStripMenuItem
            // 
            this.stationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.playToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.stationToolStripMenuItem.Name = "stationToolStripMenuItem";
            resources.ApplyResources(this.stationToolStripMenuItem, "stationToolStripMenuItem");
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::MIr.Properties.Resources.add_icon;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            resources.ApplyResources(this.addToolStripMenuItem, "addToolStripMenuItem");
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItemClick);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = global::MIr.Properties.Resources.Select_icon;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            resources.ApplyResources(this.playToolStripMenuItem, "playToolStripMenuItem");
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::MIr.Properties.Resources.del_icon;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MIr.Properties.Resources.exit_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПрограммыToolStripMenuItem,
            this.цветToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            resources.ApplyResources(this.настройкиToolStripMenuItem, "настройкиToolStripMenuItem");
            // 
            // настройкиПрограммыToolStripMenuItem
            // 
            this.настройкиПрограммыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохраниятьСостояниеToolStripMenuItem,
            this.настройкиToolStripMenuItem1});
            this.настройкиПрограммыToolStripMenuItem.Image = global::MIr.Properties.Resources.setting_icon;
            this.настройкиПрограммыToolStripMenuItem.Name = "настройкиПрограммыToolStripMenuItem";
            resources.ApplyResources(this.настройкиПрограммыToolStripMenuItem, "настройкиПрограммыToolStripMenuItem");
            this.настройкиПрограммыToolStripMenuItem.Click += new System.EventHandler(this.НастройкиПрограммыToolStripMenuItemClick);
            this.настройкиПрограммыToolStripMenuItem.MouseEnter += new System.EventHandler(this.НастройкиПрограммыToolStripMenuItemMouseEnter);
            // 
            // сохраниятьСостояниеToolStripMenuItem
            // 
            this.сохраниятьСостояниеToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.сохраниятьСостояниеToolStripMenuItem.CheckOnClick = true;
            this.сохраниятьСостояниеToolStripMenuItem.Name = "сохраниятьСостояниеToolStripMenuItem";
            resources.ApplyResources(this.сохраниятьСостояниеToolStripMenuItem, "сохраниятьСостояниеToolStripMenuItem");
            this.сохраниятьСостояниеToolStripMenuItem.Click += new System.EventHandler(this.СохраниятьСостояниеToolStripMenuItemClick);
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            resources.ApplyResources(this.настройкиToolStripMenuItem1, "настройкиToolStripMenuItem1");
            this.настройкиToolStripMenuItem1.Click += new System.EventHandler(this.НастройкиToolStripMenuItem1Click);
            // 
            // цветToolStripMenuItem
            // 
            this.цветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ФонToolStripMenu});
            this.цветToolStripMenuItem.Image = global::MIr.Properties.Resources.color_icon;
            this.цветToolStripMenuItem.Name = "цветToolStripMenuItem";
            resources.ApplyResources(this.цветToolStripMenuItem, "цветToolStripMenuItem");
            this.цветToolStripMenuItem.Click += new System.EventHandler(this.ЦветToolStripMenuItemClick);
            // 
            // ФонToolStripMenu
            // 
            this.ФонToolStripMenu.Name = "ФонToolStripMenu";
            resources.ApplyResources(this.ФонToolStripMenu, "ФонToolStripMenu");
            this.ФонToolStripMenu.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обЭтомТворенииToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // обЭтомТворенииToolStripMenuItem
            // 
            this.обЭтомТворенииToolStripMenuItem.Name = "обЭтомТворенииToolStripMenuItem";
            resources.ApplyResources(this.обЭтомТворенииToolStripMenuItem, "обЭтомТворенииToolStripMenuItem");
            this.обЭтомТворенииToolStripMenuItem.Click += new System.EventHandler(this.ОбЭтомТворенииToolStripMenuItemClick);
            // 
            // StatusLabel
            // 
            resources.ApplyResources(this.StatusLabel, "StatusLabel");
            this.StatusLabel.Name = "StatusLabel";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Controls.Add(this.TextName);
            this.panel1.Controls.Add(this.ButtonPanelClose);
            this.panel1.Controls.Add(this.LAdressStation);
            this.panel1.Controls.Add(this.TextUrl);
            this.panel1.Controls.Add(this.LNameStation);
            this.panel1.Name = "panel1";
            // 
            // ButtonPanelClose
            // 
            this.ButtonPanelClose.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.ButtonPanelClose, "ButtonPanelClose");
            this.ButtonPanelClose.Name = "ButtonPanelClose";
            this.ButtonPanelClose.UseVisualStyleBackColor = false;
            this.ButtonPanelClose.Click += new System.EventHandler(this.ButtonPanelCloseClick);
            this.ButtonPanelClose.MouseHover += new System.EventHandler(this.ButtonPanelCloseMouseHover);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // lTime
            // 
            resources.ApplyResources(this.lTime, "lTime");
            this.lTime.Name = "lTime";
            // 
            // tVolum
            // 
            resources.ApplyResources(this.tVolum, "tVolum");
            this.tVolum.Name = "tVolum";
            this.tVolum.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tVolum.Scroll += new System.EventHandler(this.VolumScroll);
            this.tVolum.ValueChanged += new System.EventHandler(this.VolumValueChanged);
            // 
            // rb3
            // 
            resources.ApplyResources(this.rb3, "rb3");
            this.rb3.Name = "rb3";
            this.rb3.TabStop = true;
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            resources.ApplyResources(this.rb2, "rb2");
            this.rb2.Name = "rb2";
            this.rb2.TabStop = true;
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            resources.ApplyResources(this.rb1, "rb1");
            this.rb1.Name = "rb1";
            this.rb1.TabStop = true;
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // pRadioBut
            // 
            this.pRadioBut.Controls.Add(this.rb1);
            this.pRadioBut.Controls.Add(this.rb3);
            this.pRadioBut.Controls.Add(this.rb2);
            resources.ApplyResources(this.pRadioBut, "pRadioBut");
            this.pRadioBut.Name = "pRadioBut";
            // 
            // LRadioText
            // 
            this.LRadioText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.LRadioText, "LRadioText");
            this.LRadioText.Name = "LRadioText";
            this.LRadioText.ReadOnly = true;
            this.LRadioText.MouseHover += new System.EventHandler(this.Label4MouseHover);
            // 
            // bAddCheck
            // 
            resources.ApplyResources(this.bAddCheck, "bAddCheck");
            this.bAddCheck.Name = "bAddCheck";
            this.bAddCheck.UseVisualStyleBackColor = true;
            this.bAddCheck.Click += new System.EventHandler(this.BAddCheckClick);
            this.bAddCheck.MouseHover += new System.EventHandler(this.BAddCheckMouseHover);
            // 
            // fontDialog1
            // 
            this.fontDialog1.MaxSize = 9;
            this.fontDialog1.MinSize = 8;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 0;
            // 
            // bPlayStop
            // 
            resources.ApplyResources(this.bPlayStop, "bPlayStop");
            this.bPlayStop.Name = "bPlayStop";
            this.bPlayStop.UseVisualStyleBackColor = true;
            this.bPlayStop.Click += new System.EventHandler(this.Button1Click1);
            this.bPlayStop.MouseHover += new System.EventHandler(this.BPlayStopMouseHover);
            // 
            // bMute
            // 
            this.bMute.BackColor = System.Drawing.Color.Black;
            this.bMute.BackgroundImage = global::MIr.Properties.Resources.volOn1;
            resources.ApplyResources(this.bMute, "bMute");
            this.bMute.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bMute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.bMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.bMute.Name = "bMute";
            this.bMute.UseVisualStyleBackColor = true;
            this.bMute.Click += new System.EventHandler(this.BMuteClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::MIr.Properties.Resources.hhh1;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.bPlayStop);
            this.Controls.Add(this.bAddCheck);
            this.Controls.Add(this.bMute);
            this.Controls.Add(this.LRadioText);
            this.Controls.Add(this.tVolum);
            this.Controls.Add(this.ListStatinName);
            this.Controls.Add(this.pRadioBut);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lTime);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ContextStationMenu.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tVolum)).EndInit();
            this.pRadioBut.ResumeLayout(false);
            this.pRadioBut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LNameStation;
        private System.Windows.Forms.TextBox TextUrl;
        private System.Windows.Forms.Label LAdressStation;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem stationToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TrackBar tVolum;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Panel pRadioBut;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обЭтомТворенииToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ContextStationMenu;
        private System.Windows.Forms.Button ButtonPanelClose;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиПрограммыToolStripMenuItem;
        private System.Windows.Forms.TextBox LRadioText;
        private System.Windows.Forms.Button bMute;
        private System.Windows.Forms.Button bAddCheck;
        private System.Windows.Forms.ToolStripMenuItem цветToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        public System.Windows.Forms.ListBox ListStatinName;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button bPlayStop;
        private System.Windows.Forms.ToolStripMenuItem ФонToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem сохраниятьСостояниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
    }
}

