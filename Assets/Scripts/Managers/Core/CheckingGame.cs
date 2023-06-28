using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingGame : MonoBehaviour
{
    private IEnumerator coroutine;
    private IEnumerator coroutine2;
    private bool start;
    private bool nextStage;
    private bool disappearFunc;
    void Start()
    {
        start = false;
        nextStage = false;
        disappearFunc= false;
        coroutine = Init();
        StartCoroutine(coroutine);
    }

    void Update()
    {
        while(nextStage)
        {
            nextStage = false;
            coroutine = Init();
            StartCoroutine(coroutine);
        }
    }
    public bool GetStart() { return start; }

    private IEnumerator Init()
    {
        start = false;
        disappearFunc= false;
        Managers.Resource.Instantiate("UI/Counter");
        Managers.Game.OnGame();
        yield return new WaitUntil(() => Managers.Game.GetFinishShow());
        Managers.Game.FinishShowFalse();
        Managers.Resource.Instantiate("UI/Counter");
        yield return new WaitForSeconds(3.0f);

        start = true;//can move
        //발판 사라지는거 구현
        yield return new WaitUntil(() => start);
        coroutine2 = Disappear_Appear();
        StartCoroutine(coroutine2);
        yield return new WaitUntil(() => disappearFunc);
        nextStage = true;
        yield return new WaitForSeconds(3.0f);

    }
    private IEnumerator Disappear_Appear()
    {
        yield return new WaitForSeconds(2.0f);

        for (int i = 0; i < Managers.Game.GetPatternsList().Count; i++)
        {
            for (int j = 0; j < Managers.Game.GetPatternsList()[i].patternNum.Count; j++)
            {
                int num = Managers.Game.GetPatternsList()[i].patternNum[j];
                Managers.Field.GetGrid((int)num / 4, (int)num % 4).SetActive(false);
            }

            yield return new WaitForSeconds(2.0f);

            for (int j = 0; j < Managers.Game.GetPatternsList()[i].patternNum.Count; j++)
            {
                int num = Managers.Game.GetPatternsList()[i].patternNum[j];
                Managers.Field.GetGrid((int)num / 4, (int)num % 4).SetActive(true);
            }
            yield return new WaitForSeconds(2.0f);
        }
        disappearFunc = true;
    }
}
