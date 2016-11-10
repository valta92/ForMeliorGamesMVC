using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

    private MenuWindowController _menuWindowController;

    void Start()
    {
        _menuWindowController = new MenuWindowController();
    }
}
