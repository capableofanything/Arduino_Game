using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DemoGameScene : BaseScene//At the beginning of the this scene, responsible for the essential spawn.
{

    protected override void Init()
    {
        base.Init();            
        SoundBgmPlay();
        SpawnField();     
        SpawnPlayer();
        SpawnPattern();
        SpawnConnectBtn();
    }


    private void SpawnField()
    {
        GameObject go = Managers.Resource.Instantiate("Fields/Fields");
        if(go != null) 
        {
            Managers.Field.SetField(go.GetComponent<Field>());
            Managers.Field.Init();
        }
    }
    private void SpawnPlayer()
    {
        GameObject go = Managers.Resource.Load<GameObject>("Prefabs/Players/Player");
        if(go != null) 
        {
            go = Managers.Resource.Instantiate("Players/Player");
            Managers.Player.SetPlayer(go.GetComponent<Player>());
        }
    }
    private void SpawnConnectBtn()
    {
        Managers.Resource.Instantiate("UI/Connect");
    }
    private void SpawnPattern()
    {
        GameObject go = Managers.Resource.Instantiate("Game/Pattern");
        Managers.Game.SetPattern(go.GetComponent<Pattern>());
    }

    public override void Clear()
    {

    }
}
