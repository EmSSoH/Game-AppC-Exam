using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    GameObject player;
    projectileShooter script;
    AudioSource boom;
    // Start is called before the first frame update
    void Start()
    {
        boom = GetComponent<AudioSource>();

        player = GameObject.FindWithTag("Player");
        script = (projectileShooter)player.GetComponent(typeof(projectileShooter));
        script.enemyRegister();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 3, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "bullet")
        {
           // boom.Play();
            Destroy(gameObject);
            
        }
    }

    private void OnDestroy()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>().Play();
        script.enemyDeath();
    }
}
