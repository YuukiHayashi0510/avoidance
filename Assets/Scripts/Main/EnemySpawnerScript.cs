using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject Enemy;

    GameObject EnemyClone;

    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 1)
        {
            EnemyClone =  Instantiate(Enemy,this.transform.position + this.transform.right * Random.Range(-10.0f,10.0f), this.transform.rotation);

            Destroy(EnemyClone, 5.0f);
            timer = 0;
        }
    }
}
