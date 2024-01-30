using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int Health = 10;

    public void AddHealth(int healthAmount)
    {
        if(healthAmount <= 0)
        {
            return;
        }

        Health += healthAmount;
    }
    public void DecreaseHealth(int healthAmount)
    {
        if (healthAmount <= 0)
        {
            return;
        }

        Health -= healthAmount;

        // 체력이 적다면..
        if (Health <= 0)
        {
            gameObject.SetActive(false);
           // Destroy(gameObject);
        }
    }

    public int GetHealth()
    {
        return Health;
    }


    private void Start()
    {
        /*// GetComponent<컴포넌트 타입>(); -> 게임 오브젝트의 컴포넌트를 가져오는 메서드
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        sr.color = Color.white;

        //Transform tr = GetComponent<Transform>();
        //tr.position = new Vector2(0f, -2.7f);
        transform.position = new Vector2(0f, -2.7f);

        PlayerMove playerMove = GetComponent<PlayerMove>();
        Debug.Log(playerMove.Speed);
        playerMove.Speed = 5f;
        Debug.Log(playerMove.Speed);*/
    }
}
