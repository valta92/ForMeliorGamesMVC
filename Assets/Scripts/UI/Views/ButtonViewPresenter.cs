using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public delegate void TemplateEvent();

public class ButtonViewPresenter : ViewPresenter , ISelectHandler
{

    public event TemplateEvent OnSelectButton
    {
        add
        {
            _OnSelectedButton += value;
        }
        remove
        {
            _OnSelectedButton -= value;
        }
    }
    public event TemplateEvent OnClickButton
    {
        add
        {
            _OnClickedButton += value;
        }
        remove
        {
            _OnSelectedButton -= value;
        }
    }

    private event TemplateEvent _OnClickedButton;
    private event TemplateEvent _OnSelectedButton;

    [SerializeField]
    private Button _button;

    void Awake()
    {
        if(_button == null)
            _button = this.gameObject.GetComponent<Button>();

        _button.onClick.AddListener(OnClick);
            
    }

    protected virtual void OnClick()
    {
        if (_OnClickedButton != null)
            _OnClickedButton();
    }


    public void OnSelect(BaseEventData eventData)
    {
        if (_OnSelectedButton != null)
            _OnSelectedButton();
    }
}
