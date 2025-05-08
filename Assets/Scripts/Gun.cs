using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // 총알의 갯수 - 데이터 [변수]
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;
    public TMP_Text txtBulletCount;
    
    private void Start()
    {
        RefreshBulletCountUI();
    }

    // 총알을 발사 - 기능 [함수]
    public void Shoot()
    {
        if (bulletCount <= 0)
            return;
        //오브젝트를 생성
        // Instantiate(bullet);
        
        //오브젝트를 firePos에 생성
        // Instantiate(bullet, firePos);
        
        //오브젝트를 Vector3의 위치, Quaternion의 회전값에 생성
        // Instantiate(bullet, Vector3.one, Quaternion.identity);
        
        //오브젝트를 firePos의 위치, firePos의 회전값에 생성
        Rigidbody bulletObj = Instantiate(bullet, firePos.position, firePos.rotation);
        //생성의 불렛은 이미 만들어져있는 프리팹에 영향을 줌으로 bulletObj라는 변수?를 선언해서 실제로 생성되는 오브젝트에 관여할수 있게한다
        
        //오일러 앵글은 인스펙터창의 X,Y,Z값을 얘기한다.      그리고 위쪽의 rotation는 Quaternion의 값으로 유니티 내부적으로 사용하는거라 볼수없다.
        bulletObj.AddForce(firePos.forward * 100, ForceMode.Impulse);

        bulletCount--;

        RefreshBulletCountUI();
    }

    void RefreshBulletCountUI()
    {
        txtBulletCount.text = bulletCount.ToString();
    }
}
