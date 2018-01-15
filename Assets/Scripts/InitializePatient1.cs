using UnityEngine;
using System.Data;
using System.Text;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

using MySql.Data;
using MySql.Data.MySqlClient;



public class InitializePatient1 : MonoBehaviour {
	public GameObject patient;
	public GameObject parent1;
	public string host="localhost:3306", database, user, password;
	public bool pooling = true;

	private string connectionString;
	private MySqlConnection con = null;
	private MySqlCommand cmd = null;
	private MySqlDataReader rdr = null;
	public InputField name1;
	public InputField  location;
	public InputField phone_no;
	public InputField disease;
	private Text text;
	private MD5 _md5Hash;
	public Text status1;
	public Text status2;
	public Text status3;
	public Text status1v;
	public Text status2v;
	public Text status3v;
	// Use this for initialization
	void Start () {
		int k=-50;




		// Use this for initialization





			DontDestroyOnLoad (this.gameObject);
			connectionString = "Server=" + host + ";Database=" + database + ";User=" + user + ";Password=" + password + ";Pooling=";
			if (pooling) {
				connectionString += "True";
			} else {
				connectionString += "False";
			}

		string sql = " Select * from patients ";
		cmd = new MySqlCommand (sql, con);
		Debug.Log ("e");
		rdr = cmd.ExecuteReader ();
		while (rdr.Read ()) {
			GameObject t =	Instantiate (patient, this.transform.position, this.transform.rotation) as GameObject;
			t.transform.SetParent (parent1.transform, false);
			t.GetComponent<RectTransform> ().localPosition = new Vector3 (0, k, 0);
			t.GetComponent < RectTransform > ().localScale = parent1.GetComponent<RectTransform> ().localScale;
			t.GetComponent < RectTransform > ().localRotation = Quaternion.LookRotation (Vector3.zero);
			k -= 70;
		}




		}

	
	// Update is called once per frame
	void Update () {
		
	}
}
