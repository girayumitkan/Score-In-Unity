using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public static Score instance;
	public int score,highScore;
	public Text scoreText,highScoreText,gameOverscoreText;
	
	private void Awake(){
		instance = this;
		if(PlayerPrefs.HasKey("HighScore")){
		highScore = PlayerPrefs.GetInt("HighScore");
		highScoreText.text = highScore.ToString();
		}
		
		if(PlayerPrefs.HasKey("Score")){
		score = PlayerPrefs.GetInt("Score");
		scoreText.text = score.ToString();
		}
	}
	

    void Start()
    {
        
    }


    void Update()
    {
        
    }
	public void AddscoreEasy(){
		score++;
		UpdateHighScore();
		scoreText.text = score.ToString();
		PlayerPrefs.SetInt("Score",score);
	}
	public void AddscoreNormal(){
		score = score+2;
		UpdateHighScore();
		scoreText.text = score.ToString();
		PlayerPrefs.SetInt("Score",score);
	}
	public void AddscoreHard(){
		score = score+3;
		UpdateHighScore();
		scoreText.text = score.ToString();
		PlayerPrefs.SetInt("Score",score);
	}
	public void UpdateHighScore(){
		if(score > highScore){
			highScore = score;
			highScoreText.text = highScore.ToString();
			PlayerPrefs.SetInt("HighScore",highScore);
		}
	}
	public void ResetScore(){
		PlayerPrefs.DeleteKey("Score");
		score = 0;
		scoreText.text = score.ToString();
	}
}
