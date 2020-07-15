using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<EnemyMovement>(out EnemyMovement enemy))
        {
            Vector3 newLocalScale = collision.transform.localScale;
            newLocalScale.x *= -1;
            collision.transform.localScale = newLocalScale;

            enemy.ChangeDirection();
        }
    }
}
