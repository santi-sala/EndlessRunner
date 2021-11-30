using System;

[Serializable]
public class SaveState
{
    public int Highscore { set; get; }
    public int Coins { set; get; }
    public DateTime LastSaveTime { set; get; }


    public SaveState()
    {
        Highscore = 0;
        Coins = 0;
        LastSaveTime = DateTime.Now;
    }

}
