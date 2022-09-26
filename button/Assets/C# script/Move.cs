using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject  player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && this.transform.localPosition.x>=-960+player.transform.localScale.x/2)
        {
            player.transform.position += (new Vector3(-speed,0,0));
            
        }
        if (Input.GetKey(KeyCode.D) && player.transform.localPosition.x <= 960 - player.transform.localScale.x/2)
        {
          
            player.transform.position += (new Vector3(  speed,0,0));
        }

    }
}
