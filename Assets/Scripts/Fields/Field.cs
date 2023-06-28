using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField]
    int height;
    [SerializeField]
    int width;

    List<List<FieldInfo>> gridArray = new List<List<FieldInfo>>();// 2 demention list
    public int GetHeight() { return height; }
    public int GetWidth() { return width; }
    public List<List<FieldInfo>> GetGridArray() { return gridArray; }
    public FieldInfo GetFieldInfo(int x, int y)
    {
        if (x > width || y > height || x < 0 || y < 0)
        { Debug.Log("RoundField GetFieldInfo out of index"); return null; }
        return gridArray[x][y];    
    }
    public GameObject GetGrid(int x, int y)
    {
        return gridArray[x][y].grid;
    } 
    public void Init()
    {
        for (int i = 0; i < width; i++)
            gridArray.Add(new List<FieldInfo>());

        int index = 0;
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                FieldInfo fieldInfo = new FieldInfo();
                fieldInfo.grid = transform.GetChild(index).gameObject;
                gridArray[i].Add(fieldInfo);
                index++;
            }
        }
    }


}

public class FieldInfo
{
    public GameObject grid;
}