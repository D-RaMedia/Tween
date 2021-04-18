using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTester : MonoBehaviour
{
    public Vector3 targetPosition;
    public float speed;

    public EaseTypes easeType;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

            switch (easeType)
            {
               
                case EaseTypes.InQuad:
                    FindObjectOfType<TweenMachine>().MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuad);
                    break;

                case EaseTypes.InCubic:
                    FindObjectOfType<TweenMachine>().MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInCubic);
                    break;

                case EaseTypes.InQuart:
                    FindObjectOfType<TweenMachine>().MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuart);
                    break;

                case EaseTypes.InQuint:
                    FindObjectOfType<TweenMachine>().MoveGameObject(gameObject, targetPosition, speed, Easings.EaseInQuint);
                    break;
            }
    }
}