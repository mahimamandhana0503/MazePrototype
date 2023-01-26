using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject redGround;
    public GameObject blueGround;

    public void LoadColoredGrounds()
    {
        redGround.SetActive(true);
        blueGround.SetActive(true);
    }
}
