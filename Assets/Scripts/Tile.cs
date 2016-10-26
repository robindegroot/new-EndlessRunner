using UnityEngine;
using System.Collections;
public class Tile : MonoBehaviour
{

    [SerializeField]
    private GameObject[] tracks;
    public GameObject newTrack;
    [SerializeField]
    private Transform trackPosition;

    void Start()
    {
        trackPosition.position = new Vector3(0f, 0f, 0f);
        StartCoroutine(WaitAndPrint(2F));
    }
  
    IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            newTrack = Instantiate(tracks[Random.Range(0, tracks.Length)], trackPosition.position, Quaternion.identity) as GameObject;
            Vector3 temp = trackPosition.position;
            temp.z += 10;
            temp.y = 0;
            temp.x = 0;
            trackPosition.position = temp;
            yield return new WaitForSeconds(1);
        }

    }
}