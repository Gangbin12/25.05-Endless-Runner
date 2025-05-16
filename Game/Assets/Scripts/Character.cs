using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum RoadLine
{
    LEFT = -1,
    MIDDLE = 0,
    RIGHT = 1
}

public class Character : MonoBehaviour
{
    [SerializeField] RoadLine roadLine;

    void Start()
    {
        
    }

    void Update()
    {
        KeyBoard();

        
    }

    void KeyBoard()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(roadLine != RoadLine.LEFT)
            {
                roadLine--;
                gameObject.transform.Translate(new Vector3(-2, 0, 0));
            }
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(roadLine != RoadLine.RIGHT)
            {
                roadLine++;
                gameObject.transform.Translate(new Vector3(+2, 0, 0));
            }
        }
    }
}
