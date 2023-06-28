using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseScene : MonoBehaviour     //��� �� script�� ��ӹ޴� Ŭ����(���� MonoBehaviour)
{
    [SerializeField]
    protected string soundBgmName;                  //�ش� ���� BGM �̸�

    private void Awake()
    {
        Init();
    }
    protected virtual void Init()                   //EventSystem(Prefab)���� @EventSystem(GameObject)����
    {
        Object obj = GameObject.FindObjectOfType(typeof(EventSystem));      //==GameObject.FindObjectOfType<EventSystem>();
        if (obj == null)
        {
            Managers.Resource.Instantiate("UI/EventSystem").name = "@EventSystem";
        }
    }
    public abstract void Clear();
    
    protected void SoundBgmPlay()
    {
        Managers.Sound.Play(soundBgmName, Define.Sound.Bgm,1.0f,0.2f);
    }
}
