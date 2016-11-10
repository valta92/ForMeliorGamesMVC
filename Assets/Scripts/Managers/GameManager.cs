using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public DiffultyEnum Difficulty { get { return _difficulty; } }
    private DiffultyEnum _difficulty;

    void Start()
    {
        if(LevelManager.Instance != null)
        {
            _difficulty = LevelManager.Instance.Difficulty;
            var data = GameConstants.PlayerDiffucultyInfo.PlayerDiffuculty[_difficulty];
            var HUDController = new GameHUDController();
            var playerInfoController = new PlayerInfoWindowController(data);
        }
            

       
    }
}
