using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Rigidbody playerRigidBody;

    public UnityEngine.UI.Text LitereColectate;
    public UnityEngine.UI.Text TextGameOver;
    private string LitereleMele;

    void Start()
    {
        LitereleMele = "";
        LitereColectate.text = "";
        TextGameOver.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        playerRigidBody.AddForce(movement * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        print("abc");
        if (other.gameObject.tag == "Collect")
        {
            print("def");
            other.gameObject.SetActive(false);

            LitereleMele = LitereleMele + other.gameObject.name;
            LitereColectate.text = "Ai colectat pana acum: " + LitereleMele;

            if(LitereleMele.Equals("ETTI"))
            {
                TextGameOver.text = "YOU WIN";
            }else
            {
                if(LitereleMele.Length == 1 && LitereleMele.Equals("E") == false)
                {
                    TextGameOver.text = "YOU LOSE";
                }
                if (LitereleMele.Length == 2 && LitereleMele.Equals("ET") == false)
                {
                    TextGameOver.text = "YOU LOSE";
                }
                if (LitereleMele.Length == 3 && LitereleMele.Equals("ETT") == false)
                {
                    TextGameOver.text = "YOU LOSE";
                }
                if (LitereleMele.Length >3 )
                {
                    TextGameOver.text = "YOU LOSE";
                }
            }
        }
    }

}
