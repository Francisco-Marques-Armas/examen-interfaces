using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot : MonoBehaviour
{
    ExamPlayerController examPlayerController;
    GameObject[] pots;
    // Start is called before the first frame update
    void Start()
    {
        examPlayerController = GameObject.Find("Player").GetComponent<ExamPlayerController>();
        examPlayerController.OnReachTableau += MakePotsMove;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MakePotsMove() {
        pots = GameObject.FindGameObjectsWithTag("Pot");
        foreach(GameObject pot in pots) {
            pot.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
        }
    }
}
