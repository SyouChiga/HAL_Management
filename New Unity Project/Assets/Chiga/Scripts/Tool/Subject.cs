using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if UNITY_EDITOR
using UnityEditor;

namespace Tool
{
    public class Subject : Begin
    {
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

        }
        protected override void ToolDraw()
        {

        }



    }
}
#endif