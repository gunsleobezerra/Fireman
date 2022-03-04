using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class dead_line : MonoBehaviour
{
    public GameObject[] deadlines;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D player)
    {

        if (player.tag == "Player")
        {

            Debug.Log("Enter deadline!");
            deadlines = GameObject.FindGameObjectsWithTag("Enemy_S");

            foreach (GameObject item in deadlines)
            {
                Debug.Log(item);
                item.GetComponent<Spaen_enemy>().time_seconds = 0.1f;
            }

        }


    }


}
