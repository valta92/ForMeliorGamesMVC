using System;

public class PlayerModel
{
    
    public event EventHandler HealthPointsChange
    {
        add
        {
            _healthPointsChanged += value;
        }
        remove
        {
            _healthPointsChanged -= value;
        }
    }
    public event EventHandler DamagePointsChange
    {
        add
        {
            _damagePointsChanged += value;
        }
        remove
        {
            _damagePointsChanged -= value;
        }
    }
    public event EventHandler ArmorPointsChange
    {
        add
        {
            _armorPointsChanged += value;
        }
        remove
        {
            _armorPointsChanged -= value;
        }
    }


    public int HealthPoints
    {
        get
        {
            return _healthPoints;
        }
        set
        {

            if (_healthPoints != value)
            {
                _healthPoints = value;
                if (_healthPointsChanged != null)
                {
                    _healthPointsChanged(this, null);
                }
            }

        }
    }
    public int DamagePoints
    {
        get
        {
            return _damagePoints;
        }
        set
        {

            if (_damagePoints != value)
            {
                _damagePoints = value;
                if (_damagePointsChanged != null)
                {
                    _damagePointsChanged(this, null);
                }
            }

        }
    }
    public int ArmorPoints
    {
        get
        {
            return _armorPoints;
        }
        set
        {

            if (_armorPoints != value)
            {
                _armorPoints = value;
                if (_armorPointsChanged != null)
                {
                    _armorPointsChanged(this, null);
                }
            }

        }
    }


    private event EventHandler _healthPointsChanged;
    private event EventHandler _damagePointsChanged;
    private event EventHandler _armorPointsChanged;

    private int _healthPoints;
    private int _damagePoints;
    private int _armorPoints;

    public PlayerModel(int health, int damage, int armor)
    {
        _healthPoints = health;
        _damagePoints = damage;
        _armorPoints = armor;
    }
}
