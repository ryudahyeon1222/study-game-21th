using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Weapon : MonoBehaviour
{
    public float speed = 10f; // 무기 속도
    public GameObject experienceorbPrefab;
    private Vector2 shootDirection;
    public Transform player;

    void Start()
    {
        // 플레이어의 Transform을 받아옵니다 (PlayerController에서 설정 가능)
        if (player == null)
        {
            player = GameObject.FindWithTag("Player").transform; // "Player" 태그로 플레이어 찾기
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
            // 적을 죽이면 경험치 구슬 생성
            Instantiate(experienceorbPrefab, transform.position, Quaternion.identity);

            // 적 삭제
            Destroy(collision.gameObject);

            // 총알 삭제
            Destroy(gameObject);
        }
        
    }
}




