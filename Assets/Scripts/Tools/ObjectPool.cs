using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectPool<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected T prefab;

    // create the pool, with a specified amount of objects

    // get an object from the pool

    //return the object to the pool
}
