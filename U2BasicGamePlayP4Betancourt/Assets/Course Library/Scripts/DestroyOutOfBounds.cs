using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -25;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        } 
        else if (transform.position.y < bottomLimit) 
        {
            Destroy(gameObject);
        }
    }
}
