using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBound : MonoBehaviour {
    //public float minX, maxX, minY, maxY;
    private GameObject Player;
    //private Vector3 camSize;
	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Player"); //take data form Player object
        //camSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, -10f)); //take camera size
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 temp = Player.transform.position; //take player position
        //minX = minX + camSize.x;
        //maxX = maxX - camSize.x;
        //minY = minY + camSize.y;
        //maxY = maxY - camSize.y;


        //Condition for X dimention
        //if (temp.x > maxX - camSize.x)
        //{
        //    temp.x = maxX - camSize.x;
        //}
        //else
        //    if (temp.x < minX + camSize.x)
        //{
        //    temp.x = minX + camSize.x;
        //}


        ////Condition for Y dimention
        //if (temp.y > maxY - camSize.y)
        //{
        //    temp.y = maxY - camSize.y;
        //}
        //else
        //    if (temp.y < minX + camSize.y)
        //{
        //    temp.y = minY + camSize.y;
        //}


        transform.position = temp; //player position is camera position
	}
}
