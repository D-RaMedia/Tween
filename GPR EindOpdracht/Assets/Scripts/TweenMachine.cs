using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenMachine : MonoBehaviour
{
    private List<Tween> _activeTweens = new List<Tween>();
    private List<PositionTween> _positionTween = new List<PositionTween>();
    private List<ScaleTween> _scaleTween = new List<ScaleTween>();
    private List<RotateTween> _rotationTween = new List<RotateTween>();

    private void Update()
    {
        if (_activeTweens.Count < 1) return;
        {
            foreach (var tween in _activeTweens)
            {
                tween.UpdateTween(Time.deltaTime);
            }
        }

        if (_positionTween.Count < 1) return;
        {
            foreach (var tween in _positionTween)
            {
                tween.UpdateTween(Time.deltaTime);
            }
        }

        if (_scaleTween.Count < 1) return;
        {
            foreach (var tween in _scaleTween)
            {
                tween.UpdateTween(Time.deltaTime);
            }
        }

        if (_rotationTween.Count < 1) return;
        {
            foreach (var tween in _rotationTween)
            {
                tween.UpdateTween(Time.deltaTime);
            }
        }
    }

    public void MoveGameObject(GameObject objectToMove, Vector3 targetPosition, float speed, Func<float, float> EaseMethod)
    {
        var newTween = new PositionTween(objectToMove, targetPosition, speed, EaseMethod);
        _activeTweens.Add(newTween);
    }

    public void PositionGameObject(GameObject objectToMove, Vector3 targetPosition, float speed, Func<float, float> EaseMethod)
    {
        var newTween = new PositionTween(objectToMove, targetPosition, speed, EaseMethod);
        _positionTween.Add(newTween);
    }

    public void RotateGameObject(GameObject objectToMove, Vector3 targetPosition, float speed, Func<float, float> EaseMethod)
    {
        var newTween = new RotateTween(objectToMove, targetPosition, speed, EaseMethod);
        _rotationTween.Add(newTween);
    }

    public void ScaleGameObject(GameObject objectToMove, Vector3 targetPosition, float speed, Func<float, float> EaseMethod)
    {
        var newTween = new ScaleTween(objectToMove, targetPosition, speed, EaseMethod);
        _scaleTween.Add(newTween);
    }
}