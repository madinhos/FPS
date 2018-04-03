using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibles : MonoBehaviour {
    private GameObject player;
    private float speed = 10.0f;

    void Update()
    {
        player = GameObject.Find("FPSController");
        float step = speed * Time.deltaTime;

        float dist = Vector3.Distance(player.transform.position, transform.position);

        Vector3 lookAt = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);



            if (dist <= 5)
             { 
                    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
            }

        
    }
}
