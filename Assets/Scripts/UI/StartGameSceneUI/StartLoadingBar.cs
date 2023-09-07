using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StartLoadingBar : MonoBehaviour
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

                Managers.Scene.LoadScene("Scenes/HomeScene");
            }
        }
    }


}

