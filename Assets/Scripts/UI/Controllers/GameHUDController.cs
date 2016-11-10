using UnityEngine;
using System.Collections;

public class GameHUDController : BaseWindowController
{
    private GameHUDPresenter _gameHUDPresenter;

    public GameHUDController()
    {
        _type = WindowType.GameHUDWindow;
        _presenter = CreateWindowView(_canvas,_type);

        _gameHUDPresenter = _presenter as GameHUDPresenter;
        _presenter.Show();

        _gameHUDPresenter.ReturnToMenuButton.OnClickButton += LevelManager.Instance.ReturnToMenu;
    }
}
