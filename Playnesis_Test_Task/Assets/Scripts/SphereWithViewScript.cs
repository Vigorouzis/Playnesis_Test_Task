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
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "SphereWithView")
                {
                    _textAboveObject.gameObject.SetActive(true);
                }
            }
        }
    }
}