using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClicked()
    {
        Managers.Scene.LoadScene("GameLoadingScene");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
