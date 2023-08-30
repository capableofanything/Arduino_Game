using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_gobackhome_Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Time.timeScale = 1.0f;
        Managers.Scene.LoadScene("HomeScene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
