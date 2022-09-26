using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBallScrips : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spdBallChk;
    public float ballSpeed; //  скорость полета снаряда
    public   GameObject player;
    public GameObject ball;

    public Transform playerpos;
    public Vector3 vect;
    public  float atackSpeed; // скорость атаки игрока
    private float atackSpeed1;
    public static List<GameObject> balls = new List<GameObject>(); // список снарядов
    public static List<Vector3> targets = new List<Vector3>(); //список  направлений полета для каждого снаряда
    public Transform parrent;//привязка к канвасу
    public Vector2 z;
    void Start()
    {
        ballSpeed = (spdBallChk.transform.position.y - player.transform.position.y)/3;
        atackSpeed1 = atackSpeed;
                    
         vect = new Vector3(player.transform.position.x, player.transform.position.y, 100);
        //playerpos.position = vect;
        //playerpos.position = new Vector3(player.transform.position.x, player.transform.position.y, 0);
    }
   

    // Update is called once per frame
    void Update()
    {
        atackSpeed1 -= Time.deltaTime;
        if (0>= atackSpeed1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                

                balls.Add((GameObject)Instantiate(ball, player.transform.position, Quaternion.identity));
                balls[balls.Count - 1].transform.localScale=new Vector3((float)2,2,2);
                balls[balls.Count - 1].transform.position = player.transform.position;
                balls[balls.Count - 1].transform.SetParent(parrent);

                var asd1 = Input.mousePosition;
                asd1.z = 100;

                targets.Add(Camera.main.ScreenToWorldPoint(asd1));
               

                atackSpeed1 = atackSpeed;
            }
        }
        for (int i = 0; i < balls.Count; i++)
        {
            
            balls[i].transform.position = Vector3.MoveTowards(balls[i].transform.position, targets[i], ballSpeed * Time.deltaTime);
            if (balls[i].transform.position == targets[i])
            {
                Destroy(balls[i], 0.0f);
                balls.RemoveAt(i);
                targets.RemoveAt(i);
            }
        }
       
            
            
            //ball.transform.position+= (target-player.transform.position ).normalized * ballSpeed * Time.deltaTime;
        
        
    }
}
