using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float speed = 10f; // ���� �ӵ�
    public GameObject experienceorbPrefab;

    void Update()
    {
        // ���⸦ �������� �߻�
        transform.Translate(Vector2.up * speed * Time.deltaTime);

       
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // ���� ���̸� ����ġ ���� ����
            Instantiate(experienceorbPrefab, transform.position, Quaternion.identity);

            // �� ����
            Destroy(collision.gameObject);

            // �Ѿ� ����
            Destroy(gameObject);
        }
    }
}




