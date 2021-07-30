using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    public Mole  Mole;
    public int Clob = 0;
    public int Miss = 0;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
           score.text = "Moles Clobbered " + Clob.ToString() + "\nMoles Missed " + Miss;
    }
}
