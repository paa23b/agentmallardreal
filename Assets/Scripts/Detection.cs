using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    public int DetectionScore = 0;
    UIManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectionScore > 200)
        {
            print("found");
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            manager.SetDetectionValue(DetectionScore);
            print(other.gameObject + " enter");
            if (DetectionScore < 201)
            {


                DetectionScore = DetectionScore + 1;
            }

        }
    }
}
