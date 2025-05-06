using UnityEngine.UI;
using TMPro;
using Unity.Mathematics.Geometry;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region Variables
    public static GameManager instance;
    public HighscoreTable highscoreTable;
    

    private string input;
    public ReadInput readInput;
    public string playerName;
    
    public GameObject gameOverPanel;
    public TMP_Text scoreText;
    public Button restartButton;
    public int scoreMultiplier = 10;
    
    private int collectableScore = 0;
    private float timeAlive;
    public bool isGameOver;

    public int finalScore;
    
    #endregion
    
    # region Singleton
    //the static instance that holds the sole object of this singleton - singleton for global instance

    
    //better for when using singletons
    void Awake()
    {
        //check to see if someone has set the instance 
        if (instance == null)
        {
            //if they haven't this is the instance
            instance = this;
            //and keep it around in other scenes - if needed 
            //DontDestroyOnLoad(this);
            
        }
        else //otherwise, if there is an existing instance 
        {
            //destroy the new instance that was just created
            Destroy(gameObject);
        }
        
    }
    #endregion
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeAlive = 0f;
        isGameOver = false;
        gameOverPanel.SetActive(false);
        
        
        UpdateScore();
        
        
    }
    
    

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {
            timeAlive += Time.deltaTime;
            UpdateScore();
        }
        
        
    }

    public void GetInfo()
    {
        //reference ReadInput and get the player's name 
        if (readInput != null)
        {
            playerName = readInput.GetInputName();
            Debug.Log("Retrieved Player Name: " + playerName);
        }
        else
        {
            Debug.LogWarning("ReadInput script not found in the scene!!");
        }
    }
    
    public void AddScore(int amount)
    {
        collectableScore += amount;
        UpdateScore();
    }
    
    
    //call this method when the player hits an obstacle
    public void GameOver()
    {
        isGameOver = true;
        Debug.Log("Game Over");
        
        //show the gameover screen
        gameOverPanel.SetActive(true);

        Debug.Log("The Final Score is: " + finalScore);
        
        
        //TODO: Have the name panel show up so player can input name and then it shows the highscore list
    }


    public void PlayerInputsName()
    {
        GetInfo();
        Debug.Log("Got the Player Name: " + playerName);
        
        //once you have player name add it to the HighscoreTable 
        
        Debug.Log("final score: "+ finalScore);

        HighscoreTable.instance.AddHighScoreEntry(finalScore, playerName);
        
        
        //once you have theplayer name hide the panel 
        gameOverPanel.SetActive(false);
        
        
    }
    
    
    
    void UpdateScore()
    {
        int survivalScore = Mathf.FloorToInt(timeAlive * scoreMultiplier);
        
        //add time/survival score and coin score to the screen
        scoreText.text = "Survival Score: " + survivalScore + " | Coins: " + collectableScore;

        finalScore = survivalScore;
        Debug.Log("Final Score is updating " + finalScore);
    }

    
    //UI button to restart game at the end of a game and seeing the highscore panel
    public void RestartGame()
    {
        //timeAlive = 0f;
        isGameOver = false;
        // gameOverPanel.SetActive(false);
        //
        // //update the score
        // UpdateScore();
        //
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }


    
}