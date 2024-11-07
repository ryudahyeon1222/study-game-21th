using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // �÷��̾� �̵� �ӵ�
    public GameObject weaponPrefab; // ���� ������
    public GameObject missilePrefab;
    public float fireRate1 = 1f; // ���� �߻� ����
    public float fireRate2 = 1f;
    public int experience = 0;
    public int maxExperience = 10;      // �ִ� ����ġ
    public Slider experienceSlider;     // UI Slider ������Ʈ

    void Start()
    {
        StartCoroutine(FireWeapons());
        StartCoroutine(FireMissiles());
        experienceSlider.maxValue = maxExperience;
        experienceSlider.value = experience;
    }

    void Update()
    {
        // ����Ű �Է��� ���� �÷��̾� �̵�
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    public IEnumerator FireWeapons()
    {
        while (true) // ���� �ݺ�
        {
            Instantiate(weaponPrefab, transform.position, Quaternion.identity);
            
            yield return new WaitForSeconds(fireRate1); 
        }
    }
    public IEnumerator FireMissiles()
    {
        while (true) // ���� �ݺ�
        {
            Instantiate(missilePrefab, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(fireRate2);
        }
    }
  

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("ExpOrb"))
        {
            // ����ġ ������ ������ ����ġ ����
            experience++;
            UpdateExperienceUI();
        }
    }
    void UpdateExperienceUI()
    {
        // �����̴��� ���� ����
        experienceSlider.value = experience;
    }
}



