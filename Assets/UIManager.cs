using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    int kills = 0;
    int keys;
    public TMP_Text killsText;
    public TMP_Text keysText;
    public Slider detectionSlider;
    public RawImage[] livesImages;
    public PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        killsText.text = "Kills: " + kills.ToString();
        keysText.text = "Keys: " + keys.ToString();
        UpdateHealth();
    }

    public void KillEnemy()
    {
        kills++;
        killsText.text = "Kills: " + kills.ToString();
    }

    public void GrabKey()
    {
        keys++;
        keysText.text = "Keys: " + keys.ToString();
    }

    public void UpdateHealth()
    {
        int health = playerData.Health;
        if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            for (int i = 0; i < livesImages.Length; i++)
            {
                if (i >= health) livesImages[i].enabled = false;
            }
        }
    }

    public void SetDetectionValue(int value)
    {
        detectionSlider.value = value;
    }
}
