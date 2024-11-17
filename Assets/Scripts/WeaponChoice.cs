using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponChoice : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas weaponCanvas; // 무기 선택 Canvas
    public Button Button1; // 일반 무기 버튼
    public Button Button2; // 미사일 버튼
    public PlayerController weaponManager; // WeaponManager 스크립트 참조

    void Start()
    {
        // 버튼 클릭 이벤트 연결
       /* Button1.onClick.AddListener(() => SelectWeapon("Weapon"));
        Button2.onClick.AddListener(() => SelectWeapon("Missile"));*/

        // Canvas 초기화
        weaponCanvas.gameObject.SetActive(false);

        // 10초마다 무기 선택 Canvas 호출
        InvokeRepeating("ShowWeaponCanvas", 10f, 10f);
    }

    void ShowWeaponCanvas()
    {
        if (weaponCanvas.gameObject.activeSelf) return;

        Time.timeScale = 0; // 게임 멈춤
        weaponCanvas.gameObject.SetActive(true); // Canvas 활성화
        Debug.Log("Weapon Selection Time!");
    }

    void SelectWeapon()
    {

    }
}
