using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public List<Text> txtLists;

    private void Awake()
    {
        // txtLists = new List<Text>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeLargeMenu(string text)
    {
        if(!txtLists.Count.Equals(0))
        txtLists[0].text = text;
    } // ChangeLargeMenu
    
} // class
