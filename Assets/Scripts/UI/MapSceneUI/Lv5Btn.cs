using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv5Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(5);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
