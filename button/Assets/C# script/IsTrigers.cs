using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsTrigers : MonoBehaviour
{
    
    public GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
     void OnCollisionEnter(Collision collision)//робит
    {
        if (collision.gameObject.name != "Enemy(Clone)")
        {
            if (collision.gameObject.name == "Player")
            {
                Destroy(this, 0.0f);
                // Выполнять код, если соприкоснулся с объектом «Player»
            }
            if (collision.gameObject.name == "damageBall(Clone)")
            {
                Destroy(this , 0.0f);
                Destroy(collision.gameObject, 0.0f);

            }
        }
    }
     void OnTriggerEnter(Collider other)
    { 
        
        if (other.gameObject.name=="Player")
        {
            Destroy(this,0.0f);
            // Выполнять код, если соприкоснулся с объектом «Player»
        }
        if (other.gameObject.name == "damageBall(CLone)")
        {
            Destroy(other, 0.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //OnTriggerEnter();
    }
}
