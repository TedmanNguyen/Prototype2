using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 20.0f;
    public float topBoundary = 20;
    public float lowBoundary = -10;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //Boundaries to destroy animals/food 
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowBoundary)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }

}
