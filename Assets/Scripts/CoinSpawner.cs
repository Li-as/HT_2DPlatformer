using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private Coin _template;

    private void Start()
    {
        for (int i = 0; i < _spawnPoints.childCount; i++)
        {
            Vector3 position = _spawnPoints.GetChild(i).position;
            Instantiate(_template, position, Quaternion.identity);
        }
    }
}
