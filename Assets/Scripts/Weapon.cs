using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Weapon : MonoBehaviour
{
    public float speed = 10f; // ���� �ӵ�
    public GameObject experienceorbPrefab;
    private Vector2 shootDirection;
    public Transform player;

    void Start()
    {
        // �÷��̾��� Transform�� �޾ƿɴϴ� (PlayerController���� ���� ����)
        if (player == null)
        {
            player = GameObject.FindWithTag("Player").transform; // "Player" �±׷� �÷��̾� ã��
        }

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");


        Vector2 moveDirection = new Vector2(moveX, moveY).normalized;

        shootDirection = moveDirection;
    }

    void Update()
    {
        
        transform.Translate(shootDirection * speed * Time.deltaTime);
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




