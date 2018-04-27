using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

[Serializable]
public class GitHubJson {

	public  string AccnountName = "Ts";
	public  int age = 22;
	public  string Contry = "Japan";
	public  float HP = 0;
	public  int Power = 0;

}


public static class Writejson{

	public static GitHubJson json = new GitHubJson ();
	public static string convertstringjson;
	public static string FilePath = " xxx/xxx/xxx/xxx.jspn";

	// 1.  jsonwrite(xxx,xxxx,xxx,xxx,xx,xx,xx,);
	public  static void jsonwrite(string ac ,int ag ,string co,float hp ,int po){

		json.AccnountName = ac;
		json.age = ag;
		json.Contry = co;
		json.HP = hp;
		json.Power = po;

		//2 のステップへ
		StringConvertJson (json);
	}

	// 2. jsonを string 形式に　変換
	public static void StringConvertJson(GitHubJson js){

		convertstringjson = JsonUtility.ToJson (js);

		//3 のステップへ
		JsonFileExport (convertstringjson);
	}

	//3. 指定したファイルパスに .jsonファイルとして セーヴデータができる。
	//  なお .json ではなく　.txt でも可能
	static void JsonFileExport(string convertjson){

		File.WriteAllText (FilePath, convertjson);

	}

}


