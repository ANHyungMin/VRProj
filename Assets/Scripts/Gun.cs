using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // �Ѿ��� ���� - ������ [����]
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firePos;
    public TMP_Text txtBulletCount;
    
    private void Start()
    {
        RefreshBulletCountUI();
    }

    // �Ѿ��� �߻� - ��� [�Լ�]
    public void Shoot()
    {
        if (bulletCount <= 0)
            return;
        //������Ʈ�� ����
        // Instantiate(bullet);
        
        //������Ʈ�� firePos�� ����
        // Instantiate(bullet, firePos);
        
        //������Ʈ�� Vector3�� ��ġ, Quaternion�� ȸ������ ����
        // Instantiate(bullet, Vector3.one, Quaternion.identity);
        
        //������Ʈ�� firePos�� ��ġ, firePos�� ȸ������ ����
        Rigidbody bulletObj = Instantiate(bullet, firePos.position, firePos.rotation);
        //������ �ҷ��� �̹� ��������ִ� �����տ� ������ ������ bulletObj��� ����?�� �����ؼ� ������ �����Ǵ� ������Ʈ�� �����Ҽ� �ְ��Ѵ�
        
        //���Ϸ� �ޱ��� �ν�����â�� X,Y,Z���� ����Ѵ�.      �׸��� ������ rotation�� Quaternion�� ������ ����Ƽ ���������� ����ϴ°Ŷ� ��������.
        bulletObj.AddForce(firePos.forward * 100, ForceMode.Impulse);

        bulletCount--;

        RefreshBulletCountUI();
    }

    void RefreshBulletCountUI()
    {
        txtBulletCount.text = bulletCount.ToString();
    }
}
