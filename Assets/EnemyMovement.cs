using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{
    Vector3 originalPos;
    float updateSpeed;
    float direction;
    float maxDistance = 5f;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        SetRandomMovement();
        InvokeRepeating(nameof(SetRandomMovement), 2f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += direction * updateSpeed * Time.deltaTime;

        if (Mathf.Abs(pos.x - originalPos.x) > maxDistance)
        {
            direction *= -1;
        }

        transform.position = pos;
    }
    void SetRandomMovement()
    {
        updateSpeed = Random.Range(0.5f, 2f);
        direction = Random.Range(0, 2) == 0 ? -1 : 1;  
    }
}
