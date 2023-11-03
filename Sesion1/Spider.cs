using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : MonoBehaviour
{
    ExamPlayerController examPlayerController;
    GameObject[] spiders;
    public float spiderSpeed = 10.0f;
    bool moveSpiders = false;
    // Start is called before the first frame update
    void Start()
    {
        examPlayerController = GameObject.Find("Player").GetComponent<ExamPlayerController>();
        examPlayerController.OnReachChaise += MakeSpidersMove;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveSpiders) {
            SpidersChase();
        }
    }

    void MakeSpidersMove() {
        moveSpiders = true;
    }

    void SpidersChase() {
        spiders = GameObject.FindGameObjectsWithTag("Spider");
        GameObject player = GameObject.Find("Player");
        foreach(GameObject spider in spiders) {
            spider.transform.Translate(Vector3.Normalize(player.transform.position - spider.transform.position)
             * spiderSpeed * Time.deltaTime);
        }

    }
}
