using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GridSystem<T> : Singleton<GridSystem<T>>
{
    private T[,] data;

    private Vector2Int dimensions = new Vector2Int(1, 1);

    public Vector2Int Dimensions
    {
        get
        {
            return dimensions;
        }

    }

    private bool isReady;

    public bool IsReady
    {
        get
        {
            return isReady;
        }

    }

    // initialize the data array
    public void InitializeGrid(Vector2Int dimensions)
    {
        if (dimensions.x < 1 || dimensions.y < 1)
            Debug.LogError("Grid dimensions must be positive numbers");

        this.dimensions = dimensions;

        data = new T[dimensions.x, dimensions.y];
    }

    // clear the entire grid
    public void Clear()
    {
        //insitalize the array (which will wipe all the contents) 
        data = new T[dimensions.x, dimensions.y];
    }

    // bounds check

    // check if a grid positionm is empty

    // put an item on the grid

    // get an item from the grid

    // remove an item from the grid 

    // swap 2 items on the grid 

    //convert the grid data to string






}

