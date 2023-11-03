using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ExamPlayerController : MonoBehaviour
{
  public float speed = 1.0f;
//   public float jumpspeed = 100.0f;
//   bool isGrounded = true;
//   int score = 0;
  Rigidbody rb;
//   private TextMeshProUGUI scoreText;
  public delegate void TableauReaching();
  public event TableauReaching OnReachTableau;
  public delegate void ChaiseReaching();
  public event ChaiseReaching OnReachChaise;

  public float tableauDistance = 1.0f;
  GameObject tableau;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
    tableau = GameObject.FindWithTag("Tableau");
    // scoreText = GameObject.Find("ScoreText").GetComponent<TextMeshProUGUI>();
    // scoreText.text = "Score: " + score.ToString();
  }

  // Update is called once per frame
  void Update()
  {
    // if (Input.GetKey(KeyCode.W)) {
    //   transform.Translate(Vector3.forward * speed * Time.deltaTime);     
    // }
    // else if (Input.GetKey(KeyCode.S)) {
    //   transform.Translate(Vector3.forward * speed * Time.deltaTime);
    // }
    // else if (Input.GetKey(KeyCode.D)) {
    //   transform.Translate(Vector3.forward * speed * Time.deltaTime);
    // }
    // else if (Input.GetKey(KeyCode.A)) {
    //   transform.Translate(Vector3.forward * speed * Time.deltaTime);
    // }
    if (Input.GetKeyDown(KeyCode.T)) {
      transform.position = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
    }
    if (Input.GetKeyDown(KeyCode.W)) {
        transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
    }
    else if (Input.GetKeyDown(KeyCode.D)) {
      transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
    }
    else if (Input.GetKeyDown(KeyCode.S)) {
        transform.Rotate(0.0f, 180.0f, 0.0f, Space.World);
    }
    else if (Input.GetKeyDown(KeyCode.A)) {
      transform.Rotate(0.0f, 270.0f, 0.0f, Space.World);
    }
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
    // if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
    //   rb.AddForce(transform.up * jumpspeed, ForceMode.Impulse);
    //   isGrounded = false;
    // }
    // Debug.Log(isGrounded);
    checkTableau();
    // checkChairs();
  }


  void OnCollisionEnter(Collision other) {
    // if (other.gameObject.CompareTag("Ground")) {
    //   Debug.Log("Hit ground");
    //   isGrounded = true;
    // }
    // if (other.gameObject.CompareTag("Spider") && !isGrounded) {
    //   score += 10;
    //   scoreText.text = "Score: " + score.ToString();
    // }
    if (other.gameObject.CompareTag("Chair")) {
        Debug.Log("Chaisse reached");
        OnReachChaise();        
    }
  }
  void checkTableau() {
    if (Vector3.Distance(transform.position, tableau.transform.position) < tableauDistance) {
        Debug.Log("Tableau reached");
        OnReachTableau();
    }
  }

//   void checkChairs() {
//     if (Vector3.Distance(transform.position, tableau.transform.position) < chairDistance) {
//         Debug.Log("Tableau reached");
//         OnReachTableau();
//     }
//   }

}
