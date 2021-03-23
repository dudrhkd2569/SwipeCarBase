using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0.0f;
    Vector2 starPos;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.speed = 1.0f;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - starPos.x);
            this.speed = swipeLength / 500.0f;
            GetComponent<AudioSource>().Play();
        }
            
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }

}
