using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(CircleCollider2D))]


public class Mole : MonoBehaviour
{
    public Color colorDownState;
    private Color colorUpState = Color.yellow;
    private Color colorMissedState = Color.red;
    private SpriteRenderer sprite;
    public float maxDownState = 5;
    public float minDownState = 1;
    private float timerUpState = 3;
    private float timerDownState;
    private float timerMissedState = 2;
    private float timer;

    void Start()
    {
        timerDownState = Random.Range(minDownState, maxDownState);
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = colorDownState;
        timer = timerDownState;
    } 

    void OnMouseDown()
    {
        if (sprite.color == colorUpState)
        {
            sprite.color = colorDownState;
            timer = timerDownState;
        }
    }

    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <=0)
        {
            if (sprite.color == colorDownState)
            {
                sprite.color = colorUpState;
                timer = timerUpState;
            } 
            else if (sprite.color == colorUpState)
            {
                sprite.color = colorMissedState;
                timer = timerMissedState;
            }
            else if (sprite.color == colorMissedState)
            {
                sprite.color = colorDownState;
                timer = timerDownState;
            }

        }
    }
}
