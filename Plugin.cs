using BepInEx;
using System;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace EightBit
{
    [BepInPlugin("com.archiverxp.marios", "8-Bit Baby", "0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public Sprite spite;
        private SpriteRenderer sr;
        public GameObject mario2;
        public Texture2D tux2d;
        AssetBundle luigi;
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {"com.archiverxp.marios"} is loaded!");
            SceneManager.LoadScene("BusStation");

            transform.position = new Vector3(0, 0, 0);
        }
        void Start()
        {
            mario2 = new GameObject("PLEASE NOTICE ME NIGHT IN THE WOODS IT WOULD BE COOL IF YOU DID!!!!!!");
            sr = mario2.AddComponent<SpriteRenderer>();
            luigi = AssetBundle.LoadFromFile(Path.Combine(Paths.PluginPath, "8BitBaby/Assets/mario"));
            tux2d = (Texture2D)luigi.LoadAsset("latest");
            spite = Sprite.Create(tux2d, new Rect(0.0f, 0.0f, tux2d.width, tux2d.height), new Vector2(0.5f, 0.5f), 100.0f);
            sr.sprite = spite;
        }
        void onGUI()
        {
            if (GUI.Button(new Rect(10, 10, 100, 30), "Cannies"))
            {
                sr.sprite = spite;
            }

        }
    }
}
