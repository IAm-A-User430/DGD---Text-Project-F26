using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI text;

   public InputActionReference e;

    public InputActionReference d;

    private int score = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Make the text say that the game started
        text.text = "Game Started";

        //Set our score to 0
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        //If the score is greater than or equal to 0, have the text say the score
        if (score >= 0)
        {
            text.text = "Score: " + score;
        }else if(score < 0)
        {
            text.text = "Game Over";
        }

        //If I press e the score goes up by 1
        if (e.action.triggered)
        {
            score++; 
        }else if (d.action.triggered)
        {
            score--;
        }

        //If the score is greate than or equal to  100, change the text color to khaki, otherwise change it to turquoise
        if (score >= 100)
        {
            text.color = Color.green; 
        } else
        {
            text.color = Color.yellow;
        }
        

    }
}
