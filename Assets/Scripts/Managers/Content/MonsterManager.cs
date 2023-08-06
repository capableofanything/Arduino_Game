using System;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager
{
    GameObject bomb;
    List<GameObject> bomb_child_list = new();
    GameObject show;
    List<GameObject> show_child_list = new();
    public void SetBomb(GameObject bomb) 
    {
        this.bomb = bomb;
        for(int i=0;i<25;i++)
        {         
            bomb_child_list.Add(this.bomb.transform.GetChild(i).gameObject);
        }    
    }

    public void SetShow(GameObject show)
    {
        this.show = show;
        for (int i = 0; i < 25; i++)
        {
            show_child_list.Add(this.show.transform.GetChild(i).gameObject);
        }
    }
    public void ActivateBomb(int num) { bomb_child_list[num].SetActive(true); }
    public void DeactivateBomb(int num) { bomb_child_list[num].SetActive(false); }
    public void ActivateShow(int num) { show_child_list[num].SetActive(true); }
    public void DeactivateShow(int num) { show_child_list[num].SetActive(false); }
}
