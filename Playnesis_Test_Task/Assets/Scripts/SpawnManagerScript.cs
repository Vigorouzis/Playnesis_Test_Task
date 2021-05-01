using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> _gameObjectsList;

    void Start()
    {
        SpawnPrefab();
    }


    void SpawnPrefab()
    {
        for (var i = 0; i < _gameObjectsList.Count; i++)
        {
            var x = Random.Range(-15f, 13f);
            
            var z = Random.Range(-10f, 16f);
            Instantiate(_gameObjectsList[i], new Vector3(x, 0.5f, z), Quaternion.identity);
        }
    }
}