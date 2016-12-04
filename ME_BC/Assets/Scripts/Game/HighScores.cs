using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.SocialPlatforms.Impl;
using System.Collections.Generic;
using System.Linq;

public class HighScores : MonoBehaviour
{
	private string filepath;
	public List<Highscore> Scores;
	[SerializeField]
	public InputField name;
	public Text score;
	public GameObject enterName;
	public GameObject showScore;
	public List<Text> topScores;
	public Text youScore;
	Highscore playerHigh;

	void Start()
	{
		
		filepath = Application.dataPath + "/score.txt";
		if (File.Exists (filepath))
			LoadScores ();
		else
			Debug.Log ("File Not Found at " + filepath);
		name.onEndEdit.AddListener (val => {
			UpdateScores(PlayerControl.playerScore, name.text);
		});

	}

	void LoadScores()
	{
		name.ActivateInputField ();
		score.text = "Score: " + PlayerControl.playerScore.ToString();
		Scores = new List<Highscore>();
		StreamReader sr = null;
		try
		{
			sr = new StreamReader(Application.dataPath + "/" + "score.txt");
			string info = sr.ReadLine();
			if (info == null)
			{
				throw new FileNotFoundException();
			}
			while (info != null)
			{
				string[] myinfo = info.Split(',');
				// string initials = myinfo[0];
				//int score = int.Parse(myinfo[1]);
				Highscore h = new Highscore(myinfo[0], int.Parse(myinfo[1]));
				Scores.Add(h);
				info = sr.ReadLine();
			}
		}
		catch (FileNotFoundException fnfe)
		{
			if (sr != null)
				sr.Close();
			Debug.Log("File not Found..." + fnfe.Message);
			//createFile();
		}
		catch (Exception e)
		{
			Debug.Log("File not found ..." + e.Message);
			if (sr != null)
				sr.Close();
			//createFile();
		}
		finally
		{
			if (sr != null)
				sr.Close();
		}
	}

	private void createFile()
	{
		StreamWriter sw2 = new StreamWriter(Application.dataPath + "/" + "score.txt");
		/*
		List<int> highscores = new List<int>();
		for(int i = 0; i < 10; i++)
			if(Scores.Count > i)
				highscores.Add(Scores[i].score);
		
		foreach (int p in highscores)
			sw2.WriteLine(p);
		*/
		sw2.Close();
	}
	public void UpdateScores(int score, string name)
	{
		PlayerControl.playerName = name;
		playerHigh = new Highscore (name, score);
		Scores.Add(playerHigh);
		List<Highscore> OrderedScores = Scores.OrderByDescending(x => x.score).ToList();
		SavesScores(OrderedScores);
		DisplayScore (OrderedScores);


	}

	private void SavesScores(List<Highscore> ordered)
	{
		using (StreamWriter we = new StreamWriter(Application.dataPath + "/score.txt"))
		{
			foreach (Highscore score in ordered)
			{
				we.WriteLine(score.ConcString());
			}
		}
		enterName.SetActive (false);
	}
	private void DisplayScore(List<Highscore> ordered)
	{
		showScore.SetActive (true);
		for (int i = 0; i < 5; i++) {
			if (i < ordered.Count)
				topScores [i].text = (i + 1).ToString () + ": " + ordered [i].initials + " - " + ordered [i].score;
		}
			
		youScore.text = (ordered.IndexOf(playerHigh) + 1).ToString() + ": " + playerHigh.initials + " - " + playerHigh.score;

	}


}

[System.Serializable]
public struct Highscore
{
	public int score;
	public string initials;
	public Highscore(string i, int s)
	{
		score = s;
		initials = i;
	}
	/*
	public int Compare(Highscore other)
	{
		return -1 * score.CompareTo(other.score);
	}*/
	public string ConcString()
	{
		return initials + "," + score;
	}
}
