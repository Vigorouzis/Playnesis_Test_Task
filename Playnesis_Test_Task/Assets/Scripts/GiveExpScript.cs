using System.Collections;
using System.Collections.Generic;
using ScriptableValues;
using UnityEngine;

public class GiveExpScript : InteractiveObject
{
    [SerializeField] private QuantitiesForChanges _quantities;

    protected override void BasicAction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit, Mathf.Infinity))
            {
                if (hit.transform.TryGetComponent<GiveExpScript>(out var component) && component != null)
                {
                    _playerIndicators.experience += _quantities.addExp;
                }
            }
        }
    }
}