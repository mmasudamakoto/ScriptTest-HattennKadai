using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

    public class Boss
    {

        private int mp = 53;
        private int Magic = 5;


        
        public void Attak()
        {
            this.mp -= Magic;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");

            
        }
    }
    void Start()
    {
       

        Boss Boss = new Boss();

        Boss.Attak();

        int mp = 53;


        for (int i = 0; i < 11; i++)
        {
            mp -= i;
        }
        Debug.Log("魔法攻撃をした。残りMPは"+mp+"。");


        if (mp <= 5)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

       


