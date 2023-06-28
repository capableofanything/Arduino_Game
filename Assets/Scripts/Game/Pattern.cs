using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour
{
    private List<PatternInfo> patterns = new List<PatternInfo>();
    private bool next = false;
    private bool finishShow = false;
    private IEnumerator coroutine;
    private int difficult;

    private void Start()
    {
        difficult= 0;
    }
    private void Update()
    {
        coroutine = ShowPattern();
        StartCoroutine(coroutine);
    }
    public void FinishShowFalse()
    {
        finishShow= false;
    }
    public bool GetFinishShow()
    {
        return finishShow;
    }
    public List<PatternInfo> GetPatterns()
    {
        return patterns;
    }
    public void OnGame()
    {
        MakePattern();
    }

    private void MakePattern()
    {
        patterns.Add(RandomNum());
        next = true;
        difficult++;
        Debug.Log("Current difficult = " + difficult);
    }
    private IEnumerator ShowPattern()
    {
        yield return new WaitUntil(() => next);
        next = false;
        if (patterns.Count <= 0)
            yield return null;
       
        yield return new WaitForSeconds(1.0f);

        for (int i = 0; i < patterns.Count; i++)
        {
            for (int j = 0; j < patterns[i].patternNum.Count; j++)
            {
                int num = patterns[i].patternNum[j];
                Managers.Field.GetGrid((int)num / 4, (int)num % 4).GetComponent<Animator>().SetTrigger("Danger");
            }
            yield return new WaitForSeconds(1.0f);
        }
        finishShow= true;
    }

    private PatternInfo RandomNum()
    {
        PatternInfo info = new PatternInfo();
        for(int i =0; i<8; i++)
        {
            int random = Random.Range(0, 16);
            if(SameNum(info,random))
            {
                info.patternNum.Add(random);
            }
        }
        return info;
    }
    private bool SameNum(PatternInfo info,int num)
    {
        if (info.patternNum.Count <= 0)
            return true;

        for(int i=0;i<info.patternNum.Count;i++)
        {
            if (info.patternNum[i]==num)
            {
                return false;
            }
        }
        return true;
    }

    private void Hard()
    {
        difficult++;
    }
}

public class PatternInfo
{
    public List<int> patternNum = new List<int>();
}
