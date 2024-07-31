using UnityEngine;

/*
 * This is a tool that can be inherited by any Game Object Script,
 * will guarantee that there will be only be 1 instance allowed in the scene
 * and provide quick access to that instance through the static getter Instance
 * 
 * If you wish to use the functionality of Awake(), use Init() instead
 */

public abstract class Singleton <T> : MonoBehaviour where T : Singleton <T>
{
    //Singleton - Whatever inherits from the class, there can only be one of.
    //This will be a generic type, we don't need to know what the type is, we'll just be referring to it as 'T' 
    // An abstract class is a restricted class that cannot be used to create objects, it is just for inheritance

    private static T instance;

    //getter
    public static T Instance
    {
        //any script can access this function
        get
        {
            if (instance == null)
                Debug.LogError("No instance of " + typeof(T) + " exists in the scene.");

             
            return instance;
        }
    }


    // create the reference in Awake() 
    protected void Awake()
    { //Awake needs to be inherited so it is protected rather than private

        if (instance == null)
        {
            instance = this as T;
            Init();
        }
        
        else
        {
            Debug.LogWarning("An instance of " + typeof(T) + " already exists in the scene. Self-destructing.");
            Destroy(gameObject);
        }
    }

    // destroy the reference in OnDestroy() 
    protected void OnDestroy()
    { //OnDestroy needs to be inherited so it is protected rather than private

        if (this == instance)
        {
            instance = null;
        }

    }

    //Init will replace the functionality of Awake()
    protected virtual void Init() { }
}
