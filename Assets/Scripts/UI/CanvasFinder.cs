using UnityEngine;
using System.Collections;

public class CanvasFinder
{
    private static Canvas _mainCanvas;

    public static Canvas GetMainCanvas()
    {
        if (_mainCanvas == null) 
        {
            Canvas[] canvas = GameObject.FindObjectsOfType(typeof(Canvas)) as Canvas[];
            for (int i = 0; i < canvas.Length; i++) 
            {
                if (canvas[i].gameObject.name == "Canvas") 
                {
                    _mainCanvas = canvas[i];
                    break;
                }
            }
        }

        return _mainCanvas;
    }
}
