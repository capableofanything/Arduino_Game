using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager
{
    private int CurrentLevel = 1;
    public int GetCurrentLevel() { return this.CurrentLevel; }
    public void SetCurrentLevel(int lv) { this.CurrentLevel = lv; }

}
