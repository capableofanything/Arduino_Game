using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScene1 : BaseScene
{
    public override void Clear()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        //Managers.Bluetooth.Clear();

        base.Init();
        SoundBgmPlay();
        SpawnBackground();
        SpawnField();
        SpawnMenu();
        SpawnPlayer();
        SpawnConnectBtn();
        SpawnBombAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void SpawnPlayer()
    {
        GameObject go = Managers.Resource.Load<GameObject>("Prefabs/Players/Player_Chan");
        if (go != null)
        {
            go = Managers.Resource.Instantiate("Players/Player_Chan");
            Managers.Player.SetPlayer(go.GetComponent<Player>());
        }
    }
    private void SpawnBackground()
    {
        Managers.Resource.Instantiate("Background/Background");
    }
    private void SpawnField()
    {
        GameObject go = Managers.Resource.Instantiate("Fields/Fields_");
        if (go != null)
        {
            Managers.Field.SetField(go.GetComponent<Field>());
            Managers.Field.Init();
        }
        Managers.Resource.Instantiate("Fields/wall");
    }
    private void SpawnConnectBtn()
    {
        Managers.Resource.Instantiate("UI/Connect");
    }
    private void SpawnMenu()
    {
        GameObject go = Managers.Resource.Instantiate("UI/Menu");
        Managers.Menu.SetMenu(go);
    }
    private void SpawnBombAll()
    {
        GameObject go = Managers.Resource.Instantiate("Attacks/Bomb_All");
        Managers.Monster.SetBomb(go);
        GameObject go1 = Managers.Resource.Instantiate("Attacks/Show_All");
        Managers.Monster.SetShow(go1);

    }
}
