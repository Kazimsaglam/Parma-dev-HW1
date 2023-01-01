using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static Counter Instance;

    public int counterValue = 0;

    public TMP_Text scoreText;

    private void Awake() => Instance = this;
    
    public void IncreseCounter()
    {
        counterValue++;
        scoreText.text = counterValue.ToString();
    }
}
