using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject cubePrefab;

    void Start()
    {
        //Instantiate(cubePrefab); //makes copy of cube
        makeWallV();
        makeWallFloor(0);
        makeWallFloor(5);
        makeWallSide(0);
        makeWallSide(6);
    }

    void makeWallV()
    {
        for (int col = 0; col <= 5; col++)
        {
            for (int row = 0; row <= 5; row++)
            {
                Instantiate(cubePrefab, new Vector3(col ,row,0), Quaternion.identity);
            }
        }
    }

    void makeWallFloor(int where)
    {
        for (int col = 0; col <= 5; col++)
        {
            for (int row = 0; row <= 5; row++)
            {
                Instantiate(cubePrefab, new Vector3(col, where, row), Quaternion.identity);
            }
        }
    }

    void makeWallSide(int where)
    {
        for (int col = 0; col <= 5; col++)
        {
            for (int row = 0; row <= 5; row++)
            {
                Instantiate(cubePrefab, new Vector3(where, col, row), Quaternion.identity);
            }
        }
    }
}
