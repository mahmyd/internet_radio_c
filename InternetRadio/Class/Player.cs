using System;
using WMPLib;
using InternetRadio;

namespace MIr.Class
{
    public class Player
    {
     private readonly WindowsMediaPlayer _player = new WindowsMediaPlayer();

     public void OpenFile(string fileUrl)
     {
         
         
         if (_player.playState.ToString() != "wmppsPlaying")
         {
             _player.network.bufferingTime = 2;
             _player.URL = fileUrl;
            
         }
         else { _player.close(); OpenFile(fileUrl); }
         
     }
    
     public double CurrentPosition()
     {
         return _player.controls.currentPosition;
     }
     public int BuferingProgress()
     {
         return _player.network.bufferingProgress;
     }
     public string MediaInfo()
     {
         return _player.currentMedia.getItemInfo("Title");
         
     }
     public void Close()
     {
         _player.close();
     }
     public int Volume(int volume)
     {
         _player.settings.volume = volume;
         return volume;
     }
     public bool Mute(bool mute)
     {
         _player.settings.mute = mute;
         return _player.settings.mute;
     }
     public string[] Satus()
     {
        
         string[] str={"","",""};
         if (_player.playState.ToString() == "wmppsTransitioning")
         { str[0] = "Буферизация " +_player.network.bufferingProgress.ToString() + "%"; }
         if (_player.playState.ToString() == "wmppsPlaying")
         { str = _player.status.Split(new Char[] { '\"' }); }
         if (_player.settings.mute)
         { str[0] = "Звук Выкл"; }
         return str;
     }

    



    }

}
