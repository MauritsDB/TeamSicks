﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

/// <summary>
/// No usings in code, always import usings above class
/// Remove unused usings
/// </summary>

public class CodeConventions : MonoBehaviour 
{

    public static Action Event;

    public CodeConventions Instance
    {
        get 
        {
            return GetInstance();
        }
    }

    public int PublicTest 
    {
        get
        {
            return privateTest ;
        }
        set 
        {
            privateTest = value;
        }
    }

    private static CodeConventions instance;

    private const string CONST_TEST = "TEST123";
    private int privateTest;

    /// <summary>
    ///  No comments in code, only 
    /// </summary>
    public void PublicExample()
    {
        bool _testBool = false;
        if (_testBool)
            return;
    }

    private void PrivateExample() 
    {
        privateTest = 1;
        int _interalTest = 2;
        _interalTest = 3;


        //No interal conventions for indexes variables in for loops
        for (int i = 0; i < _interalTest; i++)
        {

        }

        foreach (var _item in new List<int>(3)) 
        {

        }
    }

    private void OnEvent()
    {

    }

    private void OnEnable()
    {
        Event += OnEvent;
    }

    private void OnDisable()
    {
        Event -= OnEvent;
    }

    private CodeConventions GetInstance() 
    {
        if(instance == null) 
        {
            instance = FindObjectOfType<CodeConventions>();
        }
        return instance;
    }

}
