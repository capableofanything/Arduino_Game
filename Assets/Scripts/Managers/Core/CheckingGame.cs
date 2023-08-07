using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingGame : MonoBehaviour
{
    private IEnumerator coroutine;

    private bool bombFinished = false;
    private bool showFinished = false;
    //private IEnumerator coroutine2;
    //private bool start;
    //private bool nextStage;
    //private bool disappearFunc;

    public GameObject Count;

    public void OnCount()
    {
        Count.SetActive(true);
    }
    private void Start()
    {
        GameObject go = Managers.Menu.GetMenu();
        Count = Managers.Resource.Instantiate("UI/Counter", go.transform);

        coroutine = Convolution();
        StartCoroutine(coroutine);

    }

    private IEnumerator ShowPattterns()
    {

        yield return null;
    }
    private IEnumerator Convolution()
    {
        {//1
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행
            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행
            }
        }

        {//2
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행
            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행
            }
        }

        {//3
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Bottom_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행
            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Bottom_Idx()));//3번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행
            }
        }

        {//4
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Bottom_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행
            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Bottom_Idx()));//3번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//4번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행
            }
        }

        {//5
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Bottom_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행
            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Bottom_Idx()));//3번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//4번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Half_Idx()));//5번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

            }
        }

        {//6
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Bottom_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Middle_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Bottom_Idx()));//3번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//4번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Half_Idx()));//5번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Middle_Idx()));//6번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

            }
        }

        {//7
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Bottom_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Middle_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Middle2_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Bottom_Idx()));//3번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//4번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Half_Idx()));//5번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Middle_Idx()));//6번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Middle2_Idx()));//7번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

            }
        }

        {//8
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Bottom_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Middle_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Middle2_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Botttom_Arrow()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행
            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Bottom_Idx()));//3번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//4번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Half_Idx()));//5번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Middle_Idx()));//6번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Middle2_Idx()));//7번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Botttom_Arrow()));//8번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

            }
        }

        {//9
            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//show
                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Bottom_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Half_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Middle_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Middle2_Idx()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Left_Botttom_Arrow()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

                StartCoroutine(Pattern_To_Show(Patterns.Get_Right_Botttom_Arrow()));

                yield return new WaitUntil(() => showFinished);//show 후 다음 실행

            }

            OnCount();

            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);//카운트 다운 끝나면 다음 실행
            Count.GetComponent<Count>().finishedCount = false;

            {//bomb
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Idx()));//1번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Idx()));//2번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Bottom_Idx()));//3번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Half_Idx()));//4번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Half_Idx()));//5번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Middle_Idx()));//6번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Middle2_Idx()));//7번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Left_Botttom_Arrow()));//8번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Right_Botttom_Arrow()));//9번째 패턴

                yield return new WaitUntil(() => bombFinished);//폭탄 터지면 다음 실행

            }
        }
        yield return null;
    }

    private IEnumerator Pattern_To_Show(int[] pattern)
    {
        showFinished = false;

        //yield return new WaitForSeconds(1.0f);
        for (int i = 0; i < pattern.Length; i++)
        {
            Managers.Monster.ActivateShow(pattern[i]);
        }

        yield return new WaitForSeconds(1.0f);

        for (int i = 0; i < pattern.Length; i++)
        {
            Managers.Monster.DeactivateShow(pattern[i]);
        }

        //yield return new WaitForSeconds(1.0f);

        showFinished = true;
    }

    //패턴 자리에 폭발 -> 사라짐
    private IEnumerator Pattern_To_Bomb(int[] pattern)
    {
        bombFinished = false;

        //yield return new WaitForSeconds(1.0f);
        for (int i=0;i<pattern.Length;i++)
        {
            Managers.Monster.ActivateBomb(pattern[i]);
        }

        yield return new WaitForSeconds(1.0f);

        for (int i = 0; i < pattern.Length; i++)
        {
            Managers.Monster.DeactivateBomb(pattern[i]);
        }

        //yield return new WaitForSeconds(1.0f);

        bombFinished = true;
    }
    //void Start()
    //{
    //    start = false;
    //    nextStage = false;
    //    disappearFunc= false;
    //    coroutine = Init();
    //    StartCoroutine(coroutine);
    //}

    //void Update()
    //{
    //    while(nextStage)
    //    {
    //        nextStage = false;
    //        coroutine = Init();
    //        StartCoroutine(coroutine);
    //    }
    //}
    //public bool GetStart() { return start; }

    //private IEnumerator Init()
    //{
    //    start = false;
    //    disappearFunc= false;
    //    Managers.Resource.Instantiate("UI/Counter");
    //    Managers.Game.OnGame();
    //    yield return new WaitUntil(() => Managers.Game.GetFinishShow());
    //    Managers.Game.FinishShowFalse();
    //    Managers.Resource.Instantiate("UI/Counter");
    //    yield return new WaitForSeconds(3.0f);

    //    start = true;//can move
    //    //발판 사라지는거 구현
    //    yield return new WaitUntil(() => start);
    //    coroutine2 = Disappear_Appear();
    //    StartCoroutine(coroutine2);
    //    yield return new WaitUntil(() => disappearFunc);
    //    nextStage = true;
    //    yield return new WaitForSeconds(3.0f);

    //}
    //private IEnumerator Disappear_Appear()
    //{
    //    yield return new WaitForSeconds(2.0f);

    //    for (int i = 0; i < Managers.Game.GetPatternsList().Count; i++)
    //    {
    //        for (int j = 0; j < Managers.Game.GetPatternsList()[i].patternNum.Count; j++)
    //        {
    //            int num = Managers.Game.GetPatternsList()[i].patternNum[j];
    //            Managers.Field.GetGrid((int)num / 4, (int)num % 4).SetActive(false);
    //        }

    //        yield return new WaitForSeconds(2.0f);

    //        for (int j = 0; j < Managers.Game.GetPatternsList()[i].patternNum.Count; j++)
    //        {
    //            int num = Managers.Game.GetPatternsList()[i].patternNum[j];
    //            Managers.Field.GetGrid((int)num / 4, (int)num % 4).SetActive(true);
    //        }
    //        yield return new WaitForSeconds(2.0f);
    //    }
    //    disappearFunc = true;
    //}
}
public class Patterns
{
    public static int[] Get_Right_Idx()
    {
        int[] result = { 4,9,14,19,24 };
        return result;
    }
    public static int[] Get_Left_Idx()
    {
        int[] result = { 0,5,10,15,20};
        return result;
    }
    public static int[] Get_Bottom_Idx()
    {
        int[] result = { 20,21,22, 23, 24 };
        return result;
    }
    public static int[] Get_Top_Idx()
    {
        int[] result = { 0,1,2,3,4 };
        return result;
    }
    public static int[] Get_Middle_Idx()
    {
        int[] result = { 2, 7, 12, 17, 22 };
        return result;
    }
    public static int[] Get_Middle2_Idx()
    {
        int[] result = {10,11,12,13,14 };
        return result;
    }
    public static int[] Get_Left_Half_Idx()
    {       
        int[] result = { 0,1,2,5,6,7,10,11,12,15,16,17,20,21,22};
        return result;
    }
    public static int[] Get_Right_Half_Idx()
    {
        int[] result = { 2,3,4,7,8,9,12,13,14,17,18,19,22,23,24 };
        return result;
    }
    public static int[] Get_Top_Half_Idx()
    {
        int[] result = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        return result;
    }
    public static int[] Get_Bottom_Half_Idx()
    {
        int[] result = { 10,11,12,13,14,15,16,17,18,19,20,21,22,23,24 };
        return result;
    }
    public static int[] Get_Left_Botttom_Arrow()
    {
        int[] result = { 4,5,8,10,11,12,15,16,17,20,21,22,23};
        return result;
    }
    public static int[] Get_Right_Botttom_Arrow()
    {
        int[] result = { 0, 6, 9, 12, 13, 14, 17, 18, 19, 21, 22, 23, 24 };
        return result;
    }
    public static int[] Get_Left_Top_Arrow()
    {
        int[] result = { 0, 1, 2, 3, 5, 6, 7, 10, 11, 12, 15, 18, 24 };
        return result;
    }
    public static int[] Get_Right_Top_Arrow()
    {
        int[] result = { 1, 2, 3, 4, 7, 8, 9, 12, 13, 14, 16, 19, 20 };
        return result;
    }

}
