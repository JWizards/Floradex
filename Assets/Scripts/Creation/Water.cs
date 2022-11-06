using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{

    T[,] ResizeArray<T>(T[,] original, int rows, int cols)
    {
        var newArray = new T[rows,cols];
        int minRows = Math.Min(rows, original.GetLength(0));
        int minCols = Math.Min(cols, original.GetLength(1));
        for(int i = 0; i < minRows; i++)
            for(int j = 0; j < minCols; j++)
            newArray[i, j] = original[i, j];
        return newArray;
    }

    public void waterPlant()
    {
        GameDataManager manager = transform.parent.gameObject.GetComponent<GameDataManager>(); 
        manager.readFile();
        manager.gameData.water_days = ResizeArray(manager.gameData.water_days, manager.gameData.no_plants + 1, 30);
        manager.gameData.water_days[manager.gameData.viewing, 1] += 15; 

        manager.writeFile();
    }
}
