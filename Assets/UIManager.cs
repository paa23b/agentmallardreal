using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    int kills = 0;
    public TMP_Text killsText;
    public RawImage[] livesImages;
    public PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void KillEnemy()
    {
        kills++;
        killsText.text = "Kills: " + kills.ToString();
    }

    public void UpdateHealth()
    {
        int health = playerData.Health;
        for (int i = 0; i < livesImages.Length; i++)
        {
            if (i >= health) livesImages[i].enabled = false;
        }
    }
}
