using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobackBtn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Scene.LoadScene("HomeScene");
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
