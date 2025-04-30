using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasers : MonoBehaviour
{
    public GameObject laserDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            UIManager ui = GameObject.Find("Canvas").GetComponent<UIManager>();
            ui.GrabKey();
            laserDoor.SetActive(false);
            Destroy(gameObject);
        }
    }
}
