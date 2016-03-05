using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InternetRadio.Common
{
   public class Settings
    {
        public bool SaveChecked { get; set; }
        public int Volum { get; set; }
        public bool Mutee { get; set; }
        public int SelectIndex{ get; set; }
        public bool IsPlay{ get; set; }

        public Settings()
        {
        }

        public Settings(bool saveChecked, int volum, bool mutee, int selectIndex, bool isPlay)
        {
            SaveChecked = saveChecked;
            Volum = volum;
            Mutee = mutee;
            SelectIndex = selectIndex;
            IsPlay = isPlay;
        }
    }
}

