using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManagerEx
{
    Pattern pattern;
    CheckingGame check;
    public void SetPattern(Pattern pattern) { this.pattern = pattern; }
    public void SetCheck(CheckingGame check) { this.check = check; }
    //public void ChangeLevel(int lv) { CheckingGame.ChangeLevel(lv); }
}

