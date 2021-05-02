using System.Collections;
using System.Collections.Generic;
using ScriptableValues;
using UnityEngine;

public class SpawnManagerScript : MonoBehaviour
{
    [SerializeField] private List<GameObject> _gameObjectsList;
    [SerializeField] private CoordinatesForSpawn _coordinates;

    private enum SpawnType
    {
        Random,
        ScriptableObject,
    }

    [SerializeField] private SpawnType _spawnType;

    void Start()
    {
        SpawnPrefab();
    }


    void SpawnPrefab()
    {
        if (_spawnType == SpawnType.Random)
        {
            foreach (var t in _gameObjectsList)
            {
                var x = Random.Range(-15f, 13f);

                var z = Random.Range(-10f, 16f);
                if (t.TryGetComponent<CapsuleCollider>(out var component) && component != null)
                {
                    Instantiate(t, new Vector3(x, 1.4f, z), Quaternion.identity);
                }
                else
                {
                    Instantiate(t, new Vector3(x, 0.5f, z), Quaternion.identity);
                }
            }
        }
        else
        {
            Instantiate(_gameObjectsList[0], _coordinates.destroyCubeSpawnCoordinates, Quaternion.identity);
            Instantiate(_gameObjectsList[1], _coordinates.expSphereSpawnCoordinates, Quaternion.identity);
            Instantiate(_gameObjectsList[2], _coordinates.damageCapsuleSpawnCoordinates, Quaternion.identity);
            Instantiate(_gameObjectsList[3], _coordinates.textSphereSpawnCoordinates, Quaternion.identity);
            Instantiate(_gameObjectsList[4], _coordinates.playerSpawnCoordinates, Quaternion.identity);
            Instantiate(_gameObjectsList[5], _coordinates.teleportSpawnCoordinates, Quaternion.identity);
            Instantiate(_gameObjectsList[6], _coordinates.spawnToAnotherSceneCubeCoordinates, Quaternion.identity);
            Instantiate(_gameObjectsList[7], _coordinates.capsuleForUseWithExperienceCoordinates, Quaternion.identity);
            
        }
    }
}