using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : Tween
{
    public ScaleTween(GameObject objectToMove, Vector3 targetPosition, float speed, Func<float, float> Method) : base(objectToMove, speed, Method)
    {
        _gameObject = objectToMove;
        Target = targetPosition;
        Start = _gameObject.transform.localScale;
        Direction = Target - Start;
        _percent = 0;
        _speed = speed;
        EaseMethod = Method;
    }
}
