using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : Singleton<SpeedManager>
{
    static SpeedManager instance;

    [SerializeField] float speed = 30.0f;

    [SerializeField] float limitSpeed = 60.0f;

    public float Speed { get { return speed; } }

    public static SpeedManager Instance { get { return instance; } }

    protected void Awake()
    {
        base.Awake();

        if(instance == null)
        {
            instance = this; 
        }
    }

    private void Start()
    {
        StartCoroutine(Increase());
    }

    IEnumerator Increase()
    {
        while(speed < limitSpeed)
        {
            yield return CoroutineCache.WaitForSecond(5.0f);

            speed = speed + 2.5f;
        }
    }

}
