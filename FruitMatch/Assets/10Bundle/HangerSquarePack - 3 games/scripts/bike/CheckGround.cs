﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour {



    private void OnCollisionEnter2D(Collision2D collision)
    {
        AirControl.isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        AirControl.isGrounded = false;
    }
}
