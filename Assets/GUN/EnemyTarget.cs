using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTarget : MonoBehaviour
{
    public GameObject player;
    public PlayerData data;
    public float health = 50f;

    void Awake()
    {
        player = GameObject.Find("agent_mallard (1)");
        data = player.GetComponent<PlayerData>();

    }
    public void TakeDamage (float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            data.Health = data.Health - 1;
        }
    }
    void Die()
    {
        UIManager ui = GameObject.Find("Canvas").GetComponent<UIManager>();
        ui.KillEnemy();
        Destroy(gameObject);
    }
}
