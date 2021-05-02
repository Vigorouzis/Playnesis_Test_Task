using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableValues;
using UnityEngine;

public class CapsuleForUseWithExpScript : InteractiveObject
{
    
   
    private static readonly int Property = Shader.PropertyToID("_Color");

    private void FixedUpdate()
    {
        CheckDistance();
    }

    protected override void CheckDistance()
    {
        base.CheckDistance();
        var position = transform.position;
        if (Vector3.Distance(_playerIndicators.position, position) <= _maxRange)
        {
            if (_playerIndicators.experience < 30)
            {
                Debug.Log("yellow");
                _renderer.material.SetColor(Property, Color.yellow);
            }
            else
            {
                Debug.Log("green");
                _renderer.material.SetColor(Property, Color.green);
            }
        }
    }
}