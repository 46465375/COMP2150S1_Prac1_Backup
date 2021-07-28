using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(CircleCollider2D))]


public class Mole : MonoBehaviour
{
    public Color color;
    private SpriteRenderer sprite;
    public float colorDelay;
    private float timer;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = color;
    } 

    void OnMouseDown()
    {
        sprite.color = Color.red;
        timer = colorDelay;
    }

    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer<0)
        {
            sprite.color = color;
        }
    }
}
