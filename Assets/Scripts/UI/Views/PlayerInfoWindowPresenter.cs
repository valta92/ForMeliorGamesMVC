using UnityEngine;
using System.Collections;

public class PlayerInfoWindowPresenter : ViewPresenter 
{
    public UILabelViewPresenter HealthPointsLabel;
    public UILabelViewPresenter DamagePointsLabel;
    public UILabelViewPresenter ArmorPointsLabel;
	

    public override void Show()
    {
        base.Show();
    }

    public override void Hide()
    {
        base.Hide();
    }
}
