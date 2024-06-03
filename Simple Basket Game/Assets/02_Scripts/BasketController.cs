using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    GameObject gameDirector;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        gameDirector = GameObject.Find("GameDirector");
        score = gameDirector.GetComponent<GameDirector>().score;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if(hit.collider.name == "stage")
                {
                    float x = Mathf.RoundToInt(hit.point.x);
                    float z = Mathf.RoundToInt(hit.point.z);
                    transform.position = new Vector3(x, 0, z); //transform.position.y
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Apple")
            score++;
        else if(collision.gameObject.tag == "Bomb")
            score = score / 2;

        gameDirector.GetComponent<GameDirector>().score = score;
    }
}