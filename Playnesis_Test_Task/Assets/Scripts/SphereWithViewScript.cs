using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SphereWithViewScript : InteractiveObject
{
    [SerializeField] private Text _textAboveObject;

   

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.transform.TryGetComponent<SphereWithViewScript>(out var component) && component != null)
                {
                    var canvas = GameObject.Find("Canvas");
                    
                    var text = Instantiate(_textAboveObject, new Vector3(-137.7633f, -58.13029f, 0),
                        transform.rotation);
                    //Parent to the panel
                    text.transform.SetParent(canvas.transform, false);
                }
            }
        }
    }
}