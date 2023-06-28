using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int maxHP;
    private int currentHP;
    Rigidbody rb;
    Vector3 dir;
    float speed = 0.1f;
    Vector3 pos_Start = new Vector3(0.0f,0.5f,0.0f);
    Vector3 oldRot;

    public int GetCurrentHP()
    {
        return currentHP;
    }
    public void HealCurrentHP()
    {
        if(currentHP < maxHP) { currentHP++; }
    }
    public void DamageCurrentHP()
    {
        currentHP--;
    }
    private void Start()
    {
        maxHP = 5;
        currentHP = maxHP;
        rb = GetComponent<Rigidbody>();

        pos_Start = transform.position;
        transform.rotation = Quaternion.identity;
        oldRot = Vector3.zero;
        dir = Vector3.zero;

        StartCoroutine(CheckPosition());
        StartCoroutine(IeRotation());
    }

    private void Update()
    {
        if (currentHP <= 0)//all die
        {
            Managers.Player.SetAlive(false);
            Managers.Bluetooth.Clear();
            Managers.Bluetooth.DisConnect();
            Managers.Scene.LoadScene("LoadScene");
        }
    }

    IEnumerator IeRotation()
    {
        float timeOut = 0f;
        yield return new WaitUntil(() => Managers.Bluetooth.GetData() != Vector3.zero);
        //yield return new WaitUntil(() => Managers.Game.GetStart());
        while (true)
        {
            yield return null;

            if (oldRot == Managers.Bluetooth.GetData())
            {
                if (timeOut >= 1f)
                {
                    dir = Vector3.zero;
                    timeOut = 0f;
                }
                else
                {
                    timeOut += Time.deltaTime;
                }
            }
            else
            {
                dir = new Vector3(Managers.Bluetooth.GetY(), 0, -Managers.Bluetooth.GetX());
            }

            if (dir.magnitude < 3.0)
                dir.Set(0, 0, 0);

            rb.position += dir * speed * Time.deltaTime;
            oldRot = Managers.Bluetooth.GetData();
        }
    }

    IEnumerator CheckPosition()//die
    {
        while (true)
        {
            yield return null;
            if (transform.position.y < -10.0f)
            {
                currentHP--;
                Debug.Log("currentHP =" + currentHP);
                transform.position = pos_Start;
                transform.rotation = Quaternion.identity;
            }
        }
    }
}

