using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    private float speed;
   
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("Road").GetComponent<RoadController>()._speed * 10;

        transform.Translate(Vector3.back * Time.deltaTime * speed);
        if (transform.position.z < -150)
        {
            Destroy(gameObject);
            
        }
    }
   
   
}
