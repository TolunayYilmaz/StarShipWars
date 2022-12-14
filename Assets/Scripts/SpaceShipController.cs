using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    const float force = 5f;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject exploxionPrefab;
    Audio Sound;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = Camera.main.GetComponent<GameManager>();
         Sound= GameObject.FindGameObjectWithTag("Audio").GetComponent<Audio>();
    }

    // Update is called once per frame
    void Update()
    {
        ShipControl();
        Fire();
    }
    void ShipControl()
    {
        Vector3 position = transform.position;
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        if (verticalInput != 0)
        {
            position.y += verticalInput * force * Time.deltaTime;
        }
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * force * Time.deltaTime;
        }
        transform.position = position;
    }

    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   Sound.FireAndExplosion(0,0.2f);
            Instantiate(bulletPrefab, new Vector2(transform.position.x, transform.position.y+1f), Quaternion.identity);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Sound.FireAndExplosion(2);
            Instantiate(exploxionPrefab,transform.position, Quaternion.identity);
            gameManager.GameOver();

            Destroy(gameObject);
        }
    }
}
