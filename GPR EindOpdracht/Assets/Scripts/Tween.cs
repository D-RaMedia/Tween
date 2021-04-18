using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Tween
{
    protected GameObject _gameObject;

    public float _speed;
    public float _percent;
    public Func<float, float> EaseMethod;

    public Vector3 Start;
    public Vector3 Direction;
    public Vector3 Target;
    public Action OnTweenUpdate;

    public Tween(GameObject objectToTween, float speed, Func<float, float> Method)
    {
        _gameObject = objectToTween;
        _speed = speed;
        _percent = 0;
        EaseMethod = Method;

        Debug.Log("Tween Started");
    }

    public void UpdateTween(float dt)
    {
        _percent += dt / _speed;

        if (_percent < 1)
        {
            float easeStep = EaseMethod(_percent);
            _gameObject.transform.position = Start + (Direction * easeStep);
            Debug.Log(_gameObject + ": Tween Update");
            if (OnTweenUpdate != null)
                OnTweenUpdate();
        }
        else
        {
            _gameObject.transform.position = Target;
            Debug.Log("Tween Finished!");
        }
    }

    public void UpdateRotationTween(float dt)
    {
        _percent += dt / _speed;

        if (_percent < 1)
        {
            var easeStep = EaseMethod(_percent);
            _gameObject.transform.rotation = Quaternion.Euler(Start + (Direction * easeStep));
            if (OnTweenUpdate != null)
                OnTweenUpdate();
        }
        else
        {
            _gameObject.transform.rotation = Quaternion.Euler(Target);
            Debug.Log("Rotation Finished!");
        }
    }

    public void UpdateScaleTween(float dt)
    {
        _percent += dt / _speed;

        if (_percent < 1)
        {
            var easeStep = EaseMethod(_percent);
            _gameObject.transform.localScale = Start + (Direction * easeStep);
            if (OnTweenUpdate != null)
                OnTweenUpdate();
        }
        else
        {
            _gameObject.transform.localScale = Target;
        }
    }
}