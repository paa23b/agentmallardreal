using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        UIManager ui = GameObject.Find("Canvas").GetComponent<UIManager>();
        ui.KillEnemy();
        Destroy(gameObject);
    }
}
