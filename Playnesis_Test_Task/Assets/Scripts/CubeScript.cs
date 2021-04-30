using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    private int _destroyCount = 0;
    private Camera _camera;

    void Start()
    {
        _camera = Camera.main;
    }

   private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
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