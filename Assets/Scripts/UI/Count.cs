using UnityEngine;
using System.Collections;



public class Count : MonoBehaviour
{
    private int Timer = 0;

    GameObject Num_A;   //1��
    GameObject Num_B;   //2��
    GameObject Num_C;   //3��
    GameObject Num_GO;

    void Awake()
    {
        Timer = 0;
        GameObject go = Managers.Resource.Instantiate("UI/Count_Text");
        Num_A = Util.FindChild(go, "1",true);
        Num_B = Util.FindChild(go, "2", true);
        Num_C = Util.FindChild(go, "3", true);
        Num_GO = Util.FindChild(go, "go", true);
        Num_A.SetActive(false);
        Num_B.SetActive(false);
        Num_C.SetActive(false);
        Num_GO.SetActive(false);
    }

    void Update()
    {

        //���� ���۽� ����
        if (Timer == 0)
        {
            //Time.timeScale = 0.0f;
        }

        //Timer �� 90���� �۰ų� ������� Timer �������
        if (Timer <= 90)
        {
            Timer++;

            // Timer�� 30���� ������� 3���ѱ�
            if (Timer < 30)
            {
                Num_C.SetActive(true);
            }

            // Timer�� 30���� Ŭ��� 3������ 2���ѱ�
            if (Timer > 30)
            {
                Num_C.SetActive(false);
                Num_B.SetActive(true);
            }

            // Timer�� 60���� ������� 2������ 1���ѱ�
            if (Timer > 60)
            {
                Num_B.SetActive(false);
                Num_A.SetActive(true);
            }

            //Timer �� 90���� ũ�ų� ������� 1������ GO �ѱ� LoadingEnd () �ڷ�ƾȣ��
            if (Timer >= 90)
            {
                Num_A.SetActive(false);
                Num_GO.SetActive(true);
                StartCoroutine(this.LoadingEnd());
                Time.timeScale = 1.0f; //���ӽ���
            }
        }

    }

    IEnumerator LoadingEnd()
    {
        yield return new WaitForSeconds(1.0f);
        Num_GO.SetActive(false);
    }

}