using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;

public class lab18 : MonoBehaviour
{
    public Text textTemp; 
    int counter;
    // Start is called before the first frame update
    void Start()
    {
       counter = 0;
       textTemp.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Comma))
        {
             counter++;
             textTemp.text = counter.ToString();
        }
}
}

