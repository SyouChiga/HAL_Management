using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;

namespace Tool
{
    public abstract class Begin : EditorWindow
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        //@Toolを生成
      
        protected static void ToolCreate(string name) 
        {
            // 生成
            GetWindow<SubjectWindow>(name);
        }
        //@Main関数
        protected void ToolMain()
        {
            ToolUpdate();
            ToolDraw();
        }
        protected abstract void ToolUpdate();
        protected abstract void ToolDraw();
    }
}

#endif



