using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public GameManager gameManager;

    public Transform redGround;
    public Transform blueGround;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RedCoin")
        {
            Destroy(other.gameObject);

            gameManager.LoadColoredGrounds();

        }
    }
    

}
