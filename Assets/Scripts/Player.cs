using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _hit;

    private int _coinCount;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            _hit?.Invoke();
        }

        if (collision.gameObject.TryGetComponent<Coin>(out Coin coin))
        {
            _coinCount++;
            Debug.Log("Amount of coins: " + _coinCount);
            Destroy(collision.gameObject);
        }
    }
}
