using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    private Button _button;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;
    
    void Awake()
    {
        // TODO : Rigidbody2D 컴포넌트를 가져옴(캐싱)
        _rb2d = GetComponent<Rigidbody2D>();
        _button = GetComponent<Button>();
    }

    public void Shoot()
    {
        if (fuel > 0) 
        {
            Debug.Log("fire");
            // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
            _rb2d.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
            // 버튼 한번당 -10 바닥에 닿으면 초기화
            fuel -= FUELPERSHOOT;
        }
    }
}
