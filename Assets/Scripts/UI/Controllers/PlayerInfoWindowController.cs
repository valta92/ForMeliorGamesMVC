using UnityEngine;
using System.Collections;
using System;

public class PlayerInfoWindowController : BaseWindowController {

    private PlayerModel _playerModel;
    private PlayerInfoWindowPresenter _playerInfoWindowPresenter;

    public PlayerInfoWindowController(PlayerData data)
    {
        _playerModel = new PlayerModel(data.health, data.damage, data.armor);

        _type = WindowType.PlayerInfoWindow;
        _presenter = CreateWindowView(_canvas,_type);

        _playerInfoWindowPresenter = _presenter as PlayerInfoWindowPresenter;
        _presenter.Show();

        _playerModel.DamagePointsChange += OnPlayerPropertiesChanged;
        _playerModel.ArmorPointsChange += OnPlayerPropertiesChanged;
        _playerModel.HealthPointsChange += OnPlayerPropertiesChanged;

        UpdateUI();
    }


    public void UpdateUI()
    {
        _playerInfoWindowPresenter.HealthPointsLabel.SetText("Health : " + _playerModel.HealthPoints);
        _playerInfoWindowPresenter.DamagePointsLabel.SetText("Damage : " + _playerModel.DamagePoints);
        _playerInfoWindowPresenter.ArmorPointsLabel.SetText("Armor : " + _playerModel.ArmorPoints);
    }

    public void OnPlayerPropertiesChanged(object sender, EventArgs e)
    {
        UpdateUI();
    }
}
