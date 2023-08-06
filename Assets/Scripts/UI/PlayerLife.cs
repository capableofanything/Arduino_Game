using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    int life;
    GameObject[] Life;
    void Start()
    {
        life = Managers.Player.GetCurrentHP();
        Life = new GameObject[life];
        for(int i=0; i<life; i++)
        {
            Life[i] = this.transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
        life = Managers.Player.GetCurrentHP();
        if (life != Life.Length)
        {
            Life[life].SetActive(false);
        }

    }
}
