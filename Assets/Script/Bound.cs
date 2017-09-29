using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bound : MonoBehaviour {
    private float minX, maxX, minY, maxY;

	// Use this for initialization
	void Start () {
        //Only Uncomment form line 11 to line 15 when you want to use fixed camera
        //Vector3 bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        //minX = -bound.x + 0.5f;
        //maxX = bound.x - 0.5f;
        //minY = -bound.y + 0.5f;
        //maxY = bound.y - 0.5f;
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        minX = -bound.x + 0.5f;
        maxX = bound.x - 0.5f;
        minY = -bound.y + 0.5f;
        maxY = bound.y - 0.5f;
        Vector3 temp = transform.position;
        if (temp.x > maxX)
        {
            temp.x = maxX;
        }else
            if (temp.x < minX)
        {
            temp.x = minX;
        }
        if (temp.y > maxY)
        {
            temp.y = maxY;
        }else
            if (temp.y < minY)
        {
            temp.y = minY;
        }
        transform.position = temp;
	}
}
