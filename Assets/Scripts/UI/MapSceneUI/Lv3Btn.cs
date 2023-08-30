using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv3Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(3);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
