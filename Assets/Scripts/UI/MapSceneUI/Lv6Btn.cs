using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv6Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(6);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
