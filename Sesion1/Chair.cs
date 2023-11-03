using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : MonoBehaviour
{
    ExamPlayerController examPlayerController;
    GameObject[] chairs;
    public float chairDistance = 0f;
    // Start is called before the first frame update
    void Start()
    {
        examPlayerController = GameObject.Find("Player").GetComponent<ExamPlayerController>();
        examPlayerController.OnReachTableau += MakeChairsMove;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MakeChairsMove() {
        chairs = GameObject.FindGameObjectsWithTag("Chair");
        Vector3 playerPosition = GameObject.Find("Player").transform.position;
        foreach(GameObject chair in chairs) {
            chair.transform.position = new Vector3(playerPosition.x + Random.Range(-chairDistance, chairDistance), 
                playerPosition.y + Random.Range(-chairDistance, chairDistance), playerPosition.z + Random.Range(-chairDistance, chairDistance));
        }
    }
}
