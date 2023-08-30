using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
{

    public void Onclicked()
    {
        Managers.Resource.Instantiate("UI/Quit_Ingame");
        Time.timeScale = 0.0f;
    }

    void Start()
    {

    }

    void Update()
    {


    }
}
