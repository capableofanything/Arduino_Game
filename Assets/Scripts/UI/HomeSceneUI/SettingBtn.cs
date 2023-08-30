using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingBtn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Resource.Instantiate("UI/Quit");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
