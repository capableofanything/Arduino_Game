using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiedBtn : MonoBehaviour
{
    public void Onclicked()
    {
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
