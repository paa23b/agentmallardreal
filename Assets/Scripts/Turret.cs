using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
   
    public bool Found = false;
    public GameObject sight;
    Detection detection;
    public GameObject projectile;
    public float launchVelocity = 700f;
    public Transform player;
    public int Bullettime;
    // Start is called before the first frame update
    void Awake()
    {
        sight = GameObject.Find("Sight");
        detection = sight.GetComponent<Detection>();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (detection.DetectionScore > 200 && Found == false)
        {
            Bullettime = 0;
            Found = true;
        }

        if (Found == true)
        {

            transform.LookAt(player);

            Bullettime++;


            if (Bullettime == 500)
            {
                GameObject enemybullet = Instantiate(projectile, transform.position, Quaternion.identity);
                enemybullet.GetComponent<Rigidbody>().AddRelativeForce(gameObject.transform.forward * launchVelocity);
                Bullettime = 0;
            }

        }
    }
}
