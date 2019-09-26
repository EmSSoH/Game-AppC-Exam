using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Carlvl()
    {
        SceneManager.LoadScene(1);
    }
    public void Airlvl()
    {
        SceneManager.LoadScene(2);
    }
    public void Shooterlvl()
    {
        SceneManager.LoadScene(3);
    }
    public void BacK()
    {
        
    }
}
