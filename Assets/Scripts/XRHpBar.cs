using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRHpBar : MonoBehaviour
{
    public GameObject[] cube;

    public void SetHP(int hp)
    {
        cube[hp].SetActive(false);
    }
}
