using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    private bool start = false;
    public void OnConnect()
    {
        start = true;
    }
    private void Update()
    {
        if(start)
        {
            start = false;
            Managers.Scene.LoadScene("Demo_Game");
        }
    }
}
