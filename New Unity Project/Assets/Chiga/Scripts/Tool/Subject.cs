using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

#if UNITY_EDITOR
using UnityEditor;

namespace Tool
{
    public class SubjectWindow : Begin
    {
        //科目名
        private string subjectName_;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        //Window生成
        [MenuItem("Editor/SubjectScriot")]
        private static void Create()
        {
            // 生成
            ToolCreate("SubectScript");
        }
        //処理
        private void OnGUI()
        {
            ToolMain();
        }

        protected override void ToolUpdate()
        {
            //テキストフィールドの設定
            subjectName_ = GUILayout.TextField(subjectName_);
            if (GUILayout.Button("作成"))
            {
                List<string> local_string = SubjectFactory.Script(subjectName_);
                StreamWriter textfile = new StreamWriter("Assets/Chiga/Scripts/School/" + subjectName_ + ".cs", false);// TextData.txtというファイルを新規で用意
                foreach(var for_name in local_string)
                {
                    textfile.WriteLine(for_name);// ファイルに書き出したあと改行
                }
                textfile.Flush();// StreamWriterのバッファに書き出し残しがないか確認
                textfile.Close();// ファイルを閉じる
            }
        }
        protected override void ToolDraw()
        {

        }

    }
}
#endif