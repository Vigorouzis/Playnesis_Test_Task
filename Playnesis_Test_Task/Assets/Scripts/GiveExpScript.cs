using System.Collections;
using System.Collections.Generic;
using ScriptableValues;
using UnityEngine;

public class GiveExpScript : InteractiveObject
{
    [SerializeField] private PlayerIndicators _playerIndicators;

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit))
            {
                if (hit.transform.name == "ExpSphere")
                {
                    _playerIndicators.experience += 10;
                }
            }
        }
    }
}