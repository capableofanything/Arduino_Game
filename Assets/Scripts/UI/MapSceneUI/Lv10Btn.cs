using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv10Btn : MonoBehaviour
{
    public void Onclicked()
    {
        Managers.Level.SetCurrentLevel(10);
        Managers.Scene.LoadScene("GameLoadingScene");
    }

}
