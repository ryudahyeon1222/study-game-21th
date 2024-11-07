using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float speed = 10f; // 무기 속도
    public GameObject experienceorbPrefab;

    void Update()
    {
        // 무기를 위쪽으로 발사
        transform.Translate(Vector2.up * speed * Time.deltaTime);

       
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




