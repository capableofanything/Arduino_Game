using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv2Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(2);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
