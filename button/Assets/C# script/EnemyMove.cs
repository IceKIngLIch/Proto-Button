using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public GameObject enemyStandart;
    public GameObject targetPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemySpawn.enemyObject.Count != 0)
        {
            for (int i = 0; i < EnemySpawn.enemyObject.Count; i++)
            {
                if (EnemySpawn.enemyObject[i].transform.localScale==enemyStandart.transform.localScale)
                {
                    EnemySpawn.enemyObject[i].transform.LookAt(targetPlayer.transform.localPosition);
                    //EnemySpawn.enemyObject[i].transform.position = Vector3.Lerp(EnemySpawn.enemyObject[i].transform.position,targetPlayer.transform.position,speed);
                    EnemySpawn.enemyObject[i].transform.position += (targetPlayer.transform.position - EnemySpawn.enemyObject[i].transform.position).normalized * speed * Time.deltaTime;
                    //EnemySpawn.enemyObject[i].OnTriggerEnter(Collider other)
                }

            }
        }
        
    }
}
