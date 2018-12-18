using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour {

    private bool isPinned = false;
    public float speed = 40f;
    public Rigidbody2D rb2;
	public Text ScoreText;
	public GameObject GameOver;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(!isPinned)
           rb2.MovePosition(rb2.position + Vector2.up * speed * Time.deltaTime);
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.Pincount++;
            isPinned = true;
			string s = Score.Pincount.ToString();
			ScoreText.text = "Score：" + s ;
        }
        else if(col.tag=="Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
			GameOver.SetActive(true);
        }
    }
}
