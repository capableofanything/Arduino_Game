using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitXBtn : MonoBehaviour
{
    GameObject parent;
    public void Onclicked()
    {
        Time.timeScale = 1.0f;
        Managers.Resource.Destroy(parent);
    }
    void Start()
    {
        parent = transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
