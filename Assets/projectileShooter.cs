using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileShooter : MonoBehaviour
{


    GameObject prefab;

    public int enemyOnMap;

    void Start()
    {
        prefab = Resources.Load("Bullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(prefab) as GameObject;
            bullet.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
            Destroy(bullet, 5);
        }

        if(enemyOnMap == 0)
        {
            TimeAttack script = (TimeAttack)gameObject.GetComponent(typeof(TimeAttack));
            script.Finish();
        }
    }

    public void enemyRegister()
    {
        enemyOnMap++;
    }

    public void enemyDeath()
    {
        enemyOnMap--;
    }
}
