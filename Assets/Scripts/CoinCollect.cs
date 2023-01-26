using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    public Transform redGround;
    public Transform blueGround;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "RedCoin")
        {
            Destroy(other.gameObject);

            
        }
    }
    

}
