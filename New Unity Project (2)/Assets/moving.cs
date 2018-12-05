using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class moving : MonoBehaviour
{
    public float Speed_move;
    int Speed_rot = 120;
    float Acceleration = 10;
    float Deceleration = 10;
    float MaxSpeed = 10;
    private int count;
    public Text countText;
    public Text winText;
    public AudioSource coinSound;
    CharacterController player;
    public string scene;

    public Text loseText;
    public Text resetText;

    public AudioSource shootAudio;
    private WaitForSeconds duration = new WaitForSeconds(0.05f);
    private ParticleSystem explosion;
    // public GameObject Reddot;
    public float weaponRange = 50f;
    public GameObject explosionPrefab;

    // Use this for initialization
    void Start()
    {
        player = GetComponent<CharacterController>();
        coinSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * Speed_move);
            if (Input.GetKey(KeyCode.Space))
            {
                this.transform.Translate(Vector3.forward * Time.deltaTime * (Speed_move + 3));


            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * -Speed_move);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * -Speed_rot);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * Speed_rot);

        }
        /* if (Input.GetKey(KeyCode.Q))
         {
             this.transform.Rotate(Vector3.up * Time.deltaTime * -Speed_rot);
         }
         if (Input.GetKey(KeyCode.E))
         {
             this.transform.Rotate(Vector3.up * Time.deltaTime * Speed_rot);
         }*/

        if (Input.GetKey(KeyCode.R))
        {
            PlayerPrefs.DeleteAll();
            SceneManager.LoadScene(scene);
            Time.timeScale = 1;
        }

        //shooting function

        if (Input.GetKeyDown(KeyCode.F))
        {

            RaycastHit ray;
            //StartCoroutine(ShootEffect());
            StartCoroutine(ShootEffect());


            if (Physics.Raycast(transform.position, transform.forward, out ray, weaponRange))
            {

                // Instantiate(Reddot, ray.point, Quaternion.LookRotation(ray.normal));

                // 'out' causes the parameter to be passed by reference
                if (ray.collider.gameObject.tag == "enemy")
                {
                    Instantiate(explosionPrefab, ray.point, Quaternion.identity);

                    Destroy(ray.collider.gameObject);


                    // AddScore(scoreValue);
                    //  Explode(transform.position);

                }
            }




        }












    }
    private IEnumerator ShootEffect()
    {
        shootAudio.Play();
        //  _lr.enabled = true;

        yield return duration;

        // _lr.enabled = false;

    }

    void OnTriggerEnter(Collider other)
    {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Pick Up"))
        {
            coinSound.Play();
            // Make the other game object (the pick up) inactive, to make it disappear
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 1;

            // Run the 'SetCountText()' function (see below)
            SetCountText();
        }

        if (other.gameObject.CompareTag("enemy"))
        {
            //hitSound.Play();
            // Make the other game object (the pick up) inactive, to make it disappear
            //other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            other.gameObject.SetActive(false);
            // Run the 'SetCountText()' function (see below)
            SetLoseCountText();
        }
    }

    void SetLoseCountText()
    {
        loseText.text = "You Died!!!";
        resetText.text = "Press R to restart!";
        Time.timeScale = 0;


    }

    void SetCountText()
    {
        // Update the text field of our 'countText' variable
        countText.text = "Score: " + count.ToString();

        // Check if our 'count' is equal to or exceeded 12
        if (count >= 6)
        {
            // Set the text value of our 'winText'
            winText.text = "You Win!";
        }
    }
}

