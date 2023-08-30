using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelectBtn : MonoBehaviour
{
    public void OnClicked()
    {
        Managers.Scene.LoadScene("MapScene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
