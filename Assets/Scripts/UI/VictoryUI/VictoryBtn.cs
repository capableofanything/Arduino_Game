using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryBtn : MonoBehaviour
{
    public float speed = 0.5f;
    float time = 0f;

    void Start()
    {
        Managers.Sound.Play("Albatross");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;

        if (time > 1)
        {
            Managers.Scene.LoadScene("HomeScene");

        }
    }
}
