using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject FirstPersonPlayer;

    private void OnTriggerEnter(Collider other)
    //{
     // if(this.gameObject.name == "DoorToCastle")
      {
          FirstPersonPlayer.transform.position = new Vector3(-122, 43, -5);
      }

      //if(this.gameObject.name == "DoorToCliff")
     // {

    //  }
   // }
}
