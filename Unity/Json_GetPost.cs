using System;
using System.Collections;
using System.IO;
using System.Net.Http;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Json_GetPost : MonoBehaviour
{
    public InputField idInputField;
    public InputField nameInputField;
    public InputField infoInputField;

    [SerializeField]
    InputField output;

    [SerializeField]
    string jsonUrl;

    public void SaveToJson()
    {
        WeaponData data = new WeaponData();
        data.Id = int.Parse(idInputField.text);
        data.Name = nameInputField.text;
        data.Score = int.Parse(infoInputField.text);

        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/WeaponDataFile.json", json);
    }

    async public void Login ()
    {
        string loginUrl = "";
        WeaponData data = new WeaponData();
        data.Id = int.Parse(idInputField.text);
        data.Name = nameInputField.text;

        string json = JsonUtility.ToJson(data, true);

        output.text = "Loading";
        using (var httpClient = new HttpClient())
        {
            string id="";
            string pw="";
            loginUrl = "http://localhost:61969/api/Values?id="+id+"&pw="+pw+"";
            var reponse = await httpClient.GetAsync(loginUrl);
            if (reponse.IsSuccessStatusCode)
            {
                json = await reponse.Content.ReadAsStringAsync();
                data = JsonUtility.FromJson<WeaponData>(json);

                output.text = data.ContactTitle;

                File.WriteAllText(Application.dataPath + "/WeaponDataFile.json", json);
            }

            else
            {
                output.text += reponse.ReasonPhrase;
            }
        }
    }
    async public void LoadFromJson()
    {
        string json;
        using (var httpClient = new HttpClient())
        {
            var reponse = await httpClient.GetAsync(jsonUrl);
            if (reponse.IsSuccessStatusCode)
            {
                json = await reponse.Content.ReadAsStringAsync();


                WeaponData data = JsonUtility.FromJson<WeaponData>(json);

                File.WriteAllText(Application.dataPath + "/WeaponDataFile2.json", json);

                idInputField.text = data.CustomerID;
                nameInputField.text = data.CompanyName;
                infoInputField.text = data.ContactTitle;

            }
        }
    }
}
