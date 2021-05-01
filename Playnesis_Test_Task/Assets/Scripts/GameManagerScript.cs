using System.Collections;
using System.Collections.Generic;
using ScriptableValues;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] private PlayerIndicators _playerIndicators;
    [SerializeField] private Text _gameOverText;

    void Update()
    {
        GameOver();
    }

    private void GameOver()
    {
        if (_playerIndicators.health <= 0)
        {
            _gameOverText.gameObject.SetActive(true);
        }
    }
}