using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 1000f;
    public float sideForce = 1000f;
    public float jumpForce = 5f;


    public bool isGrounded;

    private void Start()
    {
        isGrounded = false;
    }

    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w")){
            rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s")){
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        if (isGrounded && Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, jumpForce * Time.deltaTime, 0, ForceMode.Impulse);
        }

        if (rb.position.y < -4f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //avoid player jumping further if we press spacebar in the air
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "RedCoin")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Ground1")
            isGrounded = true;
    }

    //avoid player jumping further if we press spacebar in the air
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Ground1")
            isGrounded = false;
    }
}
