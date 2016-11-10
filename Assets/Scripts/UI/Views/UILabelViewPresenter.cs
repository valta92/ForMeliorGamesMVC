using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UILabelViewPresenter : ViewPresenter 
{
    [SerializeField]
    private Text _label;

    public void SetText(string text, bool isUpperCase = false)
    {
        _label.text = isUpperCase ? text.ToUpper() : text;
    }

    public void SetTextColor(Color color)
    {
        _label.color = color;
    }
}
