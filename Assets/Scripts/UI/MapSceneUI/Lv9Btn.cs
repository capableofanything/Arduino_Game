using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv9Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(9);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
