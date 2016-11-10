using UnityEngine;
using System.Collections;

public abstract class BaseWindowController 
{   

    public WindowType Type { get { return _type; } }

    protected Canvas _canvas;
    protected ViewPresenter _presenter;
    protected WindowType _type;
	
    public BaseWindowController()
    {
        _canvas = CanvasFinder.GetMainCanvas();
    }

    public void ShowWindow()
    {
        _presenter.Show();
    }

    public void HideWindow()
    {
        _presenter.Hide();
    }

    public bool IsActive()
    {
        return _presenter.gameObject.activeSelf;
    }


    protected ViewPresenter CreateWindowView(Canvas canvas, WindowType type)
    {
        GameObject windowGO = canvas.transform.FindChild(type.ToString()).gameObject;
        windowGO.transform.SetParent(canvas.transform, false);
        windowGO.SetActive(false);
        ViewPresenter presenter = windowGO.GetComponent<ViewPresenter>();
        presenter.Controller = this;
        return presenter;
    }

    public virtual void Destroy()
    {
        _presenter.Controller = null;
        _presenter.DestroyView();
    }

}
