using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class KinectPlugin : MonoBehaviour
{
    [DllImport("KinectPlugin")]
    private static extern bool KinectPlugin_OpenDefaultDevice();

    void Awake()
    {
        Debug.Log("OpenDefaultDevice result = " + KinectPlugin_OpenDefaultDevice());
    }
}
