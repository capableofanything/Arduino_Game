using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv4Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(4);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
