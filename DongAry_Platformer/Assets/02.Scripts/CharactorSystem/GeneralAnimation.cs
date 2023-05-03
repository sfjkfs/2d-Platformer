using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CharacterStates
{
    Idle,Run,Attack,Jump,Die
}
public class GeneralAnimation : StatSystem
{
    protected CharacterStates nowState;

    protected virtual void StateUpdate(CharacterStates newState)
    {
        StopCoroutine(nowState.ToString());
        nowState = newState;
        Debug.Log(nowState);
        StartCoroutine(nowState.ToString());
    }
    IEnumerator Idle()
    {
        while (true)
        {
            yield return null;
        }
    }
    IEnumerator Run()
    {
        while (true)
        {
            yield return null;
        }
    }
    IEnumerator Attack()
    {
        while (true)
        {
            yield return null;
        }
    }
    IEnumerator jump()
    {
        while (true)
        {
            yield return null;
        }
    }
    IEnumerator Die()
    {
        while (true)
        {
            yield return null;
        }
    }
}
   
