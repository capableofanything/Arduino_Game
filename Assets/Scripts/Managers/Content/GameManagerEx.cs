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
    public void OnGame() { pattern.OnGame(); }
    public void FinishShowFalse() { pattern.FinishShowFalse(); }
    public bool GetFinishShow() { return pattern.GetFinishShow(); }
    public Pattern GetPattern() { return pattern; }
    public List<PatternInfo> GetPatternsList() { return pattern.GetPatterns(); }
    public bool GetStart() { return check.GetStart(); }
}

