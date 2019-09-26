using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coinpickup : MonoBehaviour
{
    public int coinsOnMap;
    public int count;
    public AudioSource ping;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        ping = GetComponent<AudioSource>();
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        if(coinsOnMap == 0)
        {
            
            TimeAttack script = (TimeAttack) gameObject.GetComponent(typeof(TimeAttack));
            script.Finish();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            ping.Play();
            countText.GetComponent<TweenTransforms>().Begin();
            coinsOnMap--;

        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
    }

    int GetCount()
    {
        return count;
    }

    public void CoinRegister()
    {
        coinsOnMap++;
    }
}
