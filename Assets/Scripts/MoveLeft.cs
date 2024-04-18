using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour


{
    public float speed;

    BirdController birdScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(birdScript.isAlive == true) 
       {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
       }
    }

    void Awake()
    {
        birdScript = GameObject.Find("Red_Bird_0").GetComponent<BirdController>();
    }
}
