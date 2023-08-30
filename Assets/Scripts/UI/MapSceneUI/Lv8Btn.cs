using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv8Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(8);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
