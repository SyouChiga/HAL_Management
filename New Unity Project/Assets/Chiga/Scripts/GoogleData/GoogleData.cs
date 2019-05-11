using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using MiniJSON;

namespace Management
{
    public class GoogleData : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Google();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void Google()
        {
            StartCoroutine(LoadGoogleSpreadSheet("Test"));
        }

        private IEnumerator LoadGoogleSpreadSheet(string _sheetName)
        {
            string URL = "https://script.google.com/macros/s/AKfycbzWO8ojS-srsVKbl1Z_sbusst3sNwlV3ZVYPVWq6hC4QcfzTjc/exec";
            var download = UnityEngine.Networking.UnityWebRequest.Get(URL + "?sheetName=" + _sheetName);

            yield return download.SendWebRequest();

            var json = Json.Deserialize(download.downloadHandler.text) as Dictionary<string, object>;

            foreach(var obj in json)
            {
                var save = obj.Key;
                var save2 = obj.Value;
            }


            Debug.Log(json);
        }
    }
}
