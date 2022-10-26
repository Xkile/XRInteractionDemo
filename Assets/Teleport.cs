using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget; //The variable for the teleport position
    public GameObject thePlayer; //The variable for the teleporting player

    public void onbutton()
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }

}
