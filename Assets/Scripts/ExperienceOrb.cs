using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ExperienceOrb : MonoBehaviour
{
    public float speed = 5f; // 경험치 구슬의 이동 속도
    private Transform player; // 플레이어의 Transform

    void Start()
    {
        // "Player" 태그를 가진 게임 오브젝트를 찾아서 플레이어의 Transform을 저장
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            // 경험치 구슬을 플레이어 방향으로 일정 속도로 이동
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 경험치 구슬 삭제
            Destroy(gameObject);
        }
    }
}

