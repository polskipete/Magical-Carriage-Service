using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public float _speed = 2.0f;
    float offset;
    float faster;
    Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("IncreaseSpeed", 30f, 30f);
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset += Time.deltaTime * _speed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(0, - offset));
        
    }
    void IncreaseSpeed()
    {
        if(_speed < 10)
        {
            _speed++;
        }

    }
}
