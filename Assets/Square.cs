using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour
{
    [SerializeField] GameObject Box1;
    [SerializeField] GameObject Box2;
    [SerializeField] Text Score1;
    [SerializeField] Text Score2;
    [SerializeField] bool IsGameFinished;
    [SerializeField] GameObject Player1Win;
    [SerializeField] GameObject Player2Win;
    [SerializeField] GameObject PlayAgain;
    int Number1;
    int Number2;
    public void Grow1()
    {
        Box1.transform.localScale += new Vector3(.04f, .04f, 0);
        Debug.Log("W key has been pressed ^_^");
    }

    public void Grow2()
    {
        Box2.transform.localScale += new Vector3(.04f, .04f, 0);
        Debug.Log("O key has been pressed ^_^");
    }

    public void CheckWinner1()
    {
        if (Number1 >= 100)
        {
            IsGameFinished = true;
            Player1Win.SetActive(true);
            PlayAgain.SetActive(true);
            Debug.Log("Player1 Wins");
        }
        else return;
    }

    public void CheckWinner2()
    {
        if (Number2 >= 100)
        {
            IsGameFinished = true;
            Player2Win.SetActive(true);
            PlayAgain.SetActive(true);
            Debug.Log("Player2 Wins");
        }
        else return;
    }



    // Start is called before the first frame update
    void Start()
    {
        int Number1 = 1;
        int Number2 = 1;
        IsGameFinished = false;
        Player1Win.SetActive(false);
        Player2Win.SetActive(false);
        PlayAgain.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (IsGameFinished == false)
            {
                Grow1();
                Number1 += 1;
                Score1.text = Number1.ToString();
                CheckWinner1();
                
            }
            else { return; }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (IsGameFinished == false)
            {
                Grow2();
                Number2 += 1;
                Score2.text = Number2.ToString();
                CheckWinner2();

            }
            else { return; }
        }


    }

}
