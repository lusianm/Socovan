using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody playerRigidbody;
    private Transform playerTransform;

    bool jump = false;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //입력이 들어오면 -1 ~ +1 사이의 값을 반환
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        //Object에 힘을 가하는 함수
        //playerRigidbody.AddForce(inputX * speed, 0, inputZ*speed);

        //입력값을 가지는 3차원 백터 변수 생성
        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        //입력 값에 속도를 계산 하여 저장
        velocity *= speed;

        //중력의 정상작용을 위해 원래 y의 속도를 velocity 변수에 대입
        //이 작업이 없으면 y속도가 매번 0으로 초기화 되서 중력 가속도를 받지 못함
        velocity.y = playerRigidbody.velocity.y;

        //Rigidbody의 속도부분에 입력된 속도를 대입
        playerRigidbody.velocity = velocity;

        
    }
}
