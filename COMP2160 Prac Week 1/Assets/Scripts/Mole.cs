using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

    [RequireComponent(typeof(SpriteRenderer))] //Moles require a sprite renderer to show on the game screen
    [RequireComponent(typeof(CircleCollider2D))] // Moles requrie a circlecolider in order to show interaction when clicked


public class Mole : MonoBehaviour
{
    // initialisng feilds used for the moles
    public Color colorDownState;
    private Color colorUpState = Color.yellow;
    private Color colorMissedState = Color.red;
    private SpriteRenderer sprite;
    public Scorer scorer;
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
            scorer.Clob +=1;
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
                scorer.Miss +=1;
            }
            else if (sprite.color == colorMissedState)
            {
                sprite.color = colorDownState;
                timer = timerDownState;
            }

        }
    }
}
