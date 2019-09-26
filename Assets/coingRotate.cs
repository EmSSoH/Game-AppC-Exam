using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coingRotate : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Coinpickup script = (Coinpickup)player.GetComponent(typeof(Coinpickup));
        script.CoinRegister();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 3, 0);
    }
}
