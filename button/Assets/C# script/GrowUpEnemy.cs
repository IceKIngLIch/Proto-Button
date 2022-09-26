using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowUpEnemy : MonoBehaviour
{
    public GameObject enemyStandart;
    public  float  GrowTime;
        private float GrowTime1 ;
   // public float GrowTime1;
   // public List<GameObject> enemyObject = GetComponent <EnemySpawn.enemyObject > ();//=EnemySpawn.enemyObject;
    // Start is called before the first frame update
    public GameObject figthScene;
    void Start()
    {
        GrowTime1 = GrowTime;
    }

    // Update is called once per frame
    //private float timeGrow=1;
    void Update()
    {
        GrowTime1 -= Time.deltaTime;
        if (GrowTime1 < 0)
        {
            if (EnemySpawn.enemyObject.Count != 0)
            {
                for (int i = 0; i < EnemySpawn.enemyObject.Count; i++)
                {

                    if (EnemySpawn.enemyObject[i].transform.localScale != enemyStandart.transform.localScale)
                    {
                        //yield return new WaitForSeconds(1);
                        EnemySpawn.enemyObject[i].transform.localScale += enemyStandart.transform.localScale / 5;
                    }
                    else
                    {

                    }
                }
            }
            GrowTime1 = GrowTime;
        }
    }
}
