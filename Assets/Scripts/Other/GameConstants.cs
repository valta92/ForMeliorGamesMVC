using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace GameConstants
{
    public class PlayerDiffucultyInfo
    {

        public static readonly Dictionary<DiffultyEnum, PlayerData> PlayerDiffuculty = new Dictionary<DiffultyEnum, PlayerData>() {
            { DiffultyEnum.Easy , new PlayerData(100,50,25) },
            { DiffultyEnum.Hard , new PlayerData(50,20,5) }
        };
    }


}

public enum DiffultyEnum
{
    Easy = 0 ,
    Hard = 1
}

public enum WindowType
{
    MenuWindow,
    PlayerInfoWindow,
    GameHUDWindow,
}