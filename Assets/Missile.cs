using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed = 10f;
    public int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���� �浹 ��
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // �� ����
            num++;
            if (num==2)
            {
                Destroy(gameObject); // ���� ����
            }
        }
    }

}
