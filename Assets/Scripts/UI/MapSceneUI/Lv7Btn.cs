using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv7Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(7);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
