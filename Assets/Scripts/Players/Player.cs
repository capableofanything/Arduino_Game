using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private int maxHP;
    [SerializeField]
    private int currentHP;
    Rigidbody rb;
    Vector3 dir;
    float speed = 10.0f;
    float wait_run_ratio = 0;
    Vector3 currentPos;
    float DamagedTime = 0;
    Animator anim;
    bool instantiateDiedPrefab = true;
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
    public void ChangeSpeed(float sp)
    {
        speed = sp;
    }
    private void Awake()
    {
        maxHP = 5;
        currentHP = maxHP;
    }
    private void Start()
    {

        rb = GetComponent<Rigidbody>();
        anim= GetComponent<Animator>();

        transform.rotation = Quaternion.identity;
        currentPos = gameObject.transform.position;

        dir = Vector3.zero;

        StartCoroutine(IeRotation());
        StartCoroutine(CheckPosition());
    }

    private void Update()
    {
        StartCoroutine(DamagedTimeWait());

        if (currentHP <= 0)//all die
        {
            Managers.Player.SetAlive(false);
            Managers.Bluetooth.Clear();
            Managers.Bluetooth.DisConnect();
            if (instantiateDiedPrefab) 
            { 
                Managers.Resource.Instantiate("Background/Died");
                instantiateDiedPrefab = false;
            }
        }
        //test용
        if (Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
            transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    IEnumerator DamagedTimeWait()//맞았다면 1초 있다 데미지 들어옴
    {
        if (DamagedTime == 1.0f)
        {
            yield return new WaitForSeconds(1.0f);
            DamagedTime = 0.0f;
        }
    }
    IEnumerator IeRotation()
    {
        //float timeOut = 0f;
        yield return new WaitUntil(() => Managers.Bluetooth.GetData() != Vector3.zero);

        while (true)
        {
            yield return null;

            dir = new Vector3(Managers.Bluetooth.GetY(), 0, -Managers.Bluetooth.GetX());
            dir.Normalize();
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 0.5f);
            rb.position += dir * speed * Time.deltaTime;
            if(dir == Vector3.zero)
            {
                wait_run_ratio = Mathf.Lerp(wait_run_ratio,0,10.0f*Time.deltaTime);
                anim.SetFloat("wait_run_ratio", wait_run_ratio);
                anim.Play("WAIT_RUN");
            }
            else
            {
                wait_run_ratio = Mathf.Lerp(wait_run_ratio, 1, 10.0f * Time.deltaTime);
                anim.SetFloat("wait_run_ratio", wait_run_ratio);
                anim.Play("WAIT_RUN");
            }

            currentPos = rb.position;
        }
    }
    IEnumerator CheckPosition()
    {
        while (true)
        {
            yield return null;
            if (transform.position.y < -1f)
            {
                transform.position = new Vector3(0,0,0);
            }
            if (currentPos.z >= 17.0f)
            {
                rb.position = new Vector3(currentPos.x, currentPos.y, 17.0f);
            }
            if (currentPos.z <= -17.0f)
            {
                rb.position = new Vector3(currentPos.x, currentPos.y, -17.0f);
            }
            if (currentPos.x >= 17.0f)
            {
                rb.position = new Vector3(17.0f, currentPos.y, currentPos.z);
            }
            if (currentPos.x <= -17.0f)
            {
                rb.position = new Vector3(-17.0f, currentPos.y, currentPos.z);
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Damage")&&DamagedTime==0.0f)
        {
            DamagedTime = 1.0f;
            anim.SetTrigger("Damage");
            anim.Play("DAMAGED");
            currentHP--;
            //DamagedTime = 1.0f;
        }
        if (currentPos.z >= 17.0f)
        {
            rb.position = new Vector3(currentPos.x,currentPos.y, 17.0f);
        }
        if(currentPos.z <= -17.0f)
        {
            rb.position = new Vector3(currentPos.x, currentPos.y, -17.0f);
        }
        if (currentPos.x >= 17.0f)
        {
            rb.position = new Vector3(17.0f, currentPos.y, currentPos.z);
        }
        if (currentPos.x <= -17.0f)
        {
            rb.position = new Vector3(-17.0f, currentPos.y, currentPos.z);
        }
    }


}

