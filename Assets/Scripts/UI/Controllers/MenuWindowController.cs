using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MenuWindowController : BaseWindowController
{

    private MenuWindowPresenter _menuWindowPresenter;

    public MenuWindowController()
    {
        _type = WindowType.MenuWindow;
        _presenter = CreateWindowView(_canvas,_type);

        _menuWindowPresenter = _presenter as MenuWindowPresenter;
        _presenter.Show();

        _menuWindowPresenter.EasyDifficultyButton.OnClickButton += () => LevelManager.Instance.StartGame(DiffultyEnum.Easy);
        _menuWindowPresenter.HardDifficultyButton.OnClickButton += () => LevelManager.Instance.StartGame(DiffultyEnum.Hard);
        _menuWindowPresenter.ExitGameButton.OnClickButton += LevelManager.Instance.QuitGame;
    }

    public override void Destroy()
    {
        base.Destroy();
    }
        
}
