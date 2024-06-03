using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -speed, 0f);
        if(transform.position.y < -1f)
            Destroy(gameObject);
    }
}