using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHurt : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("plswork");
        PlayerData data = other.gameObject.GetComponent<PlayerData>();
        if (data != null)
        {
            data.Health--;
            Debug.Log("murdermurder");
            UIManager ui = GameObject.Find("Canvas").GetComponent<UIManager>();
            ui.UpdateHealth();
        }
    }
}