using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Missile : MonoBehaviour
{
    public float speed = 10f; // ���� �ӵ�
    public GameObject experienceorbPrefab;
    private Vector2 shootDirection;
    public Transform player;
    public int num = 0;

    // Start is called before the first frame update
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
