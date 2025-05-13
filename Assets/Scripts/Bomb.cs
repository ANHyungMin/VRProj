using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public int HP = 3;
    public GameObject Effect;

    // public TMP_Text txtCount;
    public XRHpBar hpBar;

    public void TryBomb()
    {
        HP--;

        UpDateHPUI();
        
        if(HP <= 0)
        {
            Instantiate(Effect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    
    void UpDateHPUI()
    {
        // txtCount.text = HP.ToString();
        hpBar.SetHP(HP);
    }
}
