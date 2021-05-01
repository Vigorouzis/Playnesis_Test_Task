using System;
using System.Collections;
using System.Collections.Generic;
using ScriptableValues;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    protected Camera _camera;
    public Renderer rend;
    private float _maxRange = 10f;

    [SerializeField] protected GameObject _player;
    protected static readonly int Property = Shader.PropertyToID("_Outline");


    private void Start()
    {
        _camera = Camera.main;
        rend.material.shader = Shader.Find("Outlined/Custom");
    }

    private void Update()
    {
        BasicAction();
        CheckDistance();
    }

    protected virtual void CheckDistance()
    {
        if (Vector3.Distance(gameObject.transform.position, _player.transform.position) <= _maxRange)
        {
            if (Physics.Raycast(transform.position, (_player.transform.position - transform.position), out var hit,
                _maxRange))
            {
                if (hit.transform.CompareTag("Player"))
                {
                    rend.material.SetFloat(Property, 0.5f);
                }
            }
        }
        else
        {
            rend.material.SetFloat(Property, 0);
        }
    }

    protected virtual void BasicAction() { }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 10f);
    }
}