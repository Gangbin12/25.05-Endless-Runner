using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] List<GameObject> roads;

    void Update()
    {
        for (int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(speed * Vector3.back * Time.deltaTime);
        }
    }
}
