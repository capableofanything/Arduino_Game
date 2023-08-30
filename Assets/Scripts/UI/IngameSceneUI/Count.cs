using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    private float Timer = 0.0f;
    public Text Num;  //text
    public bool finishedCount = false;
    private void Update()
    {

        if (Timer <= 5.0f)
        {
            finishedCount = false;
            Timer += Time.deltaTime;

            if (Timer < 1.0f)
            {
                Num.text = "3";
            }

            if (Timer > 2.0f)
            {
                Num.text = "2";
            }

            if (Timer > 3.0f)
            {
                Num.text = "1";
            }

            if (Timer >= 4.0f)
            {
                Num.text = "GO!";
            }
            if (Timer >= 5.0f)
            {
                Timer = 0.0f;
                finishedCount= true;
                gameObject.SetActive(false);
            }
        }

    }
}