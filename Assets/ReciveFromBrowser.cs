using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciveFromBrowser : MonoBehaviour
{
    [SerializeField]
    GameObject go;
    public void ReciveSimple() {
        go.SetActive(!go.activeSelf);
    }
}
