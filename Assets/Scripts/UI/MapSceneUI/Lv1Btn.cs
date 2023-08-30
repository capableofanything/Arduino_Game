using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(1);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
