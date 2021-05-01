using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : InteractiveObject
{
    private int _destroyCount = 0;


    

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.transform.name == "CubeForDelete")
                {
                    _destroyCount++;
                    Debug.Log(_destroyCount);
                    if (_destroyCount == 3)
                    {
                        Destroy(hit.transform.gameObject);
                        _destroyCount = 0;
                    }
                }
            }
        }
    }
}