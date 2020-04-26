using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenCounterScript : MonoBehaviour
{
    private int _counter = 0;

    public void incrementa()
    {
        ++_counter;
        this.GetComponent<Text>().text = _counter.ToString();
    }
}
