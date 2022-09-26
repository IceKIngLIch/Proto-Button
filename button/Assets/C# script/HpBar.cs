using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HpBar : MonoBehaviour
{
    public Image BarImage;
    public Text BarText;
    private float hp = 100;
    public GameObject target;
    //public Gradient Color;
    //private Transform _anchor;
    //private Camera _cameraMain;
    //
    //private DamageableEntity _entity;
   
   
        
   
    // Start is called before the first frame update
    void Start()
    {
        BarText.text = hp.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (true)//getDamage == true)
        {
            hp += -25;
            BarText.text = hp.ToString();
            BarImage.transform.localScale = new Vector3( (BarImage.transform.localScale.x * hp / 100), BarImage.transform.localScale.y, BarImage.transform.localScale.z);

        }
        if (hp <= 0)
        { 
        //вызов метода дестрой обжект
        }
    }
}
