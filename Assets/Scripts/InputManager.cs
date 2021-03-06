﻿using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    static private KeyCode[] arrowCodes = new KeyCode[] { KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow };
    static private KeyCode[] wasdCodes = new KeyCode[] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
    static private KeyCode[] keyCodes = new KeyCode[] { KeyCode.Q, KeyCode.W, KeyCode.E, KeyCode.R,KeyCode.T,KeyCode.Y, KeyCode.U,KeyCode.I,KeyCode.O,KeyCode.P,
        KeyCode.A, KeyCode.S, KeyCode.D, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.J, KeyCode.K, KeyCode.L,
        KeyCode.Z, KeyCode.X, KeyCode.C, KeyCode.V, KeyCode.B, KeyCode.N, KeyCode.M};

    static private System.Random r;

    public static KeyCode GetRandomKeyCodeArrow()
    {
        InitializeRandom();
        int i = r.Next(0, arrowCodes.Length);
        return arrowCodes[i];
    }

    public static KeyCode GetRandomKeyCodeWASD()
    {
        InitializeRandom();
        int i = r.Next(0, wasdCodes.Length);
        return wasdCodes[i];
    }

    public static KeyCode GetRandomKeyCode()
    {
        InitializeRandom();
        int i = r.Next(0, keyCodes.Length);
        return keyCodes[i];
    }

    static void InitializeRandom()
    {
        if (r == null)
            r = new System.Random();
    }

}
