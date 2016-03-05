﻿using System;
using System.Linq;
using System.Collections.Generic;
using InternetRadio.UI;
using System.Windows.Forms;
using InternetRadio;
using InternetRadio.Common;
using InternetRadio.Engine;
using MIr.Class;

namespace MIr.Forms
{
    public partial class MainForm : Form
    {
        public ToolTip ToolTip1 = new ToolTip();
        public Player Player = new Player();
        readonly PropertyForm _setForm = new PropertyForm();
        DateTime _time = new DateTime();
        public ListBox NameStation = new ListBox();
        public ListBox LincStation = new ListBox();
        public ListBox NumOfOpen = new ListBox();
        string _operation = null;
        string _tempForToolTip = null;
        bool _doOperation = false;
        public bool Save = true;
        bool _mute = false;
        public string SToolTip = null;
        int _selectIndex = -1;
        public string TimeForHandle = DateTime.Now.ToShortTimeString().ToString();
        public bool IsPlay = false;
        
        public MainForm()
        {
            InitializeComponent();
            ListStatinName.MouseDoubleClick += new MouseEventHandler(ListStatinNameMouseDoubleClick);
            ListStatinName.MouseDown += new MouseEventHandler(ListStatinNameMouseDown);
            _setForm.ColorForm = ColorForm;
        }


        
        public void PlayStation(int selectIndex)
        {
            progressBar1.Value = 0;
            IsPlay = true;

            if (selectIndex != -1 && selectIndex <= (LincStation.Items.Count-1))
            {

                LincStation.SelectedIndex = selectIndex;
                Player.OpenFile(LincStation.SelectedItem.ToString());
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Step = 1;
                timer1.Interval = 900;
                timer1.Start();

                bPlayStop.Text = "Стоп";
                //Прослушиваний +1
                //var i = Convert.ToInt32(NumOfOpen.Items[selectIndex]);
                //i += 1;
                NumOfOpen.Items[selectIndex] = Convert.ToInt32(NumOfOpen.Items[selectIndex])+1;
                StationHelper.SaveStation(NameStation, LincStation, NumOfOpen, "Изменить", selectIndex);
                
            }

        }
        
        void ListStatinNameMouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (e.Clicks == 2 && e.Button == MouseButtons.Left)
                {
                    var selectIndex = ListStatinName.SelectedIndex;
                    PlayStation(selectIndex);
                    
                }
            }
            catch (Exception)
            {

            }
        }
        
        public void MainFormLoad(object sender, EventArgs e)
        {
            StationHelper.LoadStation(NameStation, LincStation, NumOfOpen);
            LoadMainForm();
            var settings = SettingsHelper.LoadSetting();
            var  cSaveChecked = settings.SaveChecked;
            var volum = settings.Volum;
            var  mute = settings.Mutee;
            var  selectIndex = settings.SelectIndex;
            var  IsPlay = settings.IsPlay;
            
            if (cSaveChecked == true)
            {
                this.BackColor = ColorHelper.LoadColor();

                //TODO В отдельный метод к хуям!!!!
                _setForm.cSave.Checked = cSaveChecked; tVolum.Value = volum; _mute = !mute; ListStatinName.SelectedIndex = selectIndex; 
                Player.Volume(volum);
                BMuteClick(sender, e);
                if (IsPlay)
                { PlayStation(ListStatinName.SelectedIndex); }
                
                сохраниятьСостояниеToolStripMenuItem.Checked = cSaveChecked;

            }

            Save = cSaveChecked;

        }


        public void LoadMainForm()
        {
            ListStatinName.Items.Clear();
            foreach (string s in StationHelper.LoadStation(NameStation, LincStation, NumOfOpen).Items)
            {
                ListStatinName.Items.Add(s);
            }

            tVolum.Maximum = 100;
            tVolum.Minimum = 0;
            tVolum.Value = 100;
            MenuItemAdd();
        }

        //Заполнение в меню списка станций
        public void MenuItemAdd()
        {

            this.deleteToolStripMenuItem.DropDownItems.Clear();
            this.playToolStripMenuItem.DropDownItems.Clear();

            foreach (string st in NameStation.Items)
            {
                var del = new ToolStripMenuItem();
                var play = new ToolStripMenuItem();
                del.Text = play.Text = st;
                del.Click += new System.EventHandler(this.MenuItemClick);
                this.deleteToolStripMenuItem.DropDownItems.Add(del);
                play.Click += new System.EventHandler(this.PlayItemClick);
                this.playToolStripMenuItem.DropDownItems.Add(play);

            }




        }
        public void WriteToFile(string operation,int Index)
        {

            StationHelper.SaveStation(NameStation, LincStation, NumOfOpen,operation,Index);

            this.deleteToolStripMenuItem.DropDownItems.Clear();
            this.playToolStripMenuItem.DropDownItems.Clear();
            MenuItemAdd();
            ColorHelper.SaveColor(this.BackColor.ToArgb());
            StationHelper.LoadStation(NameStation, LincStation, NumOfOpen);
        }
        
        
        public void DelStation(int SelectIndex)
        {
            var dellString = "Удалить " + ListStatinName.Items[SelectIndex].ToString() + "?";
            var rezult = MessageBox.Show(ListStatinName, dellString, "Подтвеждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezult == System.Windows.Forms.DialogResult.Yes)
            {
               // _nameStation.Items.RemoveAt(SelectIndex);
               // LincStation.Items.RemoveAt(SelectIndex);
                StationHelper.SaveStation(NameStation, LincStation, NumOfOpen,"Удалить",SelectIndex);
                StationHelper.LoadStation(NameStation, LincStation, NumOfOpen);
                _operation = null;
                LoadMainForm();
            }


        }
        public void PlayItemClick(object sender, EventArgs e)
        {
            var menuString = ((ToolStripMenuItem)sender).Text;
            ListStatinName.SelectedIndex = NameStation.Items.IndexOf(menuString);
            PlayStation(NameStation.Items.IndexOf(menuString));


        }
        public void MenuItemClick(object sender, EventArgs e)
        {


            var menuString = ((ToolStripMenuItem)sender).Text;
            var index = NameStation.Items.IndexOf(menuString);
            DelStation(index);


        }
        private void LabelText()
        {
            if (Player.Satus()[2] != "")
            {
                pRadioBut.Visible = true;
                RadioButtonChanger.RadioButton((new[] { rb1, rb2, rb3 }).ToList<System.Windows.Forms.RadioButton>());
                
            }
            StatusLabel.Text = Player.Satus()[0] + " " + Player.Satus()[2];
            LRadioText.Text = Player.Satus()[1];
            


        }

        
        
        private void Timer1Tick(object sender, EventArgs e)
        {

            lTime.Text = _time.AddSeconds(Player.CurrentPosition()).ToLongTimeString();
            progressBar1.Value = Player.BuferingProgress();
            LabelText();

        }
       
        
        private void TextNameTextChanged(object sender, EventArgs e)
        {
            bAdd.Text = _operation;
        }
        
        
        private void TextUrlTextChanged(object sender, EventArgs e)
        {
            bAdd.Text = _operation;
        }
        
        
        private void AddToolStripMenuItemClick(object sender, EventArgs e)
        {
            bAddCheck.PerformClick();
        }
        
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Player.Close();
            Close();
        }
        
        private void VolumScroll(object sender, EventArgs e)
        {

            Player.Volume(tVolum.Value);
            StatusLabel.Text = "Громкость " + tVolum.Value.ToString() + "%";
        }
       
        private void ОбЭтомТворенииToolStripMenuItemClick(object sender, EventArgs e)
        {
            var ebout = new Ebout {Visible = true};
        }
        
        private void PlayToolStripMenuItem1Click(object sender, EventArgs e)
        {
            _selectIndex = ListStatinName.SelectedIndex;
            PlayStation(_selectIndex);
        }
        private void УдалитьToolStripMenuItemClick(object sender, EventArgs e)
        {
            _operation = "Удалить";
            _selectIndex = ListStatinName.SelectedIndex;
            Operations(_operation);

        }
        private void ИзменитьToolStripMenuItemClick(object sender, EventArgs e)
        {
            _operation = "Изменить";
            _selectIndex = ListStatinName.SelectedIndex;
            Operations(_operation);

        }
        private void ПереименоватьToolStripMenuItem1Click(object sender, EventArgs e)
        {
            _operation = "Переименовать";
            _selectIndex = ListStatinName.SelectedIndex;
            Operations(_operation);


        }
        public void Operations(string operation)
        {
            switch (operation)
            {
                case "Изменить":
                    {
                        TextUrl.Enabled = true;

                        panel1.Visible = true;
                        bAdd.Text = "Изменить";

                        if (_doOperation)
                        {
                            NameStation.Items[_selectIndex] = TextName.Text;
                            LincStation.Items[_selectIndex] = TextUrl.Text;

                            WriteToFile("Изменить",_selectIndex);
                            _doOperation = false;
                            bAdd.Text = "Ok";

                        }

                        {

                            if (_selectIndex >= 0)
                            {

                                TextName.Text = NameStation.Items[_selectIndex].ToString();
                                TextUrl.Text = LincStation.Items[_selectIndex].ToString();
                            }
                        }

                    }
                    LoadMainForm();
                    break;

                case "Удалить":
                    {

                        DelStation(_selectIndex);
                        LoadMainForm();
                        break;
                    }
                case "Переименовать":
                    {
                        bAdd.Text = "Переименовать";
                    }

                    if (_doOperation)
                    {
                        NameStation.Items[_selectIndex] = TextName.Text;
                        LincStation.Items[_selectIndex] = TextUrl.Text;
                        WriteToFile("Переименовать",_selectIndex);
                        _doOperation = false;
                        TextUrl.ReadOnly = false;
                        TextUrl.Enabled = true;
                        bAdd.Text = "Ok";
                        TextName.Text = TextUrl.Text = null;

                    }
                    {

                        panel1.Visible = true;


                        TextUrl.Enabled = false;
                        if (_selectIndex >= 0)
                        {
                            TextName.Text = NameStation.Items[_selectIndex].ToString();
                            TextUrl.Text = LincStation.Items[_selectIndex].ToString();
                        }
                        LoadMainForm();
                        break;
                    }
                case "Добавить":
                    {
                        if (_doOperation)
                        {
                            NameStation.Items.Add(TextName.Text);
                            LincStation.Items.Add(TextUrl.Text);
                            StationHelper.SaveStation(NameStation, LincStation, NumOfOpen,"Добавить",NameStation.Items.Count-1);

                            TextName.Text = TextUrl.Text = null;
                            LoadMainForm();
                            MenuItemAdd();
                            bAdd.Text = "OK";
                            _doOperation = false;
                        }
                        else
                        {
                            bAdd.Text = "Добавить";
                            TextName.Text = TextUrl.Text = null;
                        }

                        LoadMainForm();
                        break;
                    }

            }


        }
        private void BAddClick(object sender, EventArgs e)
        {

            if (TextName.Text != null && TextUrl.Text != null && TextName.Text != "" && TextUrl.Text != "")
            {
                _doOperation = true;
                Operations(_operation);
            }

            else MessageBox.Show(panel1, "Не введено одно из полей!", "Посмотри внимательней))", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ButtonPanelCloseClick(object sender, EventArgs e)
        {
            bAddCheck.Text = "Добавить";
            addToolStripMenuItem.Enabled = true;
            panel1.Visible = false;
            TextName.Text = TextUrl.Text = null;
            _operation = null;
        }
        private void НастройкиПрограммыToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        private void Form1FormClosing(object sender, FormClosingEventArgs e)
        {

            var chek = _setForm.cSave.Checked;
            _setForm.Dispose();
            _setForm.Close();
            if (Player.Satus()[1].Length <= 1)
            { IsPlay = false; }
            else{IsPlay=true;}
            SettingsHelper.SaveSetting(new Settings(chek, tVolum.Value, _mute, ListStatinName.SelectedIndex,IsPlay));
        }

        private void BMuteClick(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(bMute, "Вкл/Выкл Звук");
            if (_mute)
            {
                bMute.BackgroundImage = MIr.Properties.Resources.volOn1;
                _mute = !_mute;
                Player.Mute(_mute);

            }
            else
            {
                bMute.BackgroundImage = MIr.Properties.Resources.volOff;
                _mute = !_mute;
                Player.Mute(_mute);

            }

        }

        private void BAddCheckClick(object sender, EventArgs e)
        {
            panel1.Visible = !panel1.Visible;
            if (panel1.Visible)
            {
                bAddCheck.Text = "Скрыть";
                addToolStripMenuItem.Enabled = false;

            }
            else
            {
                bAddCheck.Text = "Добавить";
                addToolStripMenuItem.Enabled = true;
            }


            _operation = "Добавить";
            Operations(_operation);

            TextName.Text = TextUrl.Text = null;
        }
        public void ColorForm(object sender, EventArgs e)
        {
            // ColorDialog colorDialog = new ColorDialog(); 
            // colorDialog.Color = this.BackColor;
            //  colorDialog.ShowDialog();

            // this.BackColor = colorDialog.Color;
            // WorkFromFiles.SaveColor(this.BackColor.ToArgb());
            // colorDialog.Dispose();
        }

        private void ЦветToolStripMenuItemClick(object sender, EventArgs e)
        {

        }

        private void FontToolStripMenuItemClick(object sender, EventArgs e)
        {

            fontDialog1.ShowDialog();


        }

       

        private void ListStatinNameSelectedValueChanged(object sender, EventArgs e)
        {
            _selectIndex = ListStatinName.SelectedIndex;

        }


        private void VolumValueChanged(object sender, EventArgs e)
        {
            var sToolTip = "Громкость " + tVolum.Value;
            toolTip2.SetToolTip(tVolum, sToolTip);
            
        }

        private void Label4MouseHover(object sender, EventArgs e)
        {
            if (LRadioText.Text != "" && Player.Satus()[1] != "")
            {
                var sToolTip = "Радио: " + ListStatinName.Items[LincStation.SelectedIndex] + "\n" + "Текст: " + Player.Satus()[1];
                toolTip2.SetToolTip(LRadioText, sToolTip);
               
            }
        }

       
        public string SToolTipMake(string toolTipOld, int index)
        {
            var sToolTip1 = ListStatinName.Items[index].ToString();
            var sToolTipTime1 = _time.AddSeconds(Player.CurrentPosition()).ToLongTimeString();
            if (Player.Satus()[2] != "" && index == LincStation.SelectedIndex)
            { sToolTip1 += "\n" + "Время воспроизведения " + sToolTipTime1; }

            { sToolTip1 += "\n" + "Количество прослушиваний: " + NumOfOpen.Items[index]; }

            return sToolTip1;
        }

        

        private void BAddCheckMouseHover(object sender, EventArgs e)
        {
            if (bAddCheck.Text == "Добавить")
            {  toolTip2.SetToolTip(bAddCheck, "Добавить станцию");}

            else {toolTip2.SetToolTip(bAddCheck, bAddCheck.Text);}
            
        }

       

        private void TextNameMouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(TextName, "Имя станции");
        }

        private void TextUrlMouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(TextUrl, "Адрес станции");
        }

        private void BAddMouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(bAdd, "Сохранить");
        }

        private void ButtonPanelCloseMouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(ButtonPanelClose, "Скрыть");
        }
        //Кнопка плей-стоп
        private void Button1Click1(object sender, EventArgs e)
        {
          
            
             if (ListStatinName.SelectedIndex == (-1)||Player.Satus()[0]=="")
            { bPlayStop.Text = "Старт!"; }

           if (Player.Satus()[1] =="")
            {
               timer1.Start();

                if (ListStatinName.SelectedIndex != -1)
                   PlayStation(ListStatinName.SelectedIndex);
                else { ListStatinName.SelectedIndex = 0; PlayStation(ListStatinName.SelectedIndex); }
                

            }
           else { Player.Close(); bPlayStop.Text = "Старт!"; pRadioBut.Visible = false; progressBar1.Value = 0; timer1.Stop(); LabelText();
           StatusLabel.Text = "Остановлено"; lTime.Text = "0:00:00"; IsPlay = false;
           }// ListStatinName.SelectedIndex = (-1); }
        }

        private void BPlayStopMouseHover(object sender, EventArgs e)
        {
            string sToolTip = null;
            if (bPlayStop.Text == "Старт!")
                sToolTip = "Начать воспроизведение";
            else sToolTip = "Остановить воспроизведение";

            toolTip2.SetToolTip(bPlayStop, sToolTip);
        }



        private void ToolStripMenuItem1Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog {Color = this.BackColor};

            if (colorDialog.ShowDialog() ==DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
                ColorHelper.SaveColor(this.BackColor.ToArgb());
            }
            
            colorDialog.Dispose();

        }

        private void НастройкиToolStripMenuItem1Click(object sender, EventArgs e)
        {
            _setForm.StartPosition = FormStartPosition.CenterParent;

            _setForm.Show();
        }

        private void СохраниятьСостояниеToolStripMenuItemClick(object sender, EventArgs e)
        {
            _setForm.cSave.Checked = сохраниятьСостояниеToolStripMenuItem.Checked;
            SettingsHelper.SaveSetting(new Settings(сохраниятьСостояниеToolStripMenuItem.Checked, tVolum.Value, _mute, ListStatinName.SelectedIndex,IsPlay));
        }

        private void НастройкиПрограммыToolStripMenuItemMouseEnter(object sender, EventArgs e)
        {
            сохраниятьСостояниеToolStripMenuItem.Checked = _setForm.cSave.Checked;
        }

        private void ListStatinNameMouseHover1(object sender, EventArgs e)
        {

            

            //Всплывающее над станциямиstring
         //   sToolTip = "";
        //    if (ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position)) != (-1) && ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString() != sToolTip)
            {
             //   sToolTip = ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString();
              //  toolTip2.SetToolTip(ListStatinName, sToolTip);
            }

        }
        
        
        void ListStatinNameMouseDown(object sender, MouseEventArgs e)
        {
            
            //При наведении указателя на элемент
            if (e.Button == MouseButtons.Right && ListStatinName.IndexFromPoint(e.X, e.Y) != (-1))
            {

                ContextStationMenu.Show(MousePosition);
                ListStatinName.SelectedIndex = ListStatinName.IndexFromPoint(e.X, e.Y);

            }
            
            else { if (e.Button == MouseButtons.Right) ListStatinName.ClearSelected(); ContextStationMenu.Close(); ContextStationMenu.Hide(); }
            //Всплывающее окошко
            try
            {
                //Доработать!!!
               // if (ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString() != _nameStation.Items[ListStatinName.SelectedIndex].ToString())
               if(ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))!=LincStation.SelectedIndex)
                { _tempForToolTip = null; }
                
                string sToolTipTime1 = _time.AddSeconds(Player.CurrentPosition()).ToLongTimeString();
                if (toolTip2.Active == true && ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString()
                    + "\n" + "Количество прослушиваний: " + NumOfOpen.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))]
                    + _tempForToolTip
                    != SToolTip)
                {
                    if (ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString() == NameStation.Items[LincStation.SelectedIndex].ToString())
                        _tempForToolTip = "\n" + "Время воспроизведения " + sToolTipTime1;


                    {
                        toolTip2.Active = false;
                        SToolTip = "";
                        if (ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position)) != (-1) && ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString() != SToolTip)
                        {

                            toolTip2.Active = true;
                            SToolTip = ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString() +
                             "\n" + "Количество прослушиваний: " + NumOfOpen.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))] + _tempForToolTip;
                            // if (ListStatinName.Items[ListStatinName.IndexFromPoint(ListStatinName.PointToClient(Cursor.Position))].ToString()==_nameStation.Items[ListStatinName.SelectedIndex].ToString())
                            //  sToolTip+="\n" + "Время воспроизведения " + sToolTipTime1;
                            toolTip2.SetToolTip(ListStatinName, SToolTip);
                        }
                    }
                }
               
            }
            catch (Exception)
            { }


            
        }

        private void ListStatinName_DragDrop(object sender, DragEventArgs e)
        {

        }

      

    }
}
