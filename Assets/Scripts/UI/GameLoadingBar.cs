using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameLoadingBar : MonoBehaviour
{

    public bool b = true;
    public Slider slider;
    public float speed = 0.1f;

    float time = 0f;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (b)
        {
            time += Time.deltaTime * speed;
            slider.value = time;

            if (time > 1)
            {
                //나중에 원하는 select map -> 원하는 맵으로 이동
                //bluetooth connect도 여기서 되면 좋을듯 대신 씬전환할 때 connect 끊기는거 해결해야됨
                Managers.Scene.LoadScene("InGameScene1");
            
            }
        }
    }


}

