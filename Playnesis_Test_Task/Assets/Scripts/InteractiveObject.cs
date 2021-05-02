using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableValues;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    protected Camera _camera;

    
    public Renderer _renderer;
    protected float _maxRange = 10f;
    [SerializeField] protected PlayerIndicators _playerIndicators;
    private static readonly int Property = Shader.PropertyToID("_Outline");


    private void Start()
    {
        _camera = Camera.main;
        _renderer.material.shader = Shader.Find("Outlined/Custom");
    }

    private void Update()
    {
        BasicAction();
        CheckDistance();
    }

    protected virtual void CheckDistance()
    {
        var position = transform.position;


        if (Vector3.Distance(_playerIndicators.position, position) <= _maxRange)

        {
            _renderer.material.SetFloat(Property, 0.5f);
        }

        else
        {
            _renderer.material.SetFloat(Property, 0f);
        }
    }

    protected virtual void BasicAction() { }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 10f);
    }
}