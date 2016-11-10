using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ViewPresenter : MonoBehaviour 
{
    public BaseWindowController Controller { get; set; }

    public RectTransform ViewBounds;

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

    public void DestroyView()
    {
        Destroy(gameObject);
    }
}