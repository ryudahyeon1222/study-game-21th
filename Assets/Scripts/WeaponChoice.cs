using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponChoice : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas weaponCanvas; // ���� ���� Canvas
    public Button Button1; // �Ϲ� ���� ��ư
    public Button Button2; // �̻��� ��ư
    public PlayerController weaponManager; // WeaponManager ��ũ��Ʈ ����

    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ ����
       /* Button1.onClick.AddListener(() => SelectWeapon("Weapon"));
        Button2.onClick.AddListener(() => SelectWeapon("Missile"));*/

        // Canvas �ʱ�ȭ
        weaponCanvas.gameObject.SetActive(false);

        // 10�ʸ��� ���� ���� Canvas ȣ��
        InvokeRepeating("ShowWeaponCanvas", 10f, 10f);
    }

    void ShowWeaponCanvas()
    {
        if (weaponCanvas.gameObject.activeSelf) return;

        Time.timeScale = 0; // ���� ����
        weaponCanvas.gameObject.SetActive(true); // Canvas Ȱ��ȭ
        Debug.Log("Weapon Selection Time!");
    }

    void SelectWeapon()
    {

    }
}
