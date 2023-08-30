using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingGame : MonoBehaviour
{
    private IEnumerator coroutine;

    private bool bombFinished = false;
    private bool showFinished = false;

    private static int level=1;

    public GameObject Count;


    public static void ChangeLevel(int lv) { level = lv; }
    private void OnCount()
    {
        Count.SetActive(true);
    }
    private void Start()
    {
        GameObject go = Managers.Menu.GetMenu();
        Count = Managers.Resource.Instantiate("UI/Counter", go.transform);

        coroutine = Convolution(level);
        StartCoroutine(coroutine);

    }

    private IEnumerator ShowPattterns()
    {

        yield return null;
    }

    private IEnumerator Convolution(int level)
    {
        for (int iteration = 1; iteration <= (level+4); iteration++)
        {
            OnCount();
            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);
            Count.GetComponent<Count>().finishedCount = false;

            for (int patternIndex = 0; patternIndex < iteration; patternIndex++)
            {
                StartCoroutine(Pattern_To_Show(Patterns.Get_Index_By_Order(patternIndex)));
                yield return new WaitUntil(() => showFinished);
            }

            OnCount();
            yield return new WaitUntil(() => Count.GetComponent<Count>().finishedCount);
            Count.GetComponent<Count>().finishedCount = false;

            for (int patternIndex = 0; patternIndex < iteration; patternIndex++)
            {
                StartCoroutine(Pattern_To_Bomb(Patterns.Get_Index_By_Order(patternIndex)));
                yield return new WaitUntil(() => bombFinished);
            }
        }

        ClearGame();
        yield return null;
    }

    private void ClearGame()
    {
        if (Managers.Player.IsAlive())
        {
            Managers.Resource.Instantiate("Background/Victory");
        }
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

    //ÆÐÅÏ ÀÚ¸®¿¡ Æø¹ß -> »ç¶óÁü
    private IEnumerator Pattern_To_Bomb(int[] pattern)
    {
        bombFinished = false;

        //yield return new WaitForSeconds(1.0f);
        for (int i=0;i<pattern.Length;i++)
        {
            Managers.Monster.ActivateBomb(pattern[i]);
        }

        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < pattern.Length; i++)
        {
            Managers.Monster.DeactivateBomb(pattern[i]);
        }

        //yield return new WaitForSeconds(1.0f);

        bombFinished = true;
    }

}
public class Patterns
{
    public static int[] Get_Index_By_Order(int order)
    {
        if(order == 0) { return Get_Left_Idx();}
        else if(order == 1) { return  Get_Right_Idx(); }
        else if(order == 2) {  return Get_Top_Idx(); }
        else if(order == 3) {  return Get_Bottom_Idx(); }
        else if(order == 4) {  return Get_Left_Idx(); }
        else if(order == 5) {  return Get_Middle_Idx(); }
        else if (order == 6) { return Get_Middle2_Idx(); }
        else if (order == 7) { return Get_Left_Half_Idx(); }
        else if (order == 8) { return Get_Right_Half_Idx(); }
        else if (order == 9) { return Get_Top_Half_Idx(); }
        else if (order == 10) { return Get_Bottom_Half_Idx(); }
        else if (order == 11) { return Get_Left_Botttom_Arrow(); }
        else if (order == 12) { return Get_Right_Botttom_Arrow(); }
        else if (order == 13) { return Get_Left_Top_Arrow(); }
        else if (order == 14) { return Get_Right_Top_Arrow(); }
        return null;
    }
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
