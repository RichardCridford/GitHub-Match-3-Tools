using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    private MatchablePool pool;

    [SerializeField] private Vector2Int dimensions;
    [SerializeField] private Text gridOutput;

    private void Start()
    {
        pool = (MatchablePool) MatchablePool.Instance;

        pool.PoolObjects(10);

        //create a grid with set dimensions

        StartCoroutine(Demo());
    }

    private IEnumerator Demo()
    {
        //take matchables from the pool

        //put them on the grid

        //swap matchables

        //remove the matchables from the grid

        //return the matchables to the pool






        //get the pooled object
        Matchable m = pool.GetPooledObject();

        //set the object as active
        m.gameObject.SetActive(true);

        
        Vector3 randomPosition;

        for (int i = 0; i != 7; i++)
        {
            randomPosition = new Vector3(Random.Range(-6f, 6f), Random.Range(-4f, 4f));

            //making a call to the Moveable class
            yield return StartCoroutine(m.MoveToPosition(randomPosition));
        }
    }
}
