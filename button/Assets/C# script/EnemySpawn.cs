using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform SpawnPos;
    public GameObject enemy;
    private GameObject g_ob;
    public Transform parrent;
    public static List<GameObject> enemyObject = new List<GameObject>();
    public float spawnSpeed;
    //GameObject[] en;
    void Start()
    {
        StartCoroutine(SpawnKD());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Repeat()
    {
        StartCoroutine(SpawnKD());
    }
    IEnumerator SpawnKD()
    {
        yield return new WaitForSeconds(spawnSpeed);//оператор ожидания 
        if (enemyObject.Count < 5)
        {
            float x = Random.Range(-900, 900); ;
            SpawnPos.localPosition = new Vector3(x, 700, 0);

            enemyObject.Add((GameObject)Instantiate(enemy, SpawnPos.localPosition, Quaternion.identity));
            
            enemyObject[enemyObject.Count-1].transform.SetParent(parrent);
            enemyObject[enemyObject.Count - 1].transform.localScale = enemy.transform.localScale / 5;
            enemyObject[enemyObject.Count - 1].transform.localPosition = new Vector3(x, 500, 0);
            // спавнит обект
            Repeat();//запускает репит 
        }
    }

}
