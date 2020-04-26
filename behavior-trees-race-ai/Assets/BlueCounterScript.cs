using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueCounterScript : MonoBehaviour
{
    private int _counter = 0;

    public void incrementBlue()
    {
        ++_counter;
        this.GetComponent<Text>().text = _counter.ToString();
    }
}
