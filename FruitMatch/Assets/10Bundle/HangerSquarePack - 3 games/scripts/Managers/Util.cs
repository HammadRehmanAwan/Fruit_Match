﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Util : MonoBehaviour {

	public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
