using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportToScene1Script : InteractiveObject
{
    
    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                if (hit.transform.TryGetComponent<TeleportToScene1Script>(out var component) && component != null)
                {
                    SceneManager.LoadScene("SampleScene");
                  
                }
            }
        }
    }
}