using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : BaseScene
{
    public override void Clear()
    {
        
    }
    protected override void Init()
    {
        base.Init();
        SoundBgmPlay();
        SpawnButton();
    }
    private void SpawnButton()
    {
        GameObject go = Managers.Resource.Instantiate("UI/Start");
    }
}
