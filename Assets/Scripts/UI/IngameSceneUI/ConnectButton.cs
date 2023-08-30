using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectButton : MonoBehaviour
{
    public void OnClicked()
    {
        Managers.Bluetooth.Connect();
    }

    void Update()
    {
        if (Managers.Bluetooth.GetOnConnected())
        {
            GameObject go = Managers.Resource.Instantiate("Managers/CheckingGame");
            Managers.Game.SetCheck(go.GetComponent<CheckingGame>());
            CheckingGame.ChangeLevel(Managers.Level.GetCurrentLevel());
            Managers.Resource.Destroy(gameObject);
        }
    }
}
