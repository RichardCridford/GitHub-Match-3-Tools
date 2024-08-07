using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private MatchablePool pool;

    private void Start()
    {
        pool = (MatchablePool) MatchablePool.Instance;

        pool.PoolObjects(10);

        StartCoroutine(Demo());
    }

    private IEnumerator Demo()
    {
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
